using System;

namespace Core.Entities;

public class Stocks
{
    public int StockId;
    public required string Name;
    public required string Acronym;
    public decimal CurrentPrice;
    public int MarketCap;
    public int TotalShares;
    public int Investors;
    public required Benefit Benefit;
}
