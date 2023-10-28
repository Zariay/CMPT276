
// Champion.cs file. Located in the Models folder.
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
        public string Name { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }


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
        public double base_HP { get; set; }
        public double HP_growth { get; set; }
        public double base_HP_regen { get; set; }
        public double HP_regen_growth { get; set; }

        public double base_mana { get; set; }
        public double mana_growth { get; set; }
        public double base_mana_regen { get; set; }
        public double mana_regen_growth { get; set; }
        public double base_energy {  get; set; } // alternative resource bar
        public double base_energy_regen { get; set; } // alternative resource regen

        // Offensive statistics
        public double base_AD { get; set; }
        public double AD_growth { get; set; }
        public double base_AS { get; set; }
        public double AS_growth { get; set; }

        // Defensive statistics
        public double base_armor { get; set; }
        public double armor_growth { get; set; }
        public double base_MR { get; set; }
        public double MR_growth { get; set; }

        // Other statistics
        public int range { get; set; }
        public double base_MS { get; set; }
        public int base_gold_generation {  get; set; } 


    }
}
