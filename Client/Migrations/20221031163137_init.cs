using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Client.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    about_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    about_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    about_Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.about_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cg_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cg_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cg_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cg_Sale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cg_Sex = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cg_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactSystems",
                columns: table => new
                {
                    Contact_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSystems", x => x.Contact_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsers",
                columns: table => new
                {
                    cu_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cu_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cu_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cu_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cu_Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsers", x => x.cu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    couponId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    couponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    couponPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.couponId);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    deviceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    deviceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    devicePostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    devicePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.deviceId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ship_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ship_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ship_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ship_Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscribeEmail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscribeEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    bill_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    pd_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pd_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_Price = table.Column<int>(type: "int", nullable: false),
                    pd_ReducePrice = table.Column<int>(type: "int", nullable: false),
                    pd_NameImg1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_NameImg2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_NameImg3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_NameImg4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_Img1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_Img2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_Img3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_Img4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_Rate = table.Column<int>(type: "int", nullable: false),
                    pd_ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pd_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pd_Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "cg_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartsDevice",
                columns: table => new
                {
                    cartd_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cartd_DeviceId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsDevice", x => x.cartd_Id);
                    table.ForeignKey(
                        name: "FK_CartsDevice_Device_cartd_DeviceId",
                        column: x => x.cartd_DeviceId,
                        principalTable: "Device",
                        principalColumn: "deviceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_PaidTotal = table.Column<int>(type: "int", nullable: false),
                    bill_ProductIdlist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_ProductNamelist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_ProductSizelist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_ProductColorlist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_ProductPricelist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_Shipping = table.Column<int>(type: "int", nullable: false),
                    bill_Discount = table.Column<int>(type: "int", nullable: false),
                    bill_Confirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_DatetimeOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bill_PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitPickup = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivering = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivered = table.Column<bool>(type: "bit", nullable: false),
                    bill_Cancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                    table.ForeignKey(
                        name: "FK_Bills_Users_bill_UserId",
                        column: x => x.bill_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cart_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cart_Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_cart_UserID",
                        column: x => x.cart_UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCartDevices",
                columns: table => new
                {
                    picd_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    picd_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    picd_amount = table.Column<int>(type: "int", nullable: false),
                    picd_size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    picd_color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCartDevices", x => new { x.picd_CartId, x.picd_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_CartsDevice_picd_CartId",
                        column: x => x.picd_CartId,
                        principalTable: "CartsDevice",
                        principalColumn: "cartd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_Products_picd_ProductId",
                        column: x => x.picd_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    pic_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_amount = table.Column<int>(type: "int", nullable: false),
                    pic_size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pic_color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCart", x => new { x.pic_CartId, x.pic_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCart_Carts_pic_CartId",
                        column: x => x.pic_CartId,
                        principalTable: "Carts",
                        principalColumn: "cart_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCart_Products_pic_ProductId",
                        column: x => x.pic_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "about_id", "about_Description", "about_Title", "about_Url" },
                values: new object[] { 1, "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way.", "Footwear the leading eCommerce Store around the Globe", "https://www.youtube.com/watch?v=F1vcruph8JA" });

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName", "isDelete" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "5efaffca-7627-49ff-aec7-94701661788a", "Admin", "AppRole", "Admin", "admin", false },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "c3091b6f-eae7-4b8e-9077-b5e372ab2de3", "Staff", "AppRole", "Staff", "staff", false }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "ship_Id", "ship_Name", "ship_Price" },
                values: new object[] { "7CF94A7D-9239-446E-A404-086518F84652", "Ship", 5 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "bill_Address1", "bill_Address2", "bill_City", "bill_CompanyName", "bill_Country", "bill_PhoneNumber", "bill_PostalCode", "bill_State" },
                values: new object[,]
                {
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "72dd9c5c-de73-43d0-8925-bb2d00d5f2e7", "AppUser", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "admin", "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENZ3m+qPTasxEn/ABC6ZA0/ZfFhk5YIrljOFY9XJWt0Jj/ver9kWlMx+C3+ZIzdmFA==", null, false, "525285e4-3c9a-489c-a476-dc3ec8c22c0f", false, "Admin", "", "", "", "", "", "", "", "" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "08f163c4-8601-405f-acc4-04c50c3b00a9", "AppUser", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", "staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAECRcECw4rhtzDTDuPIstMJyCPQOnLHnRzZqGdu1Sirw6GYEzMCHjYW9ybaIGHCw7/A==", null, false, "3f0b3b89-576c-40d5-913d-a523642dd696", false, "Staff", "", "", "", "", "", "", "", "" }
                });

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

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_cart_UserID",
                table: "Carts",
                column: "cart_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CartsDevice_cartd_DeviceId",
                table: "CartsDevice",
                column: "cartd_DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_pic_ProductId",
                table: "ProductInCart",
                column: "pic_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCartDevices_picd_ProductId",
                table: "ProductInCartDevices",
                column: "picd_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ContactSystems");

            migrationBuilder.DropTable(
                name: "ContactUsers");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "ProductInCart");

            migrationBuilder.DropTable(
                name: "ProductInCartDevices");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "SubscribeEmail");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CartsDevice");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
