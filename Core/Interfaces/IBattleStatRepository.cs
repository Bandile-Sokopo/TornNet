using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IBattleStatRepository
{
    Task<IReadOnlyList<BattleStats>> GetBattleStats();
    Task<BattleStats> GetBattleStatsById(int id);
    bool BattleStatExists(int id);
}
