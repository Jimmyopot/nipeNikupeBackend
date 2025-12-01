namespace NipeNikupe.Services
{
    /// <summary>
    /// Admin credentials configuration.
    /// Developers can easily modify these credentials as needed.
    /// For production, consider moving these to appsettings.json or environment variables.
    /// </summary>
    public static class AdminCredentials
    {
        // ⚠️ EASILY MODIFIABLE CREDENTIALS ⚠️
        // Change these values to update admin access
        public const string AdminEmail = "admin@example.com";
        public const string AdminPassword = "Admin@123";

        // Optional: Support multiple admin accounts
        public static readonly Dictionary<string, string> AdminAccounts = new()
        {
            { "admin@example.com", "Admin@123" },
            { "superadmin@example.com", "SuperAdmin@456" }
            // Add more admin accounts here as needed
        };

        /// <summary>
        /// Validates admin credentials against configured accounts
        /// </summary>
        public static bool ValidateCredentials(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return false;

            // Check if email exists and password matches
            return AdminAccounts.TryGetValue(email.Trim().ToLowerInvariant(), out var storedPassword)
                   && storedPassword == password;
        }
    }
}
