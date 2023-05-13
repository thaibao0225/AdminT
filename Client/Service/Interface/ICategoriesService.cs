using Client.Models;

namespace Client.Service.Interface
{
    public interface ICategoriesService
    {
        public List<CategoriesModel> GetAllCategories();
    }
}
