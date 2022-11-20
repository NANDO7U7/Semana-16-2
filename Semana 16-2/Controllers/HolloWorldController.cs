using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Semana_16_2.Controllers
{
    public class HolloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bienvenida(String name, int numTimes = 1)
        {
            ViewData["name"] = "hola mundo {name}";
            ViewData["numTimes"] = numTimes;
            return View();
        }

        public string Parameters(string name, int numTimes=1)
        {
            return HtmlEncoder.Default.Encode($"HOLA{name},su numero de intentos es {numTimes}");
        }
    }
}
