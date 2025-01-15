using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileRepair.Data.Models;

namespace MobileRepair.Data.Configurations
{
    public class OrderHistoryConfiguration : IEntityTypeConfiguration<OrderHistory>
    {
        public void Configure(EntityTypeBuilder<OrderHistory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Order)
                .WithMany()
                .HasForeignKey(x => x.OrderId);

            builder.HasOne(x => x.EditUser)
                .WithMany()
                .HasForeignKey(x => x.EditUserId);

            builder.Property(x => x.EditDate).HasColumnType("timestamp");
        }
    }
}
