using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileRepairCenter.Domain.Models;

namespace MobileRepairCenter.DAL.Configurrations
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(d => d.Client)
                .WithMany()
                .HasForeignKey(d => d.ClientId);

            builder.Property(x => x.IMEI)
                .HasMaxLength(50);
        }
    }
}
