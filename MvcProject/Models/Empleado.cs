using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class Empleado
    {
        public Empleado()
        {
        }

        public Empleado(int Id, string Name, string Codigo, string Cargo, int IdDepartamento)
        {
            this.Id = Id;
            this.Name = Name;
            this.Codigo = Codigo;
            this.Cargo = Cargo;
            this.IdDepartamento = IdDepartamento;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Codigo { get; set; }
        public string Cargo { get; set; }

        public int IdDepartamento { get; set; }

        public Departamento Departamento { get; set; } // Navegacion sin carga perezosa(Virtual)
    }
}