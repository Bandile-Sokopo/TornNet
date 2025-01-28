using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IStockRepository
{
    Task<IReadOnlyList<Stocks>> GetStocks();
    Task<Stocks> GetStockById(int id);
    bool StockExists(int id);
}
