using Client.Data;
using Client.Entites;

namespace Client.Service
{
    public class ContactUserService : IContactUserService
    {
        public async Task CreateContactUser(ApplicationDbContext _context, string name, string email, string phone, string message)
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
    }
}
