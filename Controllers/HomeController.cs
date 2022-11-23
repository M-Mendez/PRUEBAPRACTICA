using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PRUEBAPRACTICA.Data;
using PRUEBAPRACTICA.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PRUEBAPRACTICA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private PruebaContext _context;

        public HomeController(ILogger<HomeController> logger, PruebaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            var resultado = _context.puschases.Include(x => x.customer)
                                .Include(x => x.cars).ToList()
                                .Select(x => new ReporteDTO
                                {
                                    Nombre = $"{x.customer.firstname} {x.customer.lastName}",
                                    Fecha = x.Date,
                                    PrecioVenta = x.Price,
                                    Precio = x.cars.Price,
                                    caracteristicas = $"color: {x.cars.Color} año: { x.cars.Year }, modelo: {x.cars.Make}- {x.cars.Year}"
                                });

            return View(resultado);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
