using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcProject.Models;

namespace mvcproject.Repositories
{
    public interface IDepartamento
    {
        public void  SaveD(Departamento d);

        public ICollection<Departamento> GetD();

        public void DeleteD(int id);

    }
}