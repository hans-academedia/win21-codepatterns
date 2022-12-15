namespace _01_MVC.Models.Interfaces
{
    public interface IUserContext
    {
        void Create();
        UserModel Get(int id);
        List<UserModel> GetAll();
    }
}
