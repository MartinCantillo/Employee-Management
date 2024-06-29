using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcproject.Repositories;
using MvcProject.Data;
using MvcProject.Models;

namespace mvcproject.Services
{
    public class EmpleadoS : IEmpleado
    {

        private readonly DataContext _DataContext;
        public EmpleadoS(DataContext _DataContext)
        {
            this._DataContext = _DataContext;
        }


        public void DeleteE(int id)
        {
            if (id == 0)
            {
                throw new Exception("Por favor verifica");
            }
            else
            {
                var found = this._DataContext.Empleado.FirstOrDefault(d => d.Id == id);
                if (found != null)
                {

                    this._DataContext.Empleado.Remove(found);
                    this._DataContext.SaveChanges();
                }
                else
                {
                    throw new Exception("No encontrado");
                }
            }
        }

        public ICollection<Empleado> GetEmpleados() => this._DataContext.Empleado.ToList();


        public void SaveE(Empleado e)
        {
            if (e.Name == "" || e.Cargo == "" || e.IdDepartamento == 0)
            {
                throw new Exception("Por favor verifica");
            }
            else
            {
                this._DataContext.Empleado.Add(e);
                this._DataContext.SaveChanges();
            }
        }
    }
}