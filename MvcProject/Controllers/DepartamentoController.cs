using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult RegistroD(){
            return View();
        }

         public IActionResult VerD(){
            return View();
        }
    }
}