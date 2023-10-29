
// Champion.cs file. Located in the Models folder.
using Newtonsoft.Json;
using RiotSharp.Endpoints.StaticDataEndpoint;
using System;

namespace SampleProj.Models
{
    public class Champion
    {
        public Champion()
        {
            Name = ""; // Set a default value for Name
            Category = ""; // Set a default value for Attribute
            ImageUrl = ""; // Set a default value for ImageUrl
        }
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        public string Category = "temporary";
        public string ImageUrl { get; set; }
        public ImageStatic? image { get; set; }


        // The values for stats seem to mostly be doubles.
        //
        // from: https://web.archive.org/web/20200314164454/http://forums.na.leagueoflegends.com/board/showthread.php?t=37347
        // "There is no rounding. Some numbers we round visually so that you don't see a zillion decimal 
        // places however when computing the math it uses the full numbers."
        //
        // This is likely still the same. We can correct this later if needed.
        // reminder: base AP and AP growth are zero.

        // Term key: HP <-> Health points, AD <-> Attack damage
        //           AS <-> Attack speed,  AP <-> Ability Power
        //           MR <-> Magic resist,  Range <-> Distance for basic attacks
        //           MS <-> Movement speed
        //           regen <-> regeneration amount per 5 seconds
        //           growth <-> Increase per champion level 

        // Resource related statistics
        [JsonProperty("armor")]
        public double Armor { get; set; }

        /// <summary>
        /// Armor won per level.
        /// </summary>
        [JsonProperty("armorperlevel")]
        public double ArmorPerLevel { get; set; }

        /// <summary>
        /// Base attack damage.
        /// </summary>
        [JsonProperty("attackdamage")]
        public double AttackDamage { get; set; }

        /// <summary>
        /// Attack damage won per level.
        /// </summary>
        [JsonProperty("attackdamageperlevel")]
        public double AttackDamagePerLevel { get; set; }

        /// <summary>
        /// Base attack range.
        /// </summary>
        [JsonProperty("attackrange")]
        public double AttackRange { get; set; }

        /// <summary>
        /// Base attack speed.
        /// </summary>
        [JsonProperty("attackspeedoffset")]
        public double AttackSpeedOffset { get; set; }

        /// <summary>
        /// Attack speed won per level.
        /// </summary>
        [JsonProperty("attackspeedperlevel")]
        public double AttackSpeedPerLevel { get; set; }

        /// <summary>
        /// Base crit percentage.
        /// </summary>
        [JsonProperty("crit")]
        public double Crit { get; set; }

        /// <summary>
        /// Crit percentage won per level.
        /// </summary>
        [JsonProperty("critperlevel")]
        public double CritPerLevel { get; set; }

        /// <summary>
        /// Base hit points.
        /// </summary>
        [JsonProperty("hp")]
        public double Hp { get; set; }

        /// <summary>
        /// Hit points won per level.
        /// </summary>
        [JsonProperty("hpperlevel")]
        public double HpPerLevel { get; set; }

        /// <summary>
        /// Base hit point regeneration.
        /// </summary>
        [JsonProperty("hpregen")]
        public double HpRegen { get; set; }

        /// <summary>
        /// Hit points regeneration per level.
        /// </summary>
        [JsonProperty("hpregenperlevel")]
        public double HpRegenPerLevel { get; set; }

        /// <summary>
        /// Base move speed.
        /// </summary>
        [JsonProperty("movespeed")]
        public double MoveSpeed { get; set; }

        /// <summary>
        /// Base mana points.
        /// </summary>
        [JsonProperty("mp")]
        public double Mp { get; set; }

        /// <summary>
        /// Mana points won per level.
        /// </summary>
        [JsonProperty("mpperlevel")]
        public double MpPerLevel { get; set; }

        /// <summary>
        /// Base mana point regeneration.
        /// </summary>
        [JsonProperty("mpregen")]
        public double MpRegen { get; set; }

        /// <summary>
        /// Mana point regeneration won per level.
        /// </summary>
        [JsonProperty("mpregenperlevel")]
        public double MpRegenPerLevel { get; set; }

        /// <summary>
        /// Base spell block.
        /// </summary>
        [JsonProperty("spellblock")]
        public double SpellBlock { get; set; }

        /// <summary>
        /// Spell block won per level.
        /// </summary>
        [JsonProperty("spellblockperlevel")]
        public double SpellBlockPerLevel { get; set; }

        public double LifeSteal { get; set; } = 0;

        public double SpellVamp { get; set; } = 0;

        public double Tenacity { get; set; } = 0;



    }
}
