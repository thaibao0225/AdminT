using AspNetCore;
using Client.Data;
using Client.Entites;
using Client.Models;
using Client.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Client.Service
{
    public class CategoriesService : ICategoriesService
    {
        private ApplicationDbContext _context;
        public CategoriesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> createCategory(CategoriesModel categoriesModel)
        {
            Categories categories = new Categories();
            categories.cg_Id = Guid.NewGuid().ToString();
            categories.cg_Name = categoriesModel.CategoryName;
            categories.cg_Type = categoriesModel.CategoryType;
            categories.cg_Sex = categoriesModel.CategorySex;

            await _context.Categories.AddAsync(categories);
            await _context.SaveChangesAsync();

            return true;
        }

        public List<CategoriesModel> GetAllCategories()
        {
            var query = _context.Categories.Where(c => c.idDelete == false);

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

        public List<CategoriesModel> GetCategories(int size = 0)
        {
            var categories = from c in _context.Categories
                             where c.idDelete == false
                             select c;

            if (size != 0)
            {
                categories = categories.Take(size);
            }

            var categoriesModel = categories.Select(x => new CategoriesModel()
            {
                CategorySex = x.cg_Sex
            });

            return categoriesModel.Distinct().ToList();
        }

        public CategoriesModel getCategoryById(string id)
        {
            var query = _context.Categories.FirstOrDefault(x => x.cg_Id == id && x.idDelete ==  false);

            CategoriesModel categoriesModel = new CategoriesModel();
            
            if(query != null)
            {
                categoriesModel.CategoryId = query.cg_Id;
                categoriesModel.CategoryName = query.cg_Name;

                return categoriesModel;
            }
            return new CategoriesModel();
        }

        public async Task<bool> editCategory(CategoriesModel categoriesModel)
        {
            var query = _context.Categories.FirstOrDefault(x => x.cg_Id == categoriesModel.CategoryId && x.idDelete == false);

            if (query != null)
            {
                query.cg_Name = categoriesModel.CategoryName;
                query.cg_Type = categoriesModel.CategoryType;
                query.cg_Sex = categoriesModel.CategorySex;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> deleteCategoryById(string id)
        {
            var query = _context.Categories.FirstOrDefault(x => x.cg_Id == id && x.idDelete == false);

            if (query != null)
            {
                query.idDelete = true;
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }

    }
}
