using System;
using API.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class StockRepository(DataContext context) : IStockRepository
{
    public async Task<Stocks?> GetStockById(int id)
    {
        return await context.Stocks.FindAsync(id);
    }

    public async Task<IReadOnlyList<Stocks>> GetStocks()
    {
        return await context.Stocks.ToListAsync();
    }

    public bool StockExists(int id)
    {
        return context.Stocks.Any(x => x.Id == id);
    }
}
