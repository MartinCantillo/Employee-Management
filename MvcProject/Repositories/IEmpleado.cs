using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcProject.Models;

namespace mvcproject.Repositories
{
    public interface IEmpleado
    {
        public void SaveE(Empleado e );
        public ICollection<Empleado> GetEmpleados();

        public void DeleteE(int id);
    }
}