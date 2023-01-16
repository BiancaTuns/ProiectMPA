using Microsoft.AspNetCore.Mvc;
using ProdusApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdusApp.Controllers
{
    public class ProdusController : Controller
    {
        public IActionResult DetaliiProdus(string articol)
        {
            Produs produs = BazaDedateProduse.Articol(articol);

            return View(produs);
        }

        public IActionResult ListaProduse()
        {
            List<Produs> listaProduse = BazaDedateProduse.ListaProduse();

            return View(listaProduse);
        }
    }
}


