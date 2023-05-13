using Client.Data;
using Client.Entites;
using Client.Models;
using Client.Service.Interface;

namespace Client.Service
{
    public class ContactUserService : IContactUserService
    {
        ApplicationDbContext _context;
        public ContactUserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateContactUser(string name, string email, string phone, string message)
        {
            var contact = _context.ContactUsers;

            ContactUsers contactUsers = new ContactUsers()
            {
                cu_Id = Guid.NewGuid().ToString(),
                cu_Name = name,
                cu_Email = email,
                cu_Phone = phone,
                cu_Description = message
            };
            contact.Add(contactUsers);
            await _context.SaveChangesAsync();
        }

        public List<ContactModel> GetAllContact()
        {
            var queryContact = _context.ContactUsers;
            List<ContactModel> contactUsersList = new List<ContactModel>();
            foreach (var item in queryContact)
            {
                ContactModel contactUsers = new ContactModel();
                contactUsers.cu_Id = item.cu_Id;
                contactUsers.cu_Email = item.cu_Email;
                contactUsers.cu_Phone = item.cu_Phone;
                contactUsers.cu_Name = item.cu_Name;
                contactUsers.cu_Description = item.cu_Description;

                contactUsersList.Add(contactUsers);
            }

            return contactUsersList;
        }
    }
}
