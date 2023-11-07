//ChampionRepository.cs file. Located in the Repositories folder.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiotSharp.Caching;
using RiotSharp.Endpoints.Interfaces.Static;
using RiotSharp.Endpoints.StaticDataEndpoint;
using SampleProj.Models;
using RiotSharp;
using Azure;
using Newtonsoft.Json;

namespace SampleProj.Repository
{
    public class ChampionRepository
    {
       private List<Champion> _champions;
       //private readonly RiotApi _riotApi; 

       public ChampionRepository()
       {
            _champions = new List<Champion>();

            var api = RiotApi.GetDevelopmentInstance("RGAPI-01900a91-e2e5-480f-948d-7699ac5b2722");
            var versions = api.StaticData.Versions.GetAllAsync().Result;
            var latest = versions[0];
            var champs = api.StaticData.Champions.GetAllAsync(latest).Result.Champions.Values;

            foreach( var champ in champs )
            {
                Champion c = new Champion();
                c.Name = champ.Name;
                c.ImageUrl = champ.Image.Full;
                c.Category = String.Join(", ", champ.Tags.Select(tag => tag.ToString()));

                
                if (c.ImageUrl == null)
                {
                    System.Diagnostics.Debug.WriteLine("image is null");
                }

                var s = champ.Stats;
               
                c.base_armor = s.Armor;
                c.armor_growth = s.ArmorPerLevel;
                c.base_AD = s.AttackDamage;
                c.AD_growth = s.AttackDamagePerLevel;
                c.range = s.AttackRange;
                c.base_AS = s.AttackSpeedOffset;
                c.AS_growth = s.AttackSpeedPerLevel;
                c.Crit = s.Crit;
                c.CritPerLevel = s.CritPerLevel;
                c.base_HP = s.Hp;
                c.HP_growth = s.HpPerLevel;
                c.base_HP_regen = s.HpRegen;
                c.HP_regen_growth = s.HpRegenPerLevel;
                c.base_MS = s.MoveSpeed;
                c.base_mana = s.Mp;
                c.mana_growth = s.MpPerLevel;
                c.base_mana_regen = s.MpRegen;
                c.mana_regen_growth = s.MpRegenPerLevel;
                c.SpellBlock = s.SpellBlock;
                c.SpellBlockPerLevel = s.SpellBlockPerLevel;

                _champions.Add(c);
            }



       }

        // You can add methods to retrieve champion data here
        public List<Champion> GetAllChampions()
        {
            return _champions;
        }




        public List<Champion> GetChampionsByCategory(string category)
        {
            return _champions.Where(champion => champion.Category.Contains(category)).ToList();
        }

        public List<Champion> GetChampionsByPartialName(string name)
        {
            return _champions.Where(champion => champion.Name.ToLower().Contains(name.ToLower())).ToList();
        }

    }
}
