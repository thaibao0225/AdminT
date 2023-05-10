using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Client.Configurations
{
    public class ProductsConfigurations : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(t => new { t.pd_Id });

            builder.HasOne(t => t.Categories).WithMany(ur => ur.products)
     .HasForeignKey(pc => pc.CategoryId);

        }
    }
}
