using System;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class BattleStatRepository(DataContext context) : IBattleStatRepository
{

    public bool BattleStatExists(int id)
    {
        return context.BattleStats.Any(x => x.Id == id);
    }

    public async Task<IReadOnlyList<BattleStats>> GetBattleStats()
    {
        return await context.BattleStats.ToListAsync();
    }

    public async Task<BattleStats?> GetBattleStatsById(int id)
    {
        return await context.BattleStats.FindAsync(id);
    }
}
