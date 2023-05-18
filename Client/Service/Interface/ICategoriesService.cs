using Client.Models;

namespace Client.Service.Interface
{
    public interface ICategoriesService
    {
        public Task<bool> createCategory(CategoriesModel categoriesModel);
        public List<CategoriesModel> GetAllCategories();
        public List<CategoriesModel> GetCategories(int size = 0);
        public CategoriesModel getCategoryById(string id);
        public Task<bool> editCategory(CategoriesModel categoriesModel);
        public Task<bool> deleteCategoryById(string id);
    }
}
