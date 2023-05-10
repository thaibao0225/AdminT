using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Client.Configurations
{
    public class BillConfigurations : IEntityTypeConfiguration<Bills>
    {

        public void Configure(EntityTypeBuilder<Bills> builder)
        {
            builder.ToTable("Bills");
            builder.HasKey(t => new { t.bill_Id });
            builder.HasOne(t => t.AppUserB).WithMany(ur => ur.BillsAU)
     .HasForeignKey(pc => pc.bill_UserId);



        }
    }
}
