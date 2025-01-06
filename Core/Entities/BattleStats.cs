using System;

namespace Core.Entities;

public class BattleStats
{
    public int Id {get; set;}
    public float Strength {get; set;}
    public float Speed {get; set;}
    public float Dexterity {get; set;}
    public float Defense {get; set;}
    public float Total {get; set;}
    public int StrengthModifier {get; set;}
    public int DefenseModifier {get; set;}
    public int SpeedModifier {get; set;}
    public int DexterityModifier {get; set;}
    public required string[] StrengthInfo {get; set;}
    public required string[] DefenseInfo {get; set;}
    public required string[] SpeedInfo {get; set;}
    public required string[] DexterityInfo {get; set;}
}
