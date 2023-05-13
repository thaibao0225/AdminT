using Client.Models;

namespace Client.Service.Interface
{
    public interface IUserService
    {
        public List<UserModel> GetUsers();
    }
}
