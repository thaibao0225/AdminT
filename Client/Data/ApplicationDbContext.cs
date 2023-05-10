using Client.Configurations;
using Client.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Client.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
            builder
                .AddConsole();
        });

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }



            builder.ApplyConfiguration(new AboutConfigurations());
            builder.ApplyConfiguration(new AppRoleConfigurations());
            builder.ApplyConfiguration(new AppUserConfigurations());
            builder.ApplyConfiguration(new BillConfigurations());
            builder.ApplyConfiguration(new CartConfigurations());
            builder.ApplyConfiguration(new CategoriesConfigurations());
            builder.ApplyConfiguration(new ContactSystemConfigurations());
            builder.ApplyConfiguration(new ContactUsersConfigurations());
            builder.ApplyConfiguration(new ProductInCartConfigurations());
            //builder.ApplyConfiguration(new ProductInCategoriesConfigurations());
            builder.ApplyConfiguration(new ProductsConfigurations());
            //builder.ApplyConfiguration(new ReviewsConfigurations());
            //builder.ApplyConfiguration(new ReviewInproductConfigurations());
            builder.ApplyConfiguration(new CouponsConfigurations());
            builder.ApplyConfiguration(new DeviceConfigurations());
            builder.ApplyConfiguration(new DeviceConfigurations());
            builder.ApplyConfiguration(new CartsDeviceConfigurations());
            builder.ApplyConfiguration(new ProductInCartDevicesConfigurations());
            builder.ApplyConfiguration(new ShippingConfigurations());
            //builder.ApplyConfiguration(new SubReviewInReviewConfigurations());
            ///builder.ApplyConfiguration(new SubReviewConfigurations());
            //builder.ApplyConfiguration(new SubscribeOurNewsletterConfigurations());

            builder.Seed();
        }
        public DbSet<About> About { set; get; }
        public DbSet<AppRole> AppRole { set; get; }
        public DbSet<AppUser> AppUser { set; get; }
        public DbSet<Bills> Bills { set; get; }
        public DbSet<Categories> Categories { set; get; }
        public DbSet<ContactSystem> ContactSystem { set; get; }
        public DbSet<ContactUsers> ContactUsers { set; get; }
        public DbSet<Products> Products { set; get; }
        //public DbSet<Reviews> Reviews { set; get; }
        //public DbSet<ReviewInproduct> ReviewInproduct { set; get; }
        public DbSet<ProductInCart> ProductInCart { set; get; }
        //public DbSet<ProductsInCategories> ProductsInCategories { set; get; }
        public DbSet<Cart> Cart { set; get; }
        public DbSet<Coupons> Coupons { set; get; }
        public DbSet<Device> Devices { set; get; }
        public DbSet<CartsDevice> CartsDevice { set; get; }
        public DbSet<ProductInCartDevices> ProductInCartDevices { set; get; }
        public DbSet<Shipping> Shipping { set; get; }
        //public DbSet<SubReview> SubReview { set; get; }
        //public DbSet<SubReviewInReview> SubReviewInReview { set; get; }
        public DbSet<SubscribeEmail> SubscribeEmail { set; get; }
    }
}