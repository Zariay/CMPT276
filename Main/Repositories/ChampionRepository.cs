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
                c.image = champ.Image;
                
                if(c.image == null)
                {
                    System.Diagnostics.Debug.WriteLine("image is null");
                }

                var s = champ.Stats;

                c.Armor = s.Armor;
                c.ArmorPerLevel = s.ArmorPerLevel;
                c.AttackDamage = s.AttackDamage;
                c.AttackDamagePerLevel = s.AttackDamagePerLevel;
                c.AttackRange = s.AttackRange;
                c.AttackSpeedOffset = s.AttackSpeedOffset;
                c.AttackSpeedPerLevel = s.AttackSpeedPerLevel;
                c.Crit = s.Crit;
                c.CritPerLevel = s.CritPerLevel;
                c.Hp = s.Hp;
                c.HpPerLevel = s.HpPerLevel;
                c.HpRegen = s.HpRegen;
                c.HpRegenPerLevel = s.HpRegenPerLevel;
                c.MoveSpeed = s.MoveSpeed;
                c.Mp = s.Mp;
                c.MpPerLevel = s.MpPerLevel;
                c.MpRegen = s.MpRegen;
                c.MpRegenPerLevel = s.MpRegenPerLevel;
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
            return _champions.Where(champion => champion.Category == category).ToList();
        }

        public List<Champion> GetChampionsByPartialName(string name)
        {
            return _champions.Where(champion => champion.Name.ToLower().Contains(name.ToLower())).ToList();
        }

    }
}
