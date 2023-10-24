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

        private Champion? Champion { get; set;}

        public IActionResult Items(Champion champ)
        {
            Champion=champ;
            return View("~/Views/Items/Index.cshtml", champ);
        }
    }
}