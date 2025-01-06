using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.config;

public class BattleStatsConfiguration : IEntityTypeConfiguration<BattleStats>
{
    public void Configure(EntityTypeBuilder<BattleStats> builder)
    {
        throw new NotImplementedException();
    }
}
