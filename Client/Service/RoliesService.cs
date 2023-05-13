using Client.Data;
using Client.Models;
using Client.Service.Interface;

namespace Client.Service
{
    public class RoliesService : IRoliesService
    {
        private readonly ApplicationDbContext _context;
        public RoliesService(ApplicationDbContext context)
        {

            _context = context;
        }

        public List<RoleModel> GetAllRolies()
        {
            var query = _context.AppRole;

            List<RoleModel> roleList = new List<RoleModel>();
            foreach (var item in query)
            {
                RoleModel roliesModel = new RoleModel();
                roliesModel.Id = item.Id;
                roliesModel.Name = item.Name;
                roleList.Add(roliesModel);
            }

            return roleList;
        }
    }
}
