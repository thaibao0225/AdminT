using Client.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Client.Models.Static;

namespace Client.Data
{
    public static class CreateData
    {
        public static void Seed(this ModelBuilder builder)
        {
            //Categories

            var categoryId1 = Guid.NewGuid().ToString();
            var categoryId2 = Guid.NewGuid().ToString();
            var categoryId3 = Guid.NewGuid().ToString();


            builder.Entity<Categories>().HasData(
                new Categories() {
                    cg_Id = categoryId1,
                    cg_Name = CategoryCommon.CLOTHES,
                    cg_Type = CategoryCommon.HOTTREND,
                    cg_Sale = "",
                    cg_Sex = CategoryCommon.WOMEN
                },
                new Categories()
                {
                    cg_Id = categoryId2,
                    cg_Name = CategoryCommon.CLOTHES,
                    cg_Type = CategoryCommon.BESTSALER,
                    cg_Sale = "",
                    cg_Sex = CategoryCommon.WOMEN
                },
                new Categories()
                {
                    cg_Id = categoryId3,
                    cg_Name = CategoryCommon.CLOTHES,
                    cg_Type = CategoryCommon.FEATURE,
                    cg_Sale = "",
                    cg_Sex = CategoryCommon.MEN
                }
                );


        //Id for product id
        var product1 = Guid.NewGuid().ToString();
            var product2 = Guid.NewGuid().ToString();
            var product3 = Guid.NewGuid().ToString();
            var product4 = Guid.NewGuid().ToString();
            var product5 = Guid.NewGuid().ToString();
            var product6 = Guid.NewGuid().ToString();
            var product7 = Guid.NewGuid().ToString();
            var product8 = Guid.NewGuid().ToString();
            var product9 = Guid.NewGuid().ToString();
            var product10 = Guid.NewGuid().ToString();
            var product11 = Guid.NewGuid().ToString();
            var product12 = Guid.NewGuid().ToString();
            var product13 = Guid.NewGuid().ToString();
            var product14 = Guid.NewGuid().ToString();
            var product15 = Guid.NewGuid().ToString();
            var product16 = Guid.NewGuid().ToString();
            var product17 = Guid.NewGuid().ToString();

            builder.Entity<Products>().HasData(
                new Products()
                {
                    pd_Id = product1,
                    pd_Name = "Buttons tweed blazer",
                    pd_Description = "Buttons tweed blazer",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/product/product-1.jpg",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Buttons tweed blazer",
                    pd_NameImg1 = "Buttons tweed blazer",
                    pd_NameImg2 = "name img 2",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId3,
                    isDelete = false
                },
                new Products()
                {
                    pd_Id = product2,
                    pd_Name = "Flowy striped skirt",
                    pd_Description = "Flowy striped skirt",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/product/product-2.jpg",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Flowy striped skirt",
                    pd_NameImg1 = "Flowy striped skirt",
                    pd_NameImg2 = "name img 2",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId3,
                    isDelete = false
                },
                new Products()
                {
                    pd_Id = product3,
                    pd_Name = "Cotton T-Shirt",
                    pd_Description = "Cotton T-Shirt",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/product/product-3.jpg",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Cotton T-Shirt",
                    pd_NameImg1 = "Cotton T-Shirt",
                    pd_NameImg2 = "name img 2",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId3,
                    isDelete = false
                },
                new Products()
                {
                    pd_Id = product4,
                    pd_Name = "Slim striped pocket shirt",
                    pd_Description = "Slim striped pocket shirt",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/product/product-4.jpg",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Slim striped pocket shirt",
                    pd_NameImg1 = "Slim striped pocket shirt",
                    pd_NameImg2 = "name img 2",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId3,
                    isDelete = false
                },
                new Products()
                {
                    pd_Id = product5,
                    pd_Name = "Fit micro corduroy shirt",
                    pd_Description = "Fit micro corduroy shirt",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/product/product-5.jpg",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Fit micro corduroy shirt",
                    pd_NameImg1 = "Fit micro corduroy shirt",
                    pd_NameImg2 = "name img 2",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId1,
                    isDelete = false
                },
                new Products()
                {
                    pd_Id = product6,
                    pd_Name = "Tropical Kimono",
                    pd_Description = "Tropical Kimono",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/product/product-6.jpg",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Tropical Kimono",
                    pd_NameImg1 = "Tropical Kimono",
                    pd_NameImg2 = "name img 2",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId1,
                    isDelete = false
                },
                new Products()
                {
                    pd_Id = product7,
                    pd_Name = "Contrasting sunglasses",
                    pd_Description = "Contrasting sunglasses",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/product/product-7.jpg",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Contrasting sunglasses",
                    pd_NameImg1 = "Contrasting sunglasses",
                    pd_NameImg2 = "name img 2",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId2,
                    isDelete = false
                },
                new Products()
                {
                    pd_Id = product8,
                    pd_Name = "Water resistant backpack",
                    pd_Description = "Water resistant backpack",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/product/product-8.jpg",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Water resistant backpack",
                    pd_NameImg1 = "Water resistant backpack",
                    pd_NameImg2 = "name img 2",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId2,
                    isDelete = false

                },
                new Products()
                {
                    pd_Id = product9,
                    pd_Name = "Chain bucket bag",
                    pd_Description = "Chain bucket bag",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/trend/ht-1.jpg",
                    pd_Img2 = "/Client/img/trend/ht-1.jpg",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Chain bucket bag",
                    pd_NameImg1 = "Chain bucket bag",
                    pd_NameImg2 = "Chain bucket bag",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId1,
                    isDelete = false

                },
                new Products()
                {
                    pd_Id = product10,
                    pd_Name = "Pendant earrings",
                    pd_Description = "Pendant earrings",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/trend/ht-2.jpg",
                    pd_Img2 = "/Client/img/trend/ht-2.jpg",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Pendant earrings",
                    pd_NameImg1 = "Pendant earrings",
                    pd_NameImg2 = "Pendant earrings",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId1,
                    isDelete = false

                },
                new Products()
                {
                    pd_Id = product11,
                    pd_Name = "Cotton T-Shirt",
                    pd_Description = "Cotton T-Shirt",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/trend/ht-3.jpg",
                    pd_Img2 = "/Client/img/trend/ht-3.jpg",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Cotton T-Shirt",
                    pd_NameImg1 = "Cotton T-Shirt",
                    pd_NameImg2 = "Cotton T-Shirt",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId1,
                    isDelete = false

                },
                new Products()
                {
                    pd_Id = product12,
                    pd_Name = "Cotton T-Shirt",
                    pd_Description = "Cotton T-Shirt",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/trend/bs-1.jpg",
                    pd_Img2 = "/Client/img/trend/bs-1.jpg",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Cotton T-Shirt",
                    pd_NameImg1 = "Cotton T-Shirt",
                    pd_NameImg2 = "Cotton T-Shirt",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId2,
                    isDelete = false

                },
                new Products()
                {
                    pd_Id = product13,
                    pd_Name = "Zip-pockets pebbled tote",
                    pd_Description = "Zip-pockets pebbled tote",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/trend/bs-2.jpg",
                    pd_Img2 = "/Client/img/trend/bs-2.jpg",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Zip-pockets pebbled tote",
                    pd_NameImg1 = "Zip-pockets pebbled tote",
                    pd_NameImg2 = "Zip-pockets pebbled tote",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId2,
                    isDelete = false

                },
                new Products()
                {
                    pd_Id = product14,
                    pd_Name = "Round leather bag",
                    pd_Description = "Round leather bag",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/trend/bs-3.jpg",
                    pd_Img2 = "/Client/img/trend/bs-3.jpg",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Round leather bag",
                    pd_NameImg1 = "Round leather bag",
                    pd_NameImg2 = "Round leather bag",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId2,
                    isDelete = false

                },
                new Products()
                {
                    pd_Id = product15,
                    pd_Name = "Bow wrap skirt",
                    pd_Description = "Bow wrap skirt",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/trend/f-1.jpg",
                    pd_Img2 = "/Client/img/trend/f-1.jpg",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Bow wrap skirt",
                    pd_NameImg1 = "Bow wrap skirt",
                    pd_NameImg2 = "Bow wrap skirt",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId3,
                    isDelete = false

                },
                new Products()
                {
                    pd_Id = product16,
                    pd_Name = "Metallic earrings",
                    pd_Description = "Metallic earrings",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/trend/f-2.jpg",
                    pd_Img2 = "/Client/img/trend/f-2.jpg",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Metallic earrings",
                    pd_NameImg1 = "Metallic earrings",
                    pd_NameImg2 = "Metallic earrings",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId3,
                    isDelete = false

                },
                new Products()
                {
                    pd_Id = product17,
                    pd_Name = "Flap cross-body bag",
                    pd_Description = "Flap cross-body bag",
                    pd_Price = 59,
                    pd_ReducePrice = 50000,
                    pd_Img1 = "/Client/img/trend/f-3.jpg",
                    pd_Img2 = "/Client/img/trend/f-3.jpg",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "Flap cross-body bag",
                    pd_NameImg1 = "Flap cross-body bag",
                    pd_NameImg2 = "Flap cross-body bag",
                    pd_NameImg3 = "name img 3",
                    pd_NameImg4 = "name img 4",
                    CategoryId = categoryId3,
                    isDelete = false

                }
            );
           


            //Table About
            builder.Entity<About>().HasData(
                    new About()
                    {
                        about_id = 1,
                        about_Url = "https://www.youtube.com/watch?v=F1vcruph8JA",
                        about_Title = "Footwear the leading eCommerce Store around the Globe",
                        about_Description = "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way."
                    });

            var IdRoleStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd";
            var IdRoleAdmin = "360E601E-92F2-4F08-832B-604A21293258";

            //Table AppRole
            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = IdRoleStaff,
                    Name = "Staff",
                    Description = "Staff",
                    NormalizedName = "staff"
                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "Admin",
                    Description = "Admin",
                    NormalizedName = "admin"

                });


            var IdStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff";
            var IdAdmin = "DE544998-A3CC-4E12-ABB4-0642E57BD222";

            //Table AppUser
            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = IdAdmin,
                UserName = "Admin",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "admin",
                LastName = "admin",
                DoB = new DateTime(2020, 01, 02),
                bill_Address1 = "",
                bill_Address2 = "",
                bill_City = "",
                bill_CompanyName = "",
                bill_Country = "",
                bill_PhoneNumber = "",
                bill_PostalCode = "",
                bill_State = "",
                isDelete = false

            },
            new AppUser
            {
                Id = IdStaff,
                UserName = "Staff",
                NormalizedUserName = "STAFF@GMAIL.COM",
                NormalizedEmail = "STAFF@GMAIL.COM",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "staff",
                LastName = "staff",
                DoB = new DateTime(2020, 03, 02),
                bill_Address1 = "",
                bill_Address2 = "",
                bill_City = "",
                bill_CompanyName = "",
                bill_Country = "",
                bill_PhoneNumber = "",
                bill_PostalCode = "",
                bill_State = "",
                isDelete = false
            });


            //Table AppUser - role 
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = IdStaff
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = IdAdmin
            });


            //Table ContactUsers
            var contactUser = Guid.NewGuid().ToString();

            builder.Entity<ContactUsers>().HasData(
                new ContactUsers()
                {
                    cu_Id = contactUser,
                    cu_Name = "FirstName",
                    cu_Email = "Email",
                    cu_Phone = "Phone",
                    cu_Description = "Description"
                });

            //Coupon table

            builder.Entity<Coupons>().HasData(
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode = "code10",
                    couponPrice = 10,
                    isDelete = false
                },
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode = "code50",
                    couponPrice = 50,
                    isDelete = false
                });

           //Ship table 
            string shipId = "7CF94A7D-9239-446E-A404-086518F84652";

            builder.Entity<Shipping>().HasData(
                new Shipping()
                {
                    ship_Id = shipId,
                    ship_Name = "Ship",
                    ship_Price = 5,
                    isDelete = false
                });

            //Table Contact System
            var ContactSystemId = Guid.NewGuid().ToString();

            builder.Entity<ContactSystem>().HasData(
                new ContactSystem()
                {
                    Contact_Id = ContactSystemId,
                    Contact_Address = "Address",
                    Contact_Description = "Description",
                    Contact_Email = "Email",
                    Contact_Phone = "Phone",
                    isDelete = false
                });
            

        }
    }
    
}
