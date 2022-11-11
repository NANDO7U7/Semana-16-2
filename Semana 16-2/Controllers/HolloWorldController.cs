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
        public string Welcome()
        {
            return "Estas es la accion por defevto";
        }

        public string Parameters(string name, int edad)
        {
            return HtmlEncoder.Default.Encode($"HOLA{name}, tu edada es {edad} años");
        }
    }
}
