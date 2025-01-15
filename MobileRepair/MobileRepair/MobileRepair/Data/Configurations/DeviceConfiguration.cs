using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileRepair.Data.Models;

namespace MobileRepair.Data.Configurations
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Client)
                .WithMany()
                .HasForeignKey(x => x.ClientId);

            builder.Property(x => x.DateBy).HasColumnType("timestamp");
        }
    }
}
