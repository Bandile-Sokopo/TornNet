using System;

namespace Core.Entities;

public class Stocks
{
    public int StockId;
    public string Name;
    public string Acronym;
    public decimal CurrentPrice;
    public int MarketCap;
    public int TotalShares;
    public int Investors;
    public Benefit Benefit;
}
