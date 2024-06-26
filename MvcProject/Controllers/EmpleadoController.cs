using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcproject.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly ILogger<EmpleadoController> _logger;
        public EmpleadoController(ILogger<EmpleadoController> _logger)
        {
            this._logger = _logger;
        }

        public IActionResult RegistrarE()
        {
            _logger.LogInformation("Se ha accedido al método RegistrarE.");
            return View();
        }
    }
}