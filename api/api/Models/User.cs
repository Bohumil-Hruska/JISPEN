namespace api.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ServiceCode { get; set; }
        public long? VerifiedAt { get; set; }
    }
}