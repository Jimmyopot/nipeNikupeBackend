namespace NipeNikupe.Models.DTOS
{
    public class SignUpDTO
    {
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Password { get; set; }
        public required string Country { get; set; }
        public required string CityOrTown { get; set; }
        public required string LocalityOrArea { get; set; }
        public required List<string> Skills { get; set; }
        public DateTime AvailableDate { get; set; }
        public TimeSpan AvailableTime { get; set; }
        public DateTime? LastLoginAt { get; set; }
    }
}
