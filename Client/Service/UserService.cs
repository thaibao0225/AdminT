using Client.Data;
using Client.Service.Interface;
using Client.Models;
using Client.Entites;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace Client.Service
{
    public class UserService : IUserService 
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {

            _context = context;
        }

        public List<UserModel> GetUsers()
        {
            var query = _context.AppUser;

            List<UserModel> userList = new List<UserModel>();
            foreach (var item in query)
            {
                UserModel userModel = new UserModel();
                userModel.Id = item.Id;
                userModel.Name = item.UserName;
                userModel.Password = item.PasswordHash;
                userModel.Email = item.Email;
                userList.Add(userModel);
            }

            return userList;
        }

        public UserModel GetUserById(string userId)
        {
            var query = _context.AppUser.FirstOrDefault(x => x.Id == userId);

            if(query != null)
            {
                UserModel userModel = new UserModel();
                userModel.UserName = query.UserName;
                userModel.Email = query.Email;

                return userModel;

            }

            return new UserModel();
        }

        public async Task<bool> EditUser(UserModel userModel)
        {
            if (userModel != null)
            {
                var queryUser = _context.AppUser.FirstOrDefault(x => x.Id == userModel.Id);

                if(queryUser != null)
                {
                    queryUser.UserName = userModel.UserName;
                    queryUser.Email = userModel.Email;

                    await _context.SaveChangesAsync();

                    return true;
                }
                
            }
            return false;   
        }


        public async Task<bool> DeleteUser(string idUser)
        {
            if (idUser != "")
            {
                var queryUser = _context.AppUser.FirstOrDefault(x => x.Id == idUser);

                if (queryUser != null)
                {

                    _context.AppUser.Remove(queryUser);
                    await _context.SaveChangesAsync();
                    return true;
                }

            }
            return false;
        }
    }
}
