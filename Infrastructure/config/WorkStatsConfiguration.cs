using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.config;

public class WorkStatsConfiguration : IEntityTypeConfiguration<WorkStats>
{
    public void Configure(EntityTypeBuilder<WorkStats> builder)
    {
        throw new NotImplementedException();
    }
}
