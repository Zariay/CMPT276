using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using SampleProj.Models;
using SampleProj.Repository;



namespace SampleProj.Controllers
{
    public class ItemsController : Controller
    {

        private ChampionStat ChampStat;
        //temporary list of items
        private List<Item>? AvailableItems;
        private List<Item>? EquippedItems;

        //temporary fake stat data(until either database/API is working)
        public ItemsController()
        {
            AvailableItems = new List<Item>{
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item()
            };
            AvailableItems[0].Name = "Test_Item_1";
            AvailableItems[0].HealthBonus = 50d;
            AvailableItems[0].HealthRegenerationBonus = 3.4d;
            AvailableItems[0].CriticalStrikeChanceBonus = 0.25;
            AvailableItems[0].AttackSpeedBonus = 0.20;
            AvailableItems[0].AttackRangeBonus = 75;
            AvailableItems[0].ArmorBonus = 55;
            AvailableItems[0].MagicResistanceBonus = 35;
            AvailableItems[0].LifeStealBonus = 0.12;
            AvailableItems[0].MovementSpeedBonus = 355;

            AvailableItems[1].Name = "Test_Item_2";
            AvailableItems[1].HealthBonus = 14d;
            AvailableItems[1].HealthRegenerationBonus = 1.7d;
            AvailableItems[1].MovementSpeedBonus = 100;


            AvailableItems[2].Name = "Iron Helm";
            AvailableItems[2].ArmorBonus = 20;
            AvailableItems[3].Name = "Magical Ring";
            AvailableItems[3].ManaBonus = 30;
            AvailableItems[4].Name = "Light-weight Boots";
            AvailableItems[4].MovementSpeedBonus = 20;
            AvailableItems[5].Name = "Vampire Sword";
            AvailableItems[5].LifeStealBonus = 0.2;
            AvailableItems[6].Name = "Magical Shield";
            AvailableItems[6].MagicResistanceBonus = 15;
            AvailableItems[7].Name = "Healing Neckless";
            AvailableItems[7].HealthRegenerationBonus = 1.5;
            AvailableItems[8].Name = "Metal Club";
            AvailableItems[8].CriticalStrikeDamageBonus = 20;
            AvailableItems[9].Name = "Scope";
            AvailableItems[9].CriticalStrikeChanceBonus = 0.2;
            EquippedItems = new List<Item>();
            ChampStat = new ChampionStat();
            // FOR TESTING PURPOSES
            EquippedItems.Add(AvailableItems[0]);
            EquippedItems.Add(AvailableItems[1]);
            // FOR TESTING PURPOSES
            ViewBag.availableItems = AvailableItems;
            ViewBag.equippedItems = EquippedItems;
        }

        public IActionResult Index(Champion champ)
        {   

           Champion ch = new Champion();
            ch.Name = champ.Name;
            ch.Armor = champ.Armor;
            ch.ArmorPerLevel = champ.ArmorPerLevel;
            ch.AttackDamage = champ.AttackDamage;
            ch.AttackDamagePerLevel = champ.AttackDamagePerLevel;
            ch.AttackRange = champ.AttackRange;
            ch.AttackSpeedOffset = champ.AttackSpeedOffset;
            ch.AttackSpeedPerLevel = champ.AttackSpeedPerLevel;
            ch.Crit = champ.Crit;
            ch.CritPerLevel = champ.CritPerLevel;
            ch.Hp = champ.Hp;
            ch.HpPerLevel = champ.HpPerLevel;
            ch.HpRegen = champ.HpRegen;
            ch.HpRegenPerLevel = champ.HpRegenPerLevel;
            ch.MoveSpeed = champ.MoveSpeed;
            ch.Mp = champ.Mp;
            ch.MpPerLevel = champ.MpPerLevel;
            ch.MpRegen = champ.MpRegen;
            ch.MpRegenPerLevel = champ.MpRegenPerLevel;
            ch.SpellBlock = champ.SpellBlock;
            ch.SpellBlockPerLevel = champ.SpellBlockPerLevel;


            // set the new champion data to be part of the current stat calculation.
            ChampStat.ChampionData = ch;
            //setting the ViewBag
            ViewBag.availableItems = AvailableItems;
            ViewBag.equippedItems = EquippedItems;

            //calculate_stats();
            ViewData["i"] = ch as Champion;
            return View("Index");
        }

        //commenting out calculating stats while attempting to get the api working

        // calculate_stats modifies the current ChampStat object being
        // used as the current representation of the champion statistic
        // computation. First, the stats are cleared (but, the level is kept),
        // then the bonuses from items are computed in a for loop.
        // Finally, the new computation of the current statistical representation
        // is done for each statistic.
        //
        // calculate_stats should be called when there are changes to items, or
        // changes to the champion being looked at.
        
        /*
        private void calculate_stats()
        {
            // Reset ChampStat to the base state.
            ChampStat.clear();

            // grab reference to the base stats
            Champion? base_stats = ChampStat.ChampionData;

            // stat totals, to be summed up across all items
            double HP_bonus_total = 0d;
            double HP5_bonus_total = 0d;
            double bonus_H_S_power_total = 0d;
            double bonus_mana_total = 0d;
            double bonus_mana_regen_total = 0d;
            double bonus_AD_total = 0d;
            double bonus_AS_total = 0d;
            int bonus_range_total = 0;
            double bonus_armor_total = 0d;
            double bonus_MR_total = 0d;
            double bonus_MS_total = 0d;
            double bonus_crit_chance_total = 0d;
            double bonus_crit_dmg_total = 0d;
            double bonus_lifesteal_total = 0d;
            double bonus_spellvamp_total = 0d;
            double bonus_tenacity_total = 0d;
            double bonus_omnivamp_total = 0d;
            double bonus_slow_res_total = 0d;
            double bonus_ap_total = 0d;
            double bonus_ap_amp_total = 0d;
            double bonus_MS_amp_total = 0d;
            int bonus_lethality_total = 0;
            int bonus_magic_pen_total = 0;
            double bonus_percent_MR_pen_total = 0d;
            double bonus_percent_AR_pen_total = 0d;
            double bonus_ability_haste_total = 0d;
            int bonus_gold_generation_total = 0;

            // Sum up all item bonuses
            foreach (var item in EquippedItems)
            {
                // Add each bonus stat
                HP_bonus_total += item.HealthBonus;
                HP5_bonus_total += item.HealthRegenerationBonus;
                bonus_H_S_power_total += item.bonus_heal_shield_power;
                bonus_mana_total += item.ManaBonus;
                bonus_mana_regen_total += item.ManaRegenerationBonus;
                bonus_AD_total += item.AttackDamageBonus;
                bonus_AS_total += item.AttackSpeedBonus;
                bonus_range_total += item.AttackRangeBonus;
                bonus_armor_total += item.ArmorBonus;
                bonus_MR_total += item.MagicResistanceBonus;
                bonus_MS_total += item.MovementSpeedBonus;
                bonus_crit_chance_total += item.CriticalStrikeChanceBonus;
                bonus_crit_dmg_total += item.CriticalStrikeDamageBonus;
                bonus_lifesteal_total += item.LifeStealBonus;
                bonus_spellvamp_total += item.SpellVampBonus;
                bonus_tenacity_total += item.TenacityBonus;
                bonus_omnivamp_total += item.omnivamp_bonus;
                bonus_ap_total += item.bonus_ap;
                bonus_ap_amp_total += item.bonus_ap_amp;
                bonus_MS_amp_total += item.bonus_MS_amp;
                bonus_lethality_total += item.bonus_lethality;
                bonus_magic_pen_total += item.bonus_magic_pen;
                bonus_ability_haste_total += item.bonus_ability_haste;
                bonus_gold_generation_total += item.bonus_gold_generation;

                // Multiplicative stacking is used to calculate these percentages.
                // For example, if we have 3 items with 0.1, 0.2, 0.15 percent MR pen,
                // then the total reduction will be (1-0.1)*(1-0.2)*(1-0.15) = 0.612
                // not 0.55
                // 
                // To calculate the final percent, for each item j, compute
                // current bonus = current bonus * (1 - j)
                // for all j
                //
                // then, we have the multiplier for MR after applying the percent reductions.
                // To get the percent penetration, subtract this from 1.
                bonus_percent_MR_pen_total *= (1 - item.bonus_percent_MR_pen);
                bonus_percent_AR_pen_total *= (1 - item.bonus_percent_AR_pen);
                bonus_slow_res_total *= (1 - item.slow_res_bonus);
            }


            // Compute final stats

            // Health computation
            // HP = Base HP + Bonus HP + ((Level-1) * HP Growth)
            ChampStat.Health = base_stats.base_HP + HP_bonus_total
                               + ((ChampStat.Level - 1) * base_stats.HP_growth);

            // Health regen computation
            // HP5 = Base HP5 + Bonus HP5 + ((Level-1) * HP5 growth)
            ChampStat.HealthRegeneration = base_stats.base_HP_regen + HP5_bonus_total
                                           + ((ChampStat.Level - 1) * base_stats.HP_regen_growth);

            // Heal + Shield power computation
            // Heal/Shield power is just equal to the bonus.
            ChampStat.heal_shield_power = bonus_H_S_power_total;

            // Mana computation
            // Mana = Base mana + Bonus mana + ((Level-1) * Mana growth)
            ChampStat.Mana = base_stats.base_mana + bonus_mana_total
                             + ((ChampStat.Level - 1) * base_stats.mana_growth);

            // Mana regen computation
            // Mana regen = Base mana regen + Bonus mana regen + ((Level-1) * Mana regen growth)
            ChampStat.ManaRegeneration = base_stats.base_mana_regen + bonus_mana_regen_total
                                         + ((ChampStat.Level - 1) * base_stats.mana_regen_growth);

            // AD computation
            // AD = Base AD + Bonus AD + ((Level-1) * AD Growth)
            ChampStat.AttackDamage = base_stats.base_AD + bonus_AD_total
                                     + ((ChampStat.Level - 1) * base_stats.AD_growth);

            // AS computation
            // Attack speed is calculated using a ratio, which is specific to the champion.
            // AS = AS Ratio * ((base AS / AS Ratio) + bonus AS + ((Level-1) * AS Growth))
            // where bonus AS, base AS, and AS ratio are expressed as decimal percentages.
            //
            // Bonus AS here is from the items, but in the canonical calculation is also
            // from growth, which is why this formula may look different
            ChampStat.AttackSpeed = ((base_stats.base_AS / base_stats.AS_ratio) + bonus_AS_total
                                    + ((ChampStat.Level - 1) * base_stats.AS_growth))
                                    * base_stats.AS_ratio;

            // Range computation
            // Range = Base range + bonus range
            ChampStat.AttackRange = base_stats.range + bonus_range_total;

            // Armor computation
            // Armor = base armor + bonus armor + ((Level-1) * armor growth)
            ChampStat.Armor = base_stats.base_armor + bonus_armor_total
                              + ((ChampStat.Level - 1) * base_stats.armor_growth);

            // MR Computation
            // MR = base MR + bonus MR + ((Level-1) * MR growth)
            ChampStat.MagicResistance = base_stats.base_MR + bonus_MR_total
                                        + ((ChampStat.Level - 1) * base_stats.MR_growth);

            // MS Computation
            // Movement speed is calculated first as a raw speed, then reduced by a 
            // ratio based on the magnitude of the raw value.
            //
            // Thankfully, multiplicative movement speed boosts are rare and usually on
            // stuff like ghost, or item actives like Mercurial scimitar.
            // These are ignored for these calculations as they are out of scope of the project.

            // Calculate MS_raw = (Base MS + Bonus MS)*(1+Bonus MS Amp)
            double MS_raw = (base_stats.base_MS + bonus_MS_total) * (1 + bonus_MS_amp_total);

            // Calculate movement speed after scaling
            if (MS_raw <= 415)
            {
                // There is no scaling if MS_raw is less than 415
                ChampStat.MovementSpeed = MS_raw;
            }
            else if (415 < MS_raw && MS_raw <= 490)
            {
                // Scale the portion above 415 by 0.8
                ChampStat.MovementSpeed = ((MS_raw - 415) * 0.8) + 415;

            }
            else if (490 < MS_raw)
            {
                // Scale the portion above 490 by 0.5
                // Scale the portion above 415 till 490 by 0.8
                ChampStat.MovementSpeed = ((MS_raw - 490) * 0.5) + ((490 - 415) * 0.8) + 415;

            }
            // Error! If you see MS = -1 something has gone wrong!
            else
            {
                ChampStat.MovementSpeed = -1;
            }

            // Crit chance computation
            // Crit chance is only based on the items equipt
            ChampStat.CriticalStrikeChance = bonus_crit_chance_total;

            // Crit damage computation
            // Crit damage starts at a base of 1.75 and is only increased by items (infinity edge)
            ChampStat.CriticalStrikeDamage = 1.75 + bonus_crit_dmg_total;

            // Lifesteal computation
            // Lifesteal is only based on the items equipt (since we do not consider runes, abilities)
            ChampStat.LifeSteal = bonus_lifesteal_total;

            // Spellvamp computation
            // Spellvamp is only based on items
            ChampStat.SpellVamp = bonus_spellvamp_total;

            // Omnivamp computation
            // Omnivamp is only based on items
            ChampStat.Omnivamp = bonus_omnivamp_total;

            // Tenacity computation
            // While the tenacity computation is normally complicated, our case
            // is simplified as only merc treads has tenacity as a stat, the rest
            // are from item actives, abilities, or consumables which are not
            // to be considered.
            //
            // Therefore, set the tenacity based on the sum of it's bonus total,
            // since there is only one possible item that increases this anyways.

            ChampStat.Tenacity = bonus_tenacity_total;

            // Slow resist computation
            // We now subtract by 1 to undo our above multiplications by (1-j)

            ChampStat.slow_resist = (1 - bonus_slow_res_total);

            // Energy computation
            // Energy is not influenced by any items

            ChampStat.energy = base_stats.base_energy;

            // Energy regen computation
            // Energy regen is only affected by abilities, a rune, and blue buff.

            ChampStat.energy_regen = base_stats.base_energy_regen;

            // Ability haste computation
            // Haste only really stacks off item stats, and is additive.
            // 
            // In the future if wanted we can display the CDR provided, which is
            // (Haste/(Haste + 100) * 100).
            // This could be done outside of this function however.

            ChampStat.ability_haste = bonus_ability_haste_total;

            // AP computation
            // AP has no base stats, however, deathcap multiplies this number.
            // Actually, so does demonic embrace, however implementing this would
            // make things messy as the value would need to be stored different to
            // the deathcap amp, and would require using an if statement to
            // check through the item being presented to see if it is demonic before
            // altering computation.
            //
            // To keep things simple, we can just ignore the item passive there as it is
            // not important for the scope of the project. Deathcap is much more meaningful.

            ChampStat.ability_power = bonus_ap_total * (1 + bonus_ap_amp_total);

            // magic penetration computation
            // magic penetration is just additive from items (and runes, which we dont include)

            ChampStat.magic_pen = bonus_magic_pen_total;

            // percent magic pen computation
            // Compute (1-total) as defined in the for loop above.
            ChampStat.percent_MR_pen = (1 - bonus_percent_MR_pen_total);

            // armor penetration computation
            // This is calculated directly from lethality, but is not 1 to 1
            // Armor pen = lethality * (0.6 + 0.4 * level/18)
            ChampStat.armor_penetration = (bonus_lethality_total) * (0.6 + (0.4 * ChampStat.Level) / 18);

            // percent armor pen computation
            // This is also computed multiplicatively, details are above in the for loop.
            ChampStat.percent_AR_pen = (1 - bonus_percent_AR_pen_total);

            // Gold generation computation
            // This is additive, and simple enough.
            ChampStat.gold_generation = base_stats.base_gold_generation + bonus_gold_generation_total;



        }
        */



    }
}