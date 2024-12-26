using System;

namespace Core.Entities;

public class Items
{
    public required string Name;
    public required string Description;
    public required string Effect;
    public required string Requirement;
    public required string Type;
    public required string WeaponType;
    public decimal BuyPrice;
    public decimal SellPrice;
    public decimal MarketValue;
    public int Circulation;
    public required string Image;
}
