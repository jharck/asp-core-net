using System;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogotá";
            escuela.Dirección = "Calle 9 Entre 3 y 4 av rd";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            ViewBag.CosaDinamica = "La Monja";

            return View(escuela);
        }
    }
}