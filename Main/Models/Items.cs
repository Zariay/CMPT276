using Microsoft.Identity.Client;
using System;
using System.Security.Permissions;

namespace SampleProj.Models
{
        public class Item
    {
        public string? Name { get; set; }
        public int HealthBonus { get; set; }                //HP
        public double HealthRegenerationBonus { get; set; }     // HP5
        public double bonus_heal_shield_power { get; set; }      // for support items
        public int ManaBonus { get; set; }                      // MP
        public double ManaRegenerationBonus { get; set; }       // MP5
        public int AttackDamageBonus { get; set; }              // AD
        public double AttackSpeedBonus { get; set; }            // AS (attacks per second)
        public int AttackRangeBonus { get; set; }               // rang
        public int ArmorBonus { get; set; }                     // AR
        public int MagicResistanceBonus { get; set; }           // MR
        public int MovementSpeedBonus { get; set; }             // MS
        public double CriticalStrikeChanceBonus { get; set; }   // Crit
        public double CriticalStrikeDamageBonus { get; set; }  // CritDmg
        public double LifeStealBonus { get; set; }              // LS
        public double SpellVampBonus { get; set; }              // SV
        public double TenacityBonus { get; set; }              // Tenacity
        public double omnivamp_bonus { get; set; }
        public double slow_res_bonus { get; set; }
        public double bonus_ap { get; set; }                    // ability power
        public double bonus_ap_amp { get; set; }                // AP amp, so, deathcap
        public double bonus_MS_amp { get; set; }                // amp to movement speed
        public double bonus_lethality { get; set; }
        public double bonus_magic_pen { get; set; }
        public double bonus_percent_MR_pen { get; set; }
        public double bonus_percent_AR_pen { get; set; }
        public double bonus_ability_haste { get; set; }

    public Item(){
            Name="";
            HealthBonus=0;
            HealthRegenerationBonus=0;
            bonus_heal_shield_power = 0;
            ManaBonus =0;
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
            omnivamp_bonus = 0;
            slow_res_bonus = 0;
            bonus_ap = 0;
            bonus_ap_amp = 0;
            bonus_MS_amp = 0;
            bonus_lethality = 0;
            bonus_magic_pen = 0;
            bonus_percent_MR_pen = 0;
            bonus_percent_AR_pen = 0;
            bonus_ability_haste = 0;
        }
    }

    // the current representation of the stat calculation
    //
    // take the base data from ChampionData, and the item
    // information, then calculate the final values for
    // Health,HealthRegeneration,..., in ChampionStat
    public class ChampionStat
    {
        //Until either the database or API get up and running, this will just be temporary to see how things look
        public Champion? ChampionData { get; set; }                 // The Champion
        public double Health { get; set; }                    // HP
        public double HealthRegeneration { get; set; }     // HP5
        public double heal_shield_power { get; set; }      // for support items
        public double Mana { get; set; }                      // MP
        public double ManaRegeneration { get; set; }       // MP5
        public double AttackDamage { get; set; }              // AD
        public double AttackSpeed { get; set; }            // AS (attacks per second)
        public int AttackRange { get; set; }               // AR
        public double Armor { get; set; }                     // AR
        public double MagicResistance { get; set; }           // MR
        public double MovementSpeed { get; set; }             // MS
        public double CriticalStrikeChance { get; set; }   // Crit
        public double CriticalStrikeDamage { get; set; }  // CritDmg
        public double LifeSteal { get; set; }              // LS
        public double SpellVamp { get; set; }              // SV
        public double Omnivamp {  get; set; }               // omnivamp
        public double Tenacity { get; set; }              // Tenacity
        public double slow_resist {  get; set; }          // slow resist
        public double energy { get; set; }                // Energy
        public double energy_regen {  get; set; }
        public double ability_haste {  get; set; }        // CDR/Ability Haste
        public double ability_power { get; set; }         // AP
        public double magic_pen {  get; set; }            // AP lethality
        public double percent_MR_pen {  get; set; }       // MR pen %
        public double lethality {  get; set; }            // lethality
        public double percent_AR_pen { get; set; }        // armor pen %
        public int gold_generation { get; set; }          // gold gained per second


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
            LifeSteal = 0d;
            SpellVamp = 0d;
            Tenacity = 0d;
            energy = 200;
        }

        public void calculate_stats() 
        {
            // Call calculation for HP

            // Call calculation for HP regen

            // Call calculation for mana

            // Call calculation for mana regen

            // Call calculation for energy/resource

            // Call calculation for energy/resource regen

            // Call calculation for AD

            // Call calculation for AS

            // Call calculation for AP

            // Call calculation for Cooldown reduction

            // Call calculation for Armor

            // Call calculation for MR




        }
    }


}