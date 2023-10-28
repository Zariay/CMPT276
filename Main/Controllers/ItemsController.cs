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
        public ItemsController(){
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
            AvailableItems[0].HealthRegenerationBonus = 3.2d;
            AvailableItems[1].Name = "Test_Item_2"; 
            AvailableItems[1].HealthBonus = 14d;



            AvailableItems[2].Name = "Iron Helm"; 
            AvailableItems[2].ArmorBonus = 20;
            AvailableItems[3].Name = "Magical Ring";  
            AvailableItems[3].ManaBonus=30;
            AvailableItems[4].Name = "Light-weight Boots";  
            AvailableItems[4].MovementSpeedBonus=20;
            AvailableItems[5].Name = "Vampire Sword";  
            AvailableItems[5].LifeStealBonus=0.2;
            AvailableItems[6].Name = "Magical Shield";  
            AvailableItems[6].MagicResistanceBonus=15;
            AvailableItems[7].Name = "Healing Neckless"; 
            AvailableItems[7].HealthRegenerationBonus =1.5;
            AvailableItems[8].Name = "Metal Club"; 
            AvailableItems[8].CriticalStrikeDamageBonus = 20;
            AvailableItems[9].Name = "Scope";
            AvailableItems[9].CriticalStrikeChanceBonus =0.2;
            EquippedItems = new List<Item>();
            ChampStat= new ChampionStat();
            // FOR TESTING PURPOSES
            EquippedItems.Add(AvailableItems[0]);
            // FOR TESTING PURPOSES
            ViewBag.availableItems = AvailableItems;
            ViewBag.equippedItems = EquippedItems;
        }

        public IActionResult Index(Champion champ)
        {
            // set the new champion data to be part of the current stat calculation.
            ChampStat.ChampionData=champ;
            //setting the ViewBag
            ViewBag.availableItems = AvailableItems;
            ViewBag.equippedItems = EquippedItems;

            calculate_stats();
            return View("Index",ChampStat);
        }


        // internal function to calculate the current champion statistic breakdown
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
            int bonus_gold_generation = 0;

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
                bonus_slow_res_total += item.slow_res_bonus;
                bonus_ap_total += item.bonus_ap;
                bonus_ap_amp_total += item.bonus_ap_amp;
                bonus_MS_amp_total += item.bonus_MS_amp;
                bonus_lethality_total += item.bonus_lethality;
                bonus_magic_pen_total += item.bonus_magic_pen;
                bonus_percent_MR_pen_total += item.bonus_percent_MR_pen;
                bonus_percent_AR_pen_total += item.bonus_percent_AR_pen;
                bonus_ability_haste_total += item.bonus_ability_haste;
                bonus_gold_generation += item.bonus_gold_generation;
            }

            // Compute final stats

            // Health computation
            // HP = Base HP + Bonus HP + (Level * HP Growth)
            ChampStat.Health = base_stats.base_HP + HP_bonus_total
                               + ChampStat.Level * base_stats.HP_growth;





        }




    }
}