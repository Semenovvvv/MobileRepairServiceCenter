﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileRepair.Data.Models;

namespace MobileRepair.Data.Configurations
{
    public class OrderServiceConfiguration : IEntityTypeConfiguration<OrderService>
    {
        public void Configure(EntityTypeBuilder<OrderService> builder)
        {
            builder.HasKey(x => new { x.ServiceId, x.OrderId });

            builder.HasOne(x => x.Order)
                .WithMany()
                .HasForeignKey(x => x.OrderId);

            builder.HasOne(x => x.Service)
                .WithMany()
                .HasForeignKey(x => x.ServiceId);
        }
    }
}