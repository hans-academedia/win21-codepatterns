namespace _03_LSP.Models
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public UserProfileEntity Profile { get; set; }
    }
}
