using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SampleProj.Models;
using SampleProj.Repository;



namespace SampleProj.Controllers
{
    public class ItemsController : Controller
    {

        private Champion champion;

        public IActionResult Items(Champion champ)
        {
            champion=champ;
            return View("~/Views/Champions/Items.cshtml", champ);
        }
    }
}