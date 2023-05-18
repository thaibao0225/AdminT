using Client.Data;
using Client.Models;
using Client.Service.Interface;

namespace Client.Service
{
    public class ProductsService : IProductsService
    {
        private ApplicationDbContext _context;
        public ProductsService(ApplicationDbContext context)
        {
            _context = context;
        }


        public List<ProductsModel> GetAllProduct()
        {
            var products = from p in _context.Products
                           join c in _context.Categories on p.CategoryId equals c.cg_Id
                           where p.isDelete == false
                           select new { p, c };


            var productsModel = products.Select(x => new ProductsModel()
            {
                pd_Id = x.p.pd_Id,
                pd_Name = x.p.pd_Name,
                pd_Img1 = x.p.pd_Img1,
                pd_Rate = x.p.pd_Rate,
                pd_Price = x.p.pd_Price,
                pd_ReducePrice = x.p.pd_ReducePrice,
                pd_Description = x.p.pd_Description,
                pd_ShortDescription = x.p.pd_ShortDescription,
                categoryName = x.c.cg_Name,
                categorySex = x.c.cg_Sex
            });
            return productsModel.ToList();
        }

        public List<ProductsModel> GetProductList(int size)
        {
            var products = from p in _context.Products
                           join c in _context.Categories on p.CategoryId equals c.cg_Id
                           where p.isDelete == false
                           select new { p, c };
            if (products.Any())
            {
                products = products.Where(x => x.p.pd_Img1 != "").Take(size);
            }

            var productsModel = products.Select(x => new ProductsModel()
            {
                pd_Id = x.p.pd_Id,
                pd_Name = x.p.pd_Name,
                pd_Img1 = x.p.pd_Img1,
                pd_Rate = x.p.pd_Rate,
                pd_Price = x.p.pd_Price,
                pd_ReducePrice = x.p.pd_ReducePrice,
                pd_Description = x.p.pd_Description,
                pd_ShortDescription = x.p.pd_ShortDescription,
                categoryName = x.c.cg_Name,
                categorySex = x.c.cg_Sex
            });
            return productsModel.ToList();
        }

        public List<ProductsModel> GetProductSearch(string productName)
        {
            var products = from p in _context.Products
                           join c in _context.Categories on p.CategoryId equals c.cg_Id
                           where p.isDelete == false
                           select new { p, c };
            if (products.Any())
            {
                products = products.Where(x => x.p.pd_Img1 != "" && x.p.pd_Name.Contains(productName));

                var productsModel = products.Select(x => new ProductsModel()
                {
                    pd_Id = x.p.pd_Id,
                    pd_Name = x.p.pd_Name,
                    pd_Img1 = x.p.pd_Img1,
                    pd_Rate = x.p.pd_Rate,
                    pd_Price = x.p.pd_Price,
                    pd_ReducePrice = x.p.pd_ReducePrice,
                    pd_Description = x.p.pd_Description,
                    pd_ShortDescription = x.p.pd_ShortDescription,
                    categoryName = x.c.cg_Name,
                    categorySex = x.c.cg_Sex
                });
                return productsModel.ToList();
            }

            return null;
        }

        public ProductsModel GetProductDetail(string productId = "")
        {
            ProductsModel productsModel = new ProductsModel();

            var products = from p in _context.Products
                           join c in _context.Categories on p.CategoryId equals c.cg_Id
                           where p.pd_Id == productId && p.isDelete == false
                           select new { p, c };
            if (products.Any())
            {
                var productsFirst = products.FirstOrDefault(x => x.p.pd_Id == productId && x.p.pd_Img1 != "");

                productsModel.pd_Id = productsFirst.p.pd_Id;
                productsModel.pd_Name = productsFirst.p.pd_Name;
                productsModel.pd_Img1 = productsFirst.p.pd_Img1;
                productsModel.pd_Img2 = productsFirst.p.pd_Img2;
                productsModel.pd_Img3 = productsFirst.p.pd_Img3;
                productsModel.pd_Img4 = productsFirst.p.pd_Img4;
                productsModel.pd_Rate = productsFirst.p.pd_Rate;
                productsModel.pd_Price = productsFirst.p.pd_Price;
                productsModel.pd_ReducePrice = productsFirst.p.pd_ReducePrice;
                productsModel.pd_Description = productsFirst.p.pd_Description;
                productsModel.pd_ShortDescription = productsFirst.p.pd_ShortDescription;
                productsModel.categoryName = productsFirst.c.cg_Name;
                productsModel.categorySex = productsFirst.c.cg_Sex;

                return productsModel;
            }
            return productsModel;



        }

        public List<ProductsModel> GetProductsInType(string type, int size)
        {
            var products = from p in _context.Products
                           join c in _context.Categories on p.CategoryId equals c.cg_Id
                           where p.isDelete == false
                           select new { p, c };

            if (products.Any())
            {
                products = products.Where(x => x.c.cg_Type == type && x.p.pd_Img2 != "").Take(size);
            }

            var productsModel = products.Select(x => new ProductsModel()
            {
                pd_Id = x.p.pd_Id,
                pd_Name = x.p.pd_Name,
                pd_Img1 = x.p.pd_Img2,
                pd_Rate = x.p.pd_Rate,
                pd_Price = x.p.pd_Price,
                pd_ReducePrice = x.p.pd_ReducePrice,
                pd_Description = x.p.pd_Description,
                pd_ShortDescription = x.p.pd_ShortDescription,
                categoryName = x.c.cg_Name
            });

            return productsModel.ToList();
        }

        public List<ProductsModel> GetProductsInSex(string sex, int size = 0)
        {
            var products = from p in _context.Products
                           join c in _context.Categories on p.CategoryId equals c.cg_Id
                           where p.isDelete == false
                           select new { p, c };

            if (products.Any())
            {
                if (sex != "")
                {
                    if (size > 0)
                    {
                        products = products.Where(x => x.c.cg_Sex == sex && x.p.pd_Img1 != "").Take(size);
                    }
                    else
                    {
                        products = products.Where(x => x.c.cg_Sex == sex && x.p.pd_Img1 != "");
                    }
                }
            }

            var productsModel = products.Select(x => new ProductsModel()
            {
                pd_Id = x.p.pd_Id,
                pd_Name = x.p.pd_Name,
                pd_Img1 = x.p.pd_Img1,
                pd_Rate = x.p.pd_Rate,
                pd_Price = x.p.pd_Price,
                pd_ReducePrice = x.p.pd_ReducePrice,
                pd_Description = x.p.pd_Description,
                pd_ShortDescription = x.p.pd_ShortDescription,
                categoryName = x.c.cg_Name
            });

            return productsModel.ToList();
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
    }
}
