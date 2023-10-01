using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class Champion_SearchController : Controller
    {
        private List<Characters> champion = new List<Characters>
        {
            new Characters { Id = 1, Name = "Champion1", Role = "Tank" },
            new Characters { Id = 2, Name = "Champion2", Role = "Mage" },
            new Characters { Id = 3, Name = "Champion3", Role = "Bruiser" },
            new Characters { Id = 4, Name = "Champion4", Role = "Fighter" },
            new Characters { Id = 5, Name = "Champion5", Role = "Assassin" },
            new Characters { Id = 6, Name = "Champion6", Role = "Marksman" },
            new Characters { Id = 7, Name = "Champion7", Role = "Support" },
            new Characters { Id = 8, Name = "Champion8", Role = "Assassin" },
            new Characters { Id = 9, Name = "Champion9", Role = "Mage" },
            new Characters { Id = 10, Name = "Champion10", Role = "Marksman" },
            new Characters { Id = 11, Name = "Champion11", Role = "Support" },
            new Characters { Id = 12, Name = "Champion12", Role = "Tank" },
            new Characters { Id = 13, Name = "Champion13", Role = "Marksman" },
            new Characters { Id = 14, Name = "Champion14", Role = "Mage" },
            new Characters { Id = 15, Name = "Champion15", Role = "Assassin" },
            new Characters { Id = 16, Name = "Champion16", Role = "Marksman" },
            new Characters { Id = 17, Name = "Champion17", Role = "Support" },
            new Characters { Id = 18, Name = "Champion18", Role = "Assassin" },
            new Characters { Id = 19, Name = "Champion19", Role = "Mage" },
            new Characters { Id = 20, Name = "Champion20", Role = "Marksman" },
            new Characters { Id = 21, Name = "Champion21", Role = "Tank" },
            new Characters { Id = 22, Name = "Champion22", Role = "Mage" },
            new Characters { Id = 23, Name = "Champion23", Role = "Bruiser" },
            new Characters { Id = 24, Name = "Champion24", Role = "Fighter" },
            new Characters { Id = 25, Name = "Champion25", Role = "Assassin" },
            new Characters { Id = 26, Name = "Champion26", Role = "Marksman" },
            new Characters { Id = 27, Name = "Champion27", Role = "Support" },
            new Characters { Id = 28, Name = "Champion28", Role = "Assassin" },
            new Characters { Id = 29, Name = "Champion29", Role = "Mage" },
            new Characters { Id = 30, Name = "Champion30", Role = "Marksman" },
            new Characters { Id = 31, Name = "Champion31", Role = "Tank" },
            new Characters { Id = 32, Name = "Champion32", Role = "Mage" },
            new Characters { Id = 33, Name = "Champion33", Role = "Bruiser" },
            new Characters { Id = 34, Name = "Champion34", Role = "Fighter" },
            new Characters { Id = 35, Name = "Champion35", Role = "Assassin" },
            new Characters { Id = 36, Name = "Champion36", Role = "Marksman" },
            new Characters { Id = 37, Name = "Champion37", Role = "Support" },
            new Characters { Id = 38, Name = "Champion38", Role = "Assassin" },
            new Characters { Id = 39, Name = "Champion39", Role = "Mage" },
            new Characters { Id = 40, Name = "Champion40", Role = "Marksman" },
            new Characters { Id = 41, Name = "Champion41", Role = "Tank" },
            new Characters { Id = 42, Name = "Champion42", Role = "Mage" },
            new Characters { Id = 43, Name = "Champion43", Role = "Bruiser" },
            new Characters { Id = 44, Name = "Champion44", Role = "Fighter" },
            new Characters { Id = 45, Name = "Champion45", Role = "Assassin" },
            new Characters { Id = 46, Name = "Champion46", Role = "Marksman" },
            new Characters { Id = 47, Name = "Champion47", Role = "Support" },
            new Characters { Id = 48, Name = "Champion48", Role = "Assassin" },
            new Characters { Id = 49, Name = "Champion49", Role = "Mage" },
            new Characters { Id = 50, Name = "Champion50", Role = "Marksman" },
            new Characters { Id = 51, Name = "Champion51", Role = "Tank" },
            new Characters { Id = 52, Name = "Champion52", Role = "Mage" },
            new Characters { Id = 53, Name = "Champion53", Role = "Bruiser" },
            new Characters { Id = 54, Name = "Champion54", Role = "Fighter" },
            new Characters { Id = 55, Name = "Champion55", Role = "Assassin" },
            new Characters { Id = 56, Name = "Champion56", Role = "Marksman" },
            new Characters { Id = 57, Name = "Champion57", Role = "Support" },
            new Characters { Id = 58, Name = "Champion58", Role = "Assassin" },
            new Characters { Id = 59, Name = "Champion59", Role = "Mage" },
            new Characters { Id = 60, Name = "Champion60", Role = "Marksman" }
        };
        public IActionResult Champion_Search()
        {
            return View("~/Views/Home/Champion_Search.cshtml", champion);
        }



        //action method to filter the data by role
        [HttpPost]
        public IActionResult Filter(string role)
        {

            // Filter the data by role
            var filteredChampion = champion.Where(c => c.Role == role).ToList();
            // Pass the filtered data to the view
            return View("~/Views/Home/Champion_Search.cshtml", filteredChampion);
        }
    }
}
