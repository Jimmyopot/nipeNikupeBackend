using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace NipeNikupe.Services
{
    public class NameUserIdProvider : IUserIdProvider
    {
        public string? GetUserId(HubConnectionContext connection)
        {
            // This should match the claim name you use in JWT
            return connection.User?.FindFirst("userId")?.Value;
        }
    }
}

//namespace NipeNikupe.Services
//{
//    // Tell SignalR which claim to use as the user identifier (your token sets "userId")
//    public class NameUserIdProvider : IUserIdProvider
//    {
//        public string? GetUserId(HubConnectionContext connection)
//        {
//            // the JwtTokenService adds a "userId" claim; fall back to NameIdentifier
//            return connection.User?.FindFirst("userId")?.Value
//                ?? connection.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//        }
//    }
//}
