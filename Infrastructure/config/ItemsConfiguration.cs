using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.config;

public class ItemsConfiguration : IEntityTypeConfiguration<Items>
{
    public void Configure(EntityTypeBuilder<Items> builder)
    {
        builder.Property(x => x.BuyPrice).HasColumnType("decimal(18,2)");
        builder.Property(x => x.SellPrice).HasColumnType("decimal(18,2)");
        builder.Property(x => x.MarketValue).HasColumnType("decimal(18,2)");
    }
}
