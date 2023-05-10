using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Client.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactSystems",
                keyColumn: "Contact_Id",
                keyValue: "17be2bec-1a48-4fac-ac04-2ea24abc29d2");

            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cu_Id",
                keyValue: "2861e335-d944-4bfe-ad09-29474ee00106");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "443dc2fd-717b-4ab2-b221-41fd2e666627");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "d745c454-6d7e-4554-9a4e-3c2453dc305a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0ece8b03-4f09-4078-9d65-b68eea66ba53");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "22bfaf47-824b-4d12-97dc-e3b31b9f8644");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "26e857d8-2417-4656-b2d0-14792bdf8459");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "5ba126ba-a0f1-4ca6-b538-bc7879537653");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "5c27b7a7-c620-4a0f-90d7-9412b916b147");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "5c81cf11-b912-4671-9bc5-dd8db657d725");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "63ceb7d7-ac85-49f9-b5a7-d7374329380b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "7632e09f-2375-4fa1-8cd4-8f3728ad8023");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "846df313-9cf1-4e78-87b2-e6257473d6a5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "870a9363-8ee6-41d1-9d5f-2751d9726528");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "8e91fa3b-0559-450e-9c39-6b6e93ef613a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "9528a0e9-dfa2-4721-9c03-b53899750b5d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "987b433f-f1b8-4dc8-beeb-12feb44bd9ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "9b44d939-fae1-446d-b0ea-908589149a82");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a424351c-4e04-45c8-9fdb-1dd33f377cff");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c0f98071-360a-467e-8563-0a04175ac59b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f43b43ea-3883-4cf4-be8e-2b15f5a4510e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "4fc21e03-c9d2-41e0-af5d-baae5a0d9c45");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "c96957cb-daa8-4052-b0e1-69171a79a313");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "fe38339b-f83f-4fc3-a6c6-0dc821162e21");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Sex", "cg_Type" },
                values: new object[,]
                {
                    { "45deb92a-0d6f-40f2-904c-a5ddaefc7ed6", "Clothes", "", "Women", "Hot Trend" },
                    { "f2a1ade9-9078-4446-a340-91300d66f19c", "Clothes", "", "Women", "Best saler" },
                    { "ff1d9c9b-5d13-4975-9b46-58e9a7d78a8d", "Clothes", "", "Men", "Feature" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Description", "Contact_Email", "Contact_Phone" },
                values: new object[] { "8f73f634-d549-4d5f-9220-e1e6416ca1b1", "Address", "Description", "Email", "Phone" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_Name", "cu_Phone" },
                values: new object[] { "9012c838-34a1-4610-bae3-8c9ea8f2e4b8", "Description", "Email", "FirstName", "Phone" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "bc25dab8-4deb-42da-aedc-fa09f47fbe51", "code50", 50 },
                    { "d603b22b-fa33-47e4-95c0-fe56cf64d8c8", "code10", 10 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "2d269b09-9067-48db-beb0-1746bbb3b1b1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "33c16255-3d9c-4083-a8bf-879900f07a25");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bdd6651-1336-41c2-9c05-8ddec4eac999", "AQAAAAEAACcQAAAAELPAqDzCeg0bdFpU1K9SUe8xzGj98pELcPUOatCK0WGfrJrqp/8TtRKY9vZ/upiNqw==", "16c6cc51-a87b-4a45-990c-33bda502cb4b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eac2f646-3eac-49e2-a226-88b296eaaba3", "AQAAAAEAACcQAAAAEGpEgHmzam88i0IRl+WoO/s80vOSswWKIxaYHBnHOMmgP8Hwzz1L032ImCcWpOYF6Q==", "7357e86d-090a-4708-823b-32e97ccce96d" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoryId", "isDelete", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { "05eb0ab3-9161-48d0-9a13-a78ccdb6bee4", "f2a1ade9-9078-4446-a340-91300d66f19c", false, "Zip-pockets pebbled tote", "/Client/img/trend/bs-2.jpg", "/Client/img/trend/bs-2.jpg", "", "", "Zip-pockets pebbled tote", "Zip-pockets pebbled tote", "Zip-pockets pebbled tote", "name img 3", "name img 4", 59, 5, 50000, "Zip-pockets pebbled tote", false },
                    { "09f5d2ed-19a5-4177-8b16-1c8be41182bf", "ff1d9c9b-5d13-4975-9b46-58e9a7d78a8d", false, "Cotton T-Shirt", "/Client/img/product/product-3.jpg", "", "", "", "Cotton T-Shirt", "Cotton T-Shirt", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Cotton T-Shirt", false },
                    { "1fa4e1a8-3774-4208-b50b-3b87f855cb2d", "f2a1ade9-9078-4446-a340-91300d66f19c", false, "Round leather bag", "/Client/img/trend/bs-3.jpg", "/Client/img/trend/bs-3.jpg", "", "", "Round leather bag", "Round leather bag", "Round leather bag", "name img 3", "name img 4", 59, 5, 50000, "Round leather bag", false },
                    { "327d4e09-3dd4-4a61-891c-1754c1484d2a", "45deb92a-0d6f-40f2-904c-a5ddaefc7ed6", false, "Pendant earrings", "/Client/img/trend/ht-2.jpg", "/Client/img/trend/ht-2.jpg", "", "", "Pendant earrings", "Pendant earrings", "Pendant earrings", "name img 3", "name img 4", 59, 5, 50000, "Pendant earrings", false },
                    { "542fbe49-96cb-4e0c-b5c8-304f107b36e5", "f2a1ade9-9078-4446-a340-91300d66f19c", false, "Contrasting sunglasses", "/Client/img/product/product-7.jpg", "", "", "", "Contrasting sunglasses", "Contrasting sunglasses", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Contrasting sunglasses", false },
                    { "5463ddfb-ccb9-4f44-a1ff-52615129bab1", "f2a1ade9-9078-4446-a340-91300d66f19c", false, "Cotton T-Shirt", "/Client/img/trend/bs-1.jpg", "/Client/img/trend/bs-1.jpg", "", "", "Cotton T-Shirt", "Cotton T-Shirt", "Cotton T-Shirt", "name img 3", "name img 4", 59, 5, 50000, "Cotton T-Shirt", false },
                    { "580775d8-55b8-4cfa-91ff-8531a73e172e", "ff1d9c9b-5d13-4975-9b46-58e9a7d78a8d", false, "Flap cross-body bag", "/Client/img/trend/f-3.jpg", "/Client/img/trend/f-3.jpg", "", "", "Flap cross-body bag", "Flap cross-body bag", "Flap cross-body bag", "name img 3", "name img 4", 59, 5, 50000, "Flap cross-body bag", false },
                    { "598d6b6a-13c7-427b-a279-6dc3a01bde53", "ff1d9c9b-5d13-4975-9b46-58e9a7d78a8d", false, "Slim striped pocket shirt", "/Client/img/product/product-4.jpg", "", "", "", "Slim striped pocket shirt", "Slim striped pocket shirt", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Slim striped pocket shirt", false },
                    { "64ea95a7-56f5-4f7c-b132-cbc9e4db61ba", "ff1d9c9b-5d13-4975-9b46-58e9a7d78a8d", false, "Buttons tweed blazer", "/Client/img/product/product-1.jpg", "", "", "", "Buttons tweed blazer", "Buttons tweed blazer", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Buttons tweed blazer", false },
                    { "6edc4aac-caa8-46ab-96ae-8a2e94f3e87c", "45deb92a-0d6f-40f2-904c-a5ddaefc7ed6", false, "Chain bucket bag", "/Client/img/trend/ht-1.jpg", "/Client/img/trend/ht-1.jpg", "", "", "Chain bucket bag", "Chain bucket bag", "Chain bucket bag", "name img 3", "name img 4", 59, 5, 50000, "Chain bucket bag", false },
                    { "78e51175-72be-4a82-ba29-a402b9d479bc", "45deb92a-0d6f-40f2-904c-a5ddaefc7ed6", false, "Cotton T-Shirt", "/Client/img/trend/ht-3.jpg", "/Client/img/trend/ht-3.jpg", "", "", "Cotton T-Shirt", "Cotton T-Shirt", "Cotton T-Shirt", "name img 3", "name img 4", 59, 5, 50000, "Cotton T-Shirt", false },
                    { "a9a2a7b3-4791-4a62-8317-b21b1939bb97", "ff1d9c9b-5d13-4975-9b46-58e9a7d78a8d", false, "Flowy striped skirt", "/Client/img/product/product-2.jpg", "", "", "", "Flowy striped skirt", "Flowy striped skirt", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Flowy striped skirt", false },
                    { "b32850e9-1d7c-4477-910a-7c5e2439cd64", "45deb92a-0d6f-40f2-904c-a5ddaefc7ed6", false, "Tropical Kimono", "/Client/img/product/product-6.jpg", "", "", "", "Tropical Kimono", "Tropical Kimono", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Tropical Kimono", false },
                    { "b6e1a544-0c35-497f-af12-4a21bdda4bcc", "f2a1ade9-9078-4446-a340-91300d66f19c", false, "Water resistant backpack", "/Client/img/product/product-8.jpg", "", "", "", "Water resistant backpack", "Water resistant backpack", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Water resistant backpack", false },
                    { "bdc7bdf9-1f1a-4aee-afaf-47c3398ffed0", "45deb92a-0d6f-40f2-904c-a5ddaefc7ed6", false, "Fit micro corduroy shirt", "/Client/img/product/product-5.jpg", "", "", "", "Fit micro corduroy shirt", "Fit micro corduroy shirt", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Fit micro corduroy shirt", false },
                    { "d0669fa0-3f71-40f8-a3f3-a77095dec945", "ff1d9c9b-5d13-4975-9b46-58e9a7d78a8d", false, "Metallic earrings", "/Client/img/trend/f-2.jpg", "/Client/img/trend/f-2.jpg", "", "", "Metallic earrings", "Metallic earrings", "Metallic earrings", "name img 3", "name img 4", 59, 5, 50000, "Metallic earrings", false },
                    { "ecd6a689-cd21-4e16-998e-ce1ffaa1dedb", "ff1d9c9b-5d13-4975-9b46-58e9a7d78a8d", false, "Bow wrap skirt", "/Client/img/trend/f-1.jpg", "/Client/img/trend/f-1.jpg", "", "", "Bow wrap skirt", "Bow wrap skirt", "Bow wrap skirt", "name img 3", "name img 4", 59, 5, 50000, "Bow wrap skirt", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactSystems",
                keyColumn: "Contact_Id",
                keyValue: "8f73f634-d549-4d5f-9220-e1e6416ca1b1");

            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cu_Id",
                keyValue: "9012c838-34a1-4610-bae3-8c9ea8f2e4b8");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "bc25dab8-4deb-42da-aedc-fa09f47fbe51");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "d603b22b-fa33-47e4-95c0-fe56cf64d8c8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "05eb0ab3-9161-48d0-9a13-a78ccdb6bee4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "09f5d2ed-19a5-4177-8b16-1c8be41182bf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "1fa4e1a8-3774-4208-b50b-3b87f855cb2d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "327d4e09-3dd4-4a61-891c-1754c1484d2a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "542fbe49-96cb-4e0c-b5c8-304f107b36e5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "5463ddfb-ccb9-4f44-a1ff-52615129bab1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "580775d8-55b8-4cfa-91ff-8531a73e172e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "598d6b6a-13c7-427b-a279-6dc3a01bde53");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "64ea95a7-56f5-4f7c-b132-cbc9e4db61ba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "6edc4aac-caa8-46ab-96ae-8a2e94f3e87c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "78e51175-72be-4a82-ba29-a402b9d479bc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a9a2a7b3-4791-4a62-8317-b21b1939bb97");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "b32850e9-1d7c-4477-910a-7c5e2439cd64");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "b6e1a544-0c35-497f-af12-4a21bdda4bcc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "bdc7bdf9-1f1a-4aee-afaf-47c3398ffed0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d0669fa0-3f71-40f8-a3f3-a77095dec945");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ecd6a689-cd21-4e16-998e-ce1ffaa1dedb");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "45deb92a-0d6f-40f2-904c-a5ddaefc7ed6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "f2a1ade9-9078-4446-a340-91300d66f19c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "ff1d9c9b-5d13-4975-9b46-58e9a7d78a8d");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Sex", "cg_Type" },
                values: new object[,]
                {
                    { "4fc21e03-c9d2-41e0-af5d-baae5a0d9c45", "Clothes", "", "Men", "Feature" },
                    { "c96957cb-daa8-4052-b0e1-69171a79a313", "Clothes", "", "Women", "Best saler" },
                    { "fe38339b-f83f-4fc3-a6c6-0dc821162e21", "Clothes", "", "Women", "Hot Trend" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Description", "Contact_Email", "Contact_Phone" },
                values: new object[] { "17be2bec-1a48-4fac-ac04-2ea24abc29d2", "Address", "Description", "Email", "Phone" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_Name", "cu_Phone" },
                values: new object[] { "2861e335-d944-4bfe-ad09-29474ee00106", "Description", "Email", "FirstName", "Phone" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "443dc2fd-717b-4ab2-b221-41fd2e666627", "code10", 10 },
                    { "d745c454-6d7e-4554-9a4e-3c2453dc305a", "code50", 50 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "5efaffca-7627-49ff-aec7-94701661788a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "c3091b6f-eae7-4b8e-9077-b5e372ab2de3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72dd9c5c-de73-43d0-8925-bb2d00d5f2e7", "AQAAAAEAACcQAAAAENZ3m+qPTasxEn/ABC6ZA0/ZfFhk5YIrljOFY9XJWt0Jj/ver9kWlMx+C3+ZIzdmFA==", "525285e4-3c9a-489c-a476-dc3ec8c22c0f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08f163c4-8601-405f-acc4-04c50c3b00a9", "AQAAAAEAACcQAAAAECRcECw4rhtzDTDuPIstMJyCPQOnLHnRzZqGdu1Sirw6GYEzMCHjYW9ybaIGHCw7/A==", "3f0b3b89-576c-40d5-913d-a523642dd696" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoryId", "isDelete", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { "0ece8b03-4f09-4078-9d65-b68eea66ba53", "fe38339b-f83f-4fc3-a6c6-0dc821162e21", false, "Chain bucket bag", "/Client/img/trend/ht-1.jpg", "/Client/img/trend/ht-1.jpg", "", "", "Chain bucket bag", "Chain bucket bag", "Chain bucket bag", "name img 3", "name img 4", 59, 5, 50000, "Chain bucket bag", false },
                    { "22bfaf47-824b-4d12-97dc-e3b31b9f8644", "c96957cb-daa8-4052-b0e1-69171a79a313", false, "Round leather bag", "/Client/img/trend/bs-3.jpg", "/Client/img/trend/bs-3.jpg", "", "", "Round leather bag", "Round leather bag", "Round leather bag", "name img 3", "name img 4", 59, 5, 50000, "Round leather bag", false },
                    { "26e857d8-2417-4656-b2d0-14792bdf8459", "fe38339b-f83f-4fc3-a6c6-0dc821162e21", false, "Tropical Kimono", "/Client/img/product/product-6.jpg", "", "", "", "Tropical Kimono", "Tropical Kimono", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Tropical Kimono", false },
                    { "5ba126ba-a0f1-4ca6-b538-bc7879537653", "fe38339b-f83f-4fc3-a6c6-0dc821162e21", false, "Fit micro corduroy shirt", "/Client/img/product/product-5.jpg", "", "", "", "Fit micro corduroy shirt", "Fit micro corduroy shirt", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Fit micro corduroy shirt", false },
                    { "5c27b7a7-c620-4a0f-90d7-9412b916b147", "4fc21e03-c9d2-41e0-af5d-baae5a0d9c45", false, "Buttons tweed blazer", "/Client/img/product/product-1.jpg", "", "", "", "Buttons tweed blazer", "Buttons tweed blazer", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Buttons tweed blazer", false },
                    { "5c81cf11-b912-4671-9bc5-dd8db657d725", "4fc21e03-c9d2-41e0-af5d-baae5a0d9c45", false, "Flap cross-body bag", "/Client/img/trend/f-3.jpg", "/Client/img/trend/f-3.jpg", "", "", "Flap cross-body bag", "Flap cross-body bag", "Flap cross-body bag", "name img 3", "name img 4", 59, 5, 50000, "Flap cross-body bag", false },
                    { "63ceb7d7-ac85-49f9-b5a7-d7374329380b", "c96957cb-daa8-4052-b0e1-69171a79a313", false, "Contrasting sunglasses", "/Client/img/product/product-7.jpg", "", "", "", "Contrasting sunglasses", "Contrasting sunglasses", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Contrasting sunglasses", false },
                    { "7632e09f-2375-4fa1-8cd4-8f3728ad8023", "fe38339b-f83f-4fc3-a6c6-0dc821162e21", false, "Cotton T-Shirt", "/Client/img/trend/ht-3.jpg", "/Client/img/trend/ht-3.jpg", "", "", "Cotton T-Shirt", "Cotton T-Shirt", "Cotton T-Shirt", "name img 3", "name img 4", 59, 5, 50000, "Cotton T-Shirt", false },
                    { "846df313-9cf1-4e78-87b2-e6257473d6a5", "4fc21e03-c9d2-41e0-af5d-baae5a0d9c45", false, "Slim striped pocket shirt", "/Client/img/product/product-4.jpg", "", "", "", "Slim striped pocket shirt", "Slim striped pocket shirt", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Slim striped pocket shirt", false },
                    { "870a9363-8ee6-41d1-9d5f-2751d9726528", "c96957cb-daa8-4052-b0e1-69171a79a313", false, "Water resistant backpack", "/Client/img/product/product-8.jpg", "", "", "", "Water resistant backpack", "Water resistant backpack", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Water resistant backpack", false },
                    { "8e91fa3b-0559-450e-9c39-6b6e93ef613a", "4fc21e03-c9d2-41e0-af5d-baae5a0d9c45", false, "Bow wrap skirt", "/Client/img/trend/f-1.jpg", "/Client/img/trend/f-1.jpg", "", "", "Bow wrap skirt", "Bow wrap skirt", "Bow wrap skirt", "name img 3", "name img 4", 59, 5, 50000, "Bow wrap skirt", false },
                    { "9528a0e9-dfa2-4721-9c03-b53899750b5d", "4fc21e03-c9d2-41e0-af5d-baae5a0d9c45", false, "Cotton T-Shirt", "/Client/img/product/product-3.jpg", "", "", "", "Cotton T-Shirt", "Cotton T-Shirt", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Cotton T-Shirt", false },
                    { "987b433f-f1b8-4dc8-beeb-12feb44bd9ac", "fe38339b-f83f-4fc3-a6c6-0dc821162e21", false, "Pendant earrings", "/Client/img/trend/ht-2.jpg", "/Client/img/trend/ht-2.jpg", "", "", "Pendant earrings", "Pendant earrings", "Pendant earrings", "name img 3", "name img 4", 59, 5, 50000, "Pendant earrings", false },
                    { "9b44d939-fae1-446d-b0ea-908589149a82", "c96957cb-daa8-4052-b0e1-69171a79a313", false, "Zip-pockets pebbled tote", "/Client/img/trend/bs-2.jpg", "/Client/img/trend/bs-2.jpg", "", "", "Zip-pockets pebbled tote", "Zip-pockets pebbled tote", "Zip-pockets pebbled tote", "name img 3", "name img 4", 59, 5, 50000, "Zip-pockets pebbled tote", false },
                    { "a424351c-4e04-45c8-9fdb-1dd33f377cff", "4fc21e03-c9d2-41e0-af5d-baae5a0d9c45", false, "Flowy striped skirt", "/Client/img/product/product-2.jpg", "", "", "", "Flowy striped skirt", "Flowy striped skirt", "name img 2", "name img 3", "name img 4", 59, 5, 50000, "Flowy striped skirt", false },
                    { "c0f98071-360a-467e-8563-0a04175ac59b", "4fc21e03-c9d2-41e0-af5d-baae5a0d9c45", false, "Metallic earrings", "/Client/img/trend/f-2.jpg", "/Client/img/trend/f-2.jpg", "", "", "Metallic earrings", "Metallic earrings", "Metallic earrings", "name img 3", "name img 4", 59, 5, 50000, "Metallic earrings", false },
                    { "f43b43ea-3883-4cf4-be8e-2b15f5a4510e", "c96957cb-daa8-4052-b0e1-69171a79a313", false, "Cotton T-Shirt", "/Client/img/trend/bs-1.jpg", "/Client/img/trend/bs-1.jpg", "", "", "Cotton T-Shirt", "Cotton T-Shirt", "Cotton T-Shirt", "name img 3", "name img 4", 59, 5, 50000, "Cotton T-Shirt", false }
                });
        }
    }
}
