using Microsoft.Identity.Client;
using System;
using System.Security.Permissions;

namespace SampleProj.Models
{
        public class Item
    {
        public string? Name { get; set; }
        public double HealthBonus { get; set; }                //HP
        public double HealthRegenerationBonus { get; set; }     // HP5
        public double bonus_heal_shield_power { get; set; }      // for support items
        public double ManaBonus { get; set; }                      // MP
        public double ManaRegenerationBonus { get; set; }       // MP5
        public double AttackDamageBonus { get; set; }              // AD
        public double AttackSpeedBonus { get; set; }            // AS (attacks per second)
        public int AttackRangeBonus { get; set; }               // rang
        public double ArmorBonus { get; set; }                     // AR
        public double MagicResistanceBonus { get; set; }           // MR
        public double MovementSpeedBonus { get; set; }             // MS
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
        public int bonus_lethality { get; set; }                // used to calculate flat AR pen
        public int bonus_magic_pen { get; set; }
        public double bonus_percent_MR_pen { get; set; }
        public double bonus_percent_AR_pen { get; set; }
        public double bonus_ability_haste { get; set; }
        public int bonus_gold_generation {  get; set; }

    public Item(){
            Name="";
            HealthBonus=0d;
            HealthRegenerationBonus=0d;
            bonus_heal_shield_power = 0d;
            ManaBonus =0d;
            ManaRegenerationBonus=0d;
            AttackDamageBonus=0d;
            AttackSpeedBonus=0d;
            AttackRangeBonus=0;
            ArmorBonus=0d;
            MagicResistanceBonus=0d;
            MovementSpeedBonus=0d;
            CriticalStrikeChanceBonus=0d;
            CriticalStrikeDamageBonus=0d;
            LifeStealBonus=0d;
            SpellVampBonus=0d;
            TenacityBonus=0d;
            omnivamp_bonus = 0d;
            slow_res_bonus = 0d;
            bonus_ap = 0d;
            bonus_ap_amp = 0d;
            bonus_MS_amp = 0d;
            bonus_lethality = 0;
            bonus_magic_pen = 0;
            bonus_percent_MR_pen = 0d;
            bonus_percent_AR_pen = 0d;
            bonus_ability_haste = 0d;
            bonus_gold_generation = 0;
        }
    }

    // the current representation of the stat calculation
    //
    // take the base data from ChampionData, and the item
    // information, then calculate the final values for
    // Health,HealthRegeneration,..., in ChampionStat
    public class ChampionStat
    {
        public Champion? ChampionData { get; set; }                 // The Champion
        public int Level { get; set; }                        // Current level
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
        public int magic_pen {  get; set; }            // AP lethality
        public double percent_MR_pen {  get; set; }       // MR pen %
        public double armor_penetration {  get; set; }     // lethality
        public double percent_AR_pen { get; set; }        // armor pen %
        public int gold_generation { get; set; }          // gold gained per second

        // At some point, we might want to have a function defined
        //
        // public ChampionStat(Champion this_champion)...
        //
        // which sets ChampionData to this_champion
        //
        // this could be useful in the future when something needs changing so I will
        // leave this note here.

        public ChampionStat(){
            ChampionData= new Champion();
            Level = 1;
            Health = 0d;
            heal_shield_power = 0d;
            HealthRegeneration = 0d;
            Mana = 0d;
            ManaRegeneration = 0d;
            AttackDamage = 0d;
            AttackSpeed = 0d;
            AttackRange = 0;
            Armor = 0d;
            MagicResistance = 0d;
            MovementSpeed = 0d;
            CriticalStrikeChance = 0d;
            CriticalStrikeDamage = 0d;
            LifeSteal = 0d;
            SpellVamp = 0d;
            Omnivamp = 0d;
            Tenacity = 0d;
            slow_resist = 0d;
            energy = 0d;
            energy_regen = 0d;
            ability_haste = 0d;
            ability_power = 0d;
            magic_pen = 0;
            percent_MR_pen = 0d;
            armor_penetration = 0d;
            percent_AR_pen = 0d;
            gold_generation = 0;
        }

        // clear all values but retain champion data
        public void clear()
        {
            Health = 0d;
            heal_shield_power = 0d;
            HealthRegeneration = 0d;
            Mana = 0d;
            ManaRegeneration = 0d;
            AttackDamage = 0d;
            AttackSpeed = 0d;
            AttackRange = 0;
            Armor = 0d;
            MagicResistance = 0d;
            MovementSpeed = 0d;
            CriticalStrikeChance = 0d;
            CriticalStrikeDamage = 0d;
            LifeSteal = 0d;
            SpellVamp = 0d;
            Omnivamp = 0d;
            Tenacity = 0d;
            slow_resist = 0d;
            energy = 0d;
            energy_regen = 0d;
            ability_haste = 0d;
            ability_power = 0d;
            magic_pen = 0;
            percent_MR_pen = 0d;
            armor_penetration = 0d;
            percent_AR_pen = 0d;
            gold_generation = 0;
        }

    }


}