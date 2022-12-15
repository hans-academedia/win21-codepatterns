namespace _02_MVC.Models.Interfaces
{
    public interface IUserRepository
    {
        void Create(UserModel model);
        UserModel Get(int id);
        IEnumerable<UserModel> GetAll();
        void Update(UserModel model);
        void Delete(int id);
    }
}
