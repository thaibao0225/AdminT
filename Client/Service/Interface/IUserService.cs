using Client.Models;

namespace Client.Service.Interface
{
    public interface IUserService
    {
        public List<UserModel> GetUsers();
        public UserModel GetUserById(string userId);
        public Task<bool> EditUser(UserModel userModel);
        public Task<bool> DeleteUser(string idUser);
    }
}
