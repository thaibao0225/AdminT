using Client.Data;

namespace Client.Service
{
    public interface IContactUserService
    {
        public Task CreateContactUser(ApplicationDbContext _context, string name, string email, string phone, string message);
    }
}
