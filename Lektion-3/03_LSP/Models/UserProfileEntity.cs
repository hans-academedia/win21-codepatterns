namespace _03_LSP.Models
{
    public class UserProfileEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public UserEntity User { get; set; }
    }
}
