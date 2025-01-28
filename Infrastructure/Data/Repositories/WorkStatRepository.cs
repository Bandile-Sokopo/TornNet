using System;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class WorkStatRepository(DataContext context) : IWorkStatRepository
{
    public async Task<WorkStats?> GetWorkStatById(int id)
    {
        return await context.WorkStats.FindAsync(id);
    }

    public async Task<IReadOnlyList<WorkStats>> GetWorkStats()
    {
        return await context.WorkStats.ToListAsync();
    }

    public bool WorkStatExists(int id)
    {
        return context.WorkStats.Any(x => x.Id == id);
    }
}
