using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcproject.Repositories;
using MvcProject.Data;
using MvcProject.Models;

namespace mvcproject.Services
{
    public class DepartamentoS : IDepartamento
    {
        private readonly DataContext _DataContext;
        public DepartamentoS(DataContext _DataContext)
        {
            this._DataContext = _DataContext;
        }

        public void DeleteD(int id)
        {
            if (id == 0)
            {
                throw new Exception("Por favor verifica");
            }
            else
            {
                var found = this._DataContext._Departamento.FirstOrDefault(d => d.Id == id);
                if (found != null)
                {

                    this._DataContext._Departamento.Remove(found);
                    this._DataContext.SaveChanges();
                }
                else
                {
                    throw new Exception("No encontrado");
                }
            }
        }

        public ICollection<Departamento> GetD() => this._DataContext._Departamento.ToList();

        public void SaveD(Departamento d)
        {
            if (d.NombreD == "" || d.AreaD == "")
            {
                throw new Exception("Por favor verifica");
            }
            else
            {
                this._DataContext._Departamento.Add(d);
                this._DataContext.SaveChanges();
            }
        }
    }
}