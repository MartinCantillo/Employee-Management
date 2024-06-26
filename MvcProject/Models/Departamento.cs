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
        public Departamento(int Id, string NombreD, string AreaD)
        {
            this.Id = Id;
            this.NombreD = NombreD;
            this.AreaD = AreaD;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NombreD { get; set; }

        public string AreaD { get; set; }


    }
}