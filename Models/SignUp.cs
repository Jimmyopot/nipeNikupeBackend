namespace NipeNikupe.Models
{
    public class SignUp
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string PasswordHash { get; set; }
        public required string Country { get; set; }
        public required string CityOrTown { get; set; }
        public required string LocalityOrArea { get; set; }
        public List<string> Skills { get; set; } = new();
        public DateTime AvailableDate { get; set; }
        public TimeSpan AvailableTime { get; set; }
    }
}
