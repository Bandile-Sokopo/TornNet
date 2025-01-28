using System;
using Api.Controllers;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class BattleStatsController(IBattleStatRepository repo): BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BattleStats>>> GetBattleStats()
    {
        return Ok(await repo.GetBattleStats());
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BattleStats>> GetBattleStatsById(int id)
    {
        var stat = await repo.GetBattleStatsById(id);
        if(stat == null) return NotFound();

        return stat;
    }
}
