using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class Departamento
    {
        public Departamento()
        {
        }
        public Departamento(int Id, string NombreD, string AreaD)
        {
            this.Id = Id;
            this.NombreD = NombreD;
            this.AreaD = AreaD;
        }


        public int Id { get; set; }
    
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string NombreD { get; set; }




        [Required(ErrorMessage = "El área es obligatoria")]
        public string AreaD { get; set; }

        public ICollection<Empleado> Empleados;
    }
}