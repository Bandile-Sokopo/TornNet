using System;

namespace Core.Entities;

public class Items
{
    public int Id {get; set;}
    public required string Name {get; set;}
    public required string Description {get; set;}
    public required string Effect {get; set;}
    public required string Requirement {get; set;}
    public required string Type {get; set;}
    public required string WeaponType {get; set;}
    public decimal BuyPrice {get; set;}
    public decimal SellPrice {get; set;}
    public decimal MarketValue {get; set;}
    public int Circulation {get; set;}
    public required string Image {get; set;}
}
