using System.ComponentModel.DataAnnotations;

namespace _03_RESTFUL_WEBAPI_UserCatalog.Dtos
{
    public interface IUser
    {
        string Email { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
    }

    public class User : IUser
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
