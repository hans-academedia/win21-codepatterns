namespace _04_MVVM.Models.Entities
{
    public class UserEntityModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public byte[] Password { get; private set; } = null!;
        public byte[] Salt { get; private set; } = null!;
    }
}
