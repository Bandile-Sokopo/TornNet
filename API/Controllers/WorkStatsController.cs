using System;
using Api.Controllers;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class WorkStatsController(IWorkStatRepository repo) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<WorkStats>>> GetWorkStats()
    {
        return Ok(await repo.GetWorkStats());
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<WorkStats>> GetWorkStatsById(int id)
    {
        var stat = await repo.GetWorkStatById(id);
        if(stat == null) return NotFound();

        return stat;
    }
}
