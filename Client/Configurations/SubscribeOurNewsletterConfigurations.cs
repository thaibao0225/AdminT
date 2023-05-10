using Client.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Client.Configurations
{
    public class SubscribeOurNewsletterConfigurations : IEntityTypeConfiguration<SubscribeEmail>
    {
        public void Configure(EntityTypeBuilder<SubscribeEmail> builder)
        {
            builder.ToTable("SubscribeEmail");
            builder.HasKey(t => new { t.Id });
        }
    }
}
