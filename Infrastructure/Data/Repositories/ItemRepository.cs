using System;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class ItemRepository(DataContext context) : IItemRepository
{
    public async Task<Items?> GetItemById(int id)
    {
        return await context.Items.FindAsync(id);
    }

    public async Task<IReadOnlyList<Items>> GetItems()
    {
        return await context.Items.ToListAsync();
    }

    public bool ItemExists(int id)
    {
        return context.Items.Any(x => x.Id == id);
    }
}
