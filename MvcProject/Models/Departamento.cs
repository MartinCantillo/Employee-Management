using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class Departamento
    {
        public Departamento()
        {
            // Inicializa la colección Empleados para evitar null reference
          //  Empleados = new List<Empleado>();
        }

        public Departamento(int Id, string NombreD, string AreaD)
        {
            this.Id = Id;
            this.NombreD = NombreD;
            this.AreaD = AreaD;

            // Inicializa la colección Empleados en el constructor si es necesario
         //   Empleados = new List<Empleado>();
        }

        public int Id { get; set; }
    
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string NombreD { get; set; }

        [Required(ErrorMessage = "El área es obligatoria")]
        public string AreaD { get; set; }

       // public ICollection<Empleado> Empleados { get; set; }
    }
}
