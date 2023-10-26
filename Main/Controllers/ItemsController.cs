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
            AvailableItems[0].Name = "Health Potion";
            AvailableItems[0].HealthBonus = 50;
            AvailableItems[1].Name = "Sword"; 
            AvailableItems[1].AttackDamageBonus = 10;
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
            ViewBag.availableItems = AvailableItems;
            ViewBag.equippedItems = EquippedItems;
        }

        public IActionResult Index(Champion champ)
        {
            ChampStat.ChampionData=champ;
            //setting the ViewBag
            ViewBag.availableItems = AvailableItems;
            ViewBag.equippedItems = EquippedItems; 
            return View("Index",ChampStat);
        }
    }
}