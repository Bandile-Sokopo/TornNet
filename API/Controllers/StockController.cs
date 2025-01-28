using System;
using Api.Controllers;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class StockController(IStockRepository repo) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Stocks>>> GetStock()
    {
        return Ok(await repo.GetStocks());
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Stocks>> GetStockById(int id)
    {
        var stock = await repo.GetStockById(id);
        if(stock == null) return NotFound();

        return stock;

    }
}
