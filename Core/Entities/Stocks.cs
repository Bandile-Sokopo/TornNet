using System;

namespace Core.Entities;

public class Stocks
{
    public int Id {get; set;}
    public int StockId {get; set;}
    public required string Name {get; set;}
    public required string Acronym {get; set;}
    public decimal CurrentPrice {get; set;}
    public int MarketCap {get; set;}
    public int TotalShares {get; set;}
    public int Investors {get; set;}
    public required Benefit Benefit {get; set;}
}
