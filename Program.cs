using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NipeNikupe.Data;
using NipeNikupe.Hubs;
using NipeNikupe.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// SignalR
builder.Services.AddSignalR();

// Provide SignalR a user id provider that reads "userId" claim
builder.Services.AddSingleton<Microsoft.AspNetCore.SignalR.IUserIdProvider, NipeNikupe.Services.NameUserIdProvider>();

// Configure forwarded headers for nginx reverse proxy
builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    options.KnownNetworks.Clear();
    options.KnownProxies.Clear();
});

// CORS - Fixed: removed trailing slashes and added protocols
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowViteFrontend", policy =>
//    {
//        policy.WithOrigins(
//                "http://localhost:5173",
//                "https://nipenikupe.top",
//                "http://nipenikupe.top",
//                "http://37.60.243.121",
//                "https://37.60.243.121"
//              )
//              .AllowAnyHeader()
//              .AllowAnyMethod()
//              .AllowCredentials();
//    });
//});

builder.Services.AddCors(options =>
{
    options.AddPolicy("SignalRPolicy", policy =>
    {
        policy
            .WithOrigins(
                "http://localhost:5173",
                "https://nipenikupe.top",
                "https://www.nipenikupe.top"
            )
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<JwtTokenService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Token-based Authentication
var jwtSettings = builder.Configuration.GetSection("Jwt");
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]))
    };

    // Allow the token to be passed in the query string for SignalR WebSocket negotiate
    options.Events = new JwtBearerEvents
    {
        OnMessageReceived = context =>
        {
            var accessToken = context.Request.Query["access_token"].FirstOrDefault();

            // If the request is for our SignalR hub, read the token from the query string
            var path = context.HttpContext.Request.Path;
            if (!string.IsNullOrEmpty(accessToken) &&
                (path.StartsWithSegments("/hubs/chat")))
            {
                context.Token = accessToken;
            }
            return Task.CompletedTask;
        }
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
});

var app = builder.Build();

// Use forwarded headers - MUST be before other middleware
app.UseForwardedHeaders();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// CORS must come before Authentication/Authorization
//app.UseCors("AllowViteFrontend");
//app.UseCors("AllowAll");
app.UseCors("SignalRPolicy");


app.UseAuthentication();
app.UseAuthorization();

// Map SignalR hubs
app.MapHub<ChatHub>("/hubs/chat");
app.MapHub<NotificationHub>("/hubs/notifications");

app.MapControllers();

app.Run();

