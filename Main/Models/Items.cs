using System;

namespace SampleProj.Models
{
        public class Item
    {
        public string? Name { get; set; }
        public int HealthBonus { get; set; }                //HP
        public double HealthRegenerationBonus { get; set; }     // HP5
        public int ManaBonus { get; set; }                      // MP
        public double ManaRegenerationBonus { get; set; }       // MP5
        public int AttackDamageBonus { get; set; }              // AD
        public double AttackSpeedBonus { get; set; }            // AS (attacks per second)
        public int AttackRangeBonus { get; set; }               // AR
        public int ArmorBonus { get; set; }                     // AR
        public int MagicResistanceBonus { get; set; }           // MR
        public int MovementSpeedBonus { get; set; }             // MS
        public double CriticalStrikeChanceBonus { get; set; }   // Crit
        public double CriticalStrikeDamageBonus { get; set; }  // CritDmg
        public double LifeStealBonus { get; set; }              // LS
        public double SpellVampBonus { get; set; }              // SV
        public double TenacityBonus { get; set; }              // Tenacity
        public int EnergyBonus { get; set; }                   // Energy

        public Item(){
            Name="";
            HealthBonus=0;
            HealthRegenerationBonus=0;
            ManaBonus=0;
            ManaRegenerationBonus=0;
            AttackDamageBonus=0;
            AttackSpeedBonus=0;
            AttackRangeBonus=0;
            ArmorBonus=0;
            MagicResistanceBonus=0;
            MovementSpeedBonus=0;
            CriticalStrikeChanceBonus=0;
            CriticalStrikeDamageBonus=0;
            LifeStealBonus=0;
            SpellVampBonus=0;
            TenacityBonus=0;
            EnergyBonus=0;
        }
    }

    public class ChampionStat
    {
        //Until either the database or API get up and running, this will just be temporary to see how things look
        public Champion? ChampionData {get;set;}                 // The Champion
        public int Health { get; set; }                    // HP
        public double HealthRegeneration { get; set; }     // HP5
        public int Mana { get; set; }                      // MP
        public double ManaRegeneration { get; set; }       // MP5
        public int AttackDamage { get; set; }              // AD
        public double AttackSpeed { get; set; }            // AS (attacks per second)
        public int AttackRange { get; set; }               // AR
        public int Armor { get; set; }                     // AR
        public int MagicResistance { get; set; }           // MR
        public int MovementSpeed { get; set; }             // MS
        public double CriticalStrikeChance { get; set; }   // Crit
        public double CriticalStrikeDamage { get; set; }  // CritDmg
        public double LifeSteal { get; set; }              // LS
        public double SpellVamp { get; set; }              // SV
        public double Tenacity { get; set; }              // Tenacity
        public int Energy { get; set; }                   // Energy
        public ChampionStat(){
            ChampionData= new Champion();
            Health = 550;
            HealthRegeneration = 8.0;
            Mana = 350;
            ManaRegeneration = 6.0;
            AttackDamage = 60;
            AttackSpeed = 0.7;
            AttackRange = 175;
            Armor = 30;
            MagicResistance = 30;
            MovementSpeed = 345;
            CriticalStrikeChance = 0.25;
            CriticalStrikeDamage = 200;
            LifeSteal = 0.1;
            SpellVamp = 0.1;
            Tenacity = 0.2;
            Energy = 200;
        }
    }


}