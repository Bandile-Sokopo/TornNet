using System;
using Api.Controllers;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class BenefitController(IBenefitRepository repo) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Benefit>>> GetProduct()
    {
        return Ok(await repo.GetBenfit());
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Benefit>> GetBenefitById(int id)
    {
        var benefit = await repo.GetBenefitById(id);
        if(benefit == null) return NotFound();

        return benefit;
    }
}
