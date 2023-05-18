using Client.Data;
using Client.Entites;
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
        
        public async Task<bool> CreateRole(RoleModel roleModel)
        {
            AppRole appRole = new AppRole();
            appRole.Id = Guid.NewGuid().ToString();
            appRole.Name = roleModel.Name;
            appRole.NormalizedName = roleModel.Name.ToUpper();
            appRole.isDelete = false;

            await _context.AppRole.AddAsync(appRole);
            await _context.SaveChangesAsync();

            return true;
        }

        public List<RoleModel> GetAllRolies()
        {
            var query = _context.AppRole.Where(x => x.isDelete == false);

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

        public RoleModel GetRoleById(string id)
        {
            var query = _context.AppRole.FirstOrDefault(x => x.Id == id && x.isDelete == false);

            if (query != null)
            {
                RoleModel roleModel = new RoleModel();
                roleModel.Id = query.Id;
                roleModel.Name = query.Name;

                return roleModel;
            }
            return new RoleModel();
        }

        public async Task<bool> EditRole (RoleModel roleModel)
        {
            var queryRole = _context.AppRole.FirstOrDefault(x => x.Id == roleModel.Id && x.isDelete == false);
            if (queryRole != null)
            {
                queryRole.Name = roleModel.Name;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteRole(string id)
        {
            var queryRole = _context.AppRole.FirstOrDefault(x => x.Id == id);
            if (queryRole != null)
            {
                queryRole.isDelete = true;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
