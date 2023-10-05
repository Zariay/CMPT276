
// ChampionsController.cs file. Located in the Controllers folder.
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SampleProj.Models; // Import the Champion model
using SampleProj.Repository; // Import the ChampionRepository class


namespace SampleProj.Controllers
{
    public class ChampionsController : Controller // Inherit from the Controller class
    {
        private readonly ChampionRepository _championRepository; // Create a new instance of the ChampionRepository class

        public ChampionsController()
        {
            _championRepository = new ChampionRepository(); // Initialize the ChampionRepository instance
        }

        public IActionResult Index(string searchTerm)
        {
            List<Champion> champions;

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                // If a search term is provided, filter champions by name
                champions = _championRepository.GetChampionsByPartialName(searchTerm);
            }
            else
            {
                // If no search term is provided, display all champions
                champions = _championRepository.GetAllChampions();
            }

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("_ChampionList", champions);
            }

            return View(champions);
        }



        [HttpGet] // This action will only respond to GET requests

    

       //THIS FUNCION IS REDUNDANT



        // public IActionResult Search(string query)
        // {
        //     if (string.IsNullOrWhiteSpace(query))
        //     {
        //         // If the search query is empty, return all champions
        //         return RedirectToAction("Index");
        //     }

        //     List<Champion> champions = _championRepository.GetChampionsByPartialName(query);
        //     return View("Index", champions);
        // }

        public IActionResult Filter(string category)
        {
            List<Champion> champions;

            if (string.IsNullOrWhiteSpace(category))
            {
                // If no category is specified, return all champions
                champions = _championRepository.GetAllChampions();
            }
            else
            {
                champions = _championRepository.GetChampionsByCategory(category);
            }

            // return PartialView("Index", champions);
            return View("Index", champions);
        } 

    }
}




