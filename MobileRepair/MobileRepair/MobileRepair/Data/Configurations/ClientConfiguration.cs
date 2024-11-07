using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileRepair.Data.Models;

namespace MobileRepair.Data.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<ClientUser>
    {
        public void Configure(EntityTypeBuilder<ClientUser> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Surname)
                .HasMaxLength(50);

            builder.Property(x => x.Name)
               .HasMaxLength(50);

            builder.Property(x => x.Patronymic)
               .HasMaxLength(50);

            builder.Property(x => x.Email)
               .HasMaxLength(50);

            builder.Property(x => x.Phone)
               .HasMaxLength(20);

            builder.Property(x => x.Surname)
               .HasMaxLength(200);
        }
    }
}
