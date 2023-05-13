using Client.Data;
using Client.Service.Interface;
using Client.Models;
using System.Collections.Generic;

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
    }
}
