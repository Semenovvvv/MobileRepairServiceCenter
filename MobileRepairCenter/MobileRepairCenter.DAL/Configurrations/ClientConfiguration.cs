using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileRepairCenter.Domain.Models;

namespace MobileRepairCenter.DAL.Configurrations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
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
