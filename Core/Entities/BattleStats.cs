using System;

namespace Core.Entities;

public class BattleStats
{
    public float Strength;
    public float Speed;
    public float Dexterity;
    public float Defense;
    public float Total;
    public int StrengthModifier;
    public int DefenseModifier;
    public int SpeedModifier;
    public int DexterityModifier;
    public required string[] StrengthInfo;
    public required string[] DefenseInfo;
    public required string[] SpeedInfo;
    public required string[] DexterityInfo;
}
