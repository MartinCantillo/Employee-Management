using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcproject.Repositories;
using MvcProject.Models;

namespace mvcproject.Controllers
{


    public class DepartamentoController : Controller
    {
        private readonly ILogger<DepartamentoController> _logger;
        private readonly IDepartamento _IDepartamento;

        public DepartamentoController(ILogger<DepartamentoController> _logger,IDepartamento _IDepartamento)
        {
            this._logger = _logger;
            this._IDepartamento=_IDepartamento;
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
            {     _logger.LogInformation(d.NombreD + d.AreaD);
                
                this._IDepartamento.SaveD(d);

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