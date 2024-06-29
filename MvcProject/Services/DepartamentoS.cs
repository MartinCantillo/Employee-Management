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
        public DepartamentoS(DataContext dataContext)
        {
            this._DataContext = dataContext;
        }

        public void DeleteD(int id)
        {
            if (id == 0)
            {
                throw new Exception("Por favor verifica");
            }
            else
            {
                var found = this._DataContext.Departamento.FirstOrDefault(d => d.Id == id);
                if (found != null)
                {

                    this._DataContext.Departamento.Remove(found);
                    this._DataContext.SaveChanges();
                }
                else
                {
                    throw new Exception("No encontrado");
                }
            }
        }

        public ICollection<Departamento> GetD() => this._DataContext.Departamento.ToList();

        public void SaveD(Departamento d)
        {
            if (d == null)
            {
                throw new ArgumentNullException("El Departamento es null");
            }

            if (string.IsNullOrWhiteSpace(d.NombreD) || string.IsNullOrWhiteSpace(d.AreaD))
            {
                throw new Exception("El nombre y el área son obligatorios");
            }

            try
            {
                Console.WriteLine("servicios saveD");
                Console.WriteLine($"DataContext: {_DataContext}");
               

                 Console.WriteLine($"Departamento: {d.NombreD}, {d.AreaD}, {d.Id}");
                //d.Id=1;
                _DataContext.Departamento.Add(d);
                _DataContext.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el departamento", ex);
            }
        }


    }
}