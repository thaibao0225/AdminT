using Client.Data;
using Client.Entites;
using Client.Models;

namespace Client.Service.Interface
{
    public interface IContactUserService
    {
        public Task CreateContactUser(string name, string email, string phone, string message);
        public List<ContactModel> GetAllContact();
    }
}
