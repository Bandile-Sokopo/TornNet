using System;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class BenefitRepository(DataContext context) : IBenefitRepository
{
    public bool BenefitExists(int id)
    {
        return context.Benefit.Any(x => x.Id == id);
    }

    public async Task<Benefit?> GetBenefitById(int id)
    {
        return await context.Benefit.FindAsync(id);
    }

    public async Task<IReadOnlyList<Benefit>> GetBenfit()
    {
        return await context.Benefit.ToListAsync();
    }
}
