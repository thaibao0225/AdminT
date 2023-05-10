using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Client.Configurations
{
    public class ContactSystemConfigurations : IEntityTypeConfiguration<ContactSystem>
    {
        public void Configure(EntityTypeBuilder<ContactSystem> builder)
        {
            builder.ToTable("ContactSystems");
            builder.HasKey(t => new { t.Contact_Id });
        }
    }
}
