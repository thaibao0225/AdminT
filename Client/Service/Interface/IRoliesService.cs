using Client.Models;

namespace Client.Service.Interface
{
    public interface IRoliesService
    {
        public List<RoleModel> GetAllRolies();
        public RoleModel GetRoleById(string id);
        public Task<bool> EditRole(RoleModel roleModel);
        public Task<bool> DeleteRole(string id);
    }
}
