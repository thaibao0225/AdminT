using Client.Data;
using Client.Models;
using Client.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace Client.Service
{
    public class CategoriesService : ICategoriesService
    {
        private ApplicationDbContext _context;
        public CategoriesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CategoriesModel> GetAllCategories()
        {
            var query = _context.Categories;

            List<CategoriesModel> categoriesModelsList = new List<CategoriesModel>();

            foreach (var item in query)
            {
                CategoriesModel categoriesModel = new CategoriesModel();
                categoriesModel.CategoryId = item.cg_Id;
                categoriesModel.CategoryName = item.cg_Name;
                categoriesModelsList.Add(categoriesModel);
            }

            return categoriesModelsList;
        }

    }
}
