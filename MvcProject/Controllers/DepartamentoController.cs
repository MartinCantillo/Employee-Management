using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace mvcproject.Controllers
{


    public class DepartamentoController : Controller
    {
        private readonly ILogger<DepartamentoController> _logger;

        public DepartamentoController(ILogger<DepartamentoController> _logger)
        {
            this._logger = _logger;
        }

        public IActionResult RegistrarD()
        {
            _logger.LogInformation("Se ha accedido al método RegistrarD.");
            return View();
        }
        public IActionResult RegistroD()
        {
            return View();
        }

        public IActionResult VerD()
        {
            return View();
        }

        public IActionResult ObtenerD()
        {
            return View();
        }
        public IActionResult EmpleadoxD()
        {
            return View();
        }
        public IActionResult DmayorDiez()
        {
            return View();
        }


         [HttpPost]
        public IActionResult GuardarD(Departamento d)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Confirmacion");
            }
            return View(d);
        }

        public IActionResult Confirmacion()
        {
            return View();
        }
    }
}