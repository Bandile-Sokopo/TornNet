using System;
using Api.Controllers;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class ItemsController(IItemRepository repo) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Items>>> GetItems()
    {
        return Ok(await repo.GetItems());
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Items>> GetItemsById(int id)
    {
        var item = await repo.GetItemById(id);
        if(item == null) return NotFound();

        return item;
    }
}
