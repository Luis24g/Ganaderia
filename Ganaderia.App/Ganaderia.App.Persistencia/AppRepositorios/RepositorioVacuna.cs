using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Ganaderia.App.Persistencia
{
    public class RepositorioVacuna : IRepositorioVacuna
    {

        public AppContext _appContext;
        public RepositorioVacuna(AppContext appContext){
            _appContext = appContext;
        }


      Vacuna IRepositorioVacuna.AddVacuna(Vacuna vacuna){
            var vacunaAdicionado = _appContext.Vacunas.Add(vacuna);
            _appContext.SaveChanges();
            return vacunaAdicionado.Entity;
      }

      IEnumerable<Vacuna> IRepositorioVacuna.GetAllVacunas(){
          return _appContext.Vacunas;
      }

      Vacuna IRepositorioVacuna.UpdateVacuna(Vacuna vacuna)
        {
            var vacunaEncontrado = _appContext.Vacunas.FirstOrDefault(g => g.ID == vacuna.ID);
            if (vacunaEncontrado != null)
            {
                vacunaEncontrado.Nombre = vacuna.Nombre;
                vacunaEncontrado.Descripcion = vacuna.Descripcion;
                ///////////////
                _appContext.SaveChanges();
            }
            return vacunaEncontrado;
        }   

          void IRepositorioVacuna.DeleteVacuna(int idVacuna)
        {
            var vacunaEncontrado = _appContext.Vacunas.FirstOrDefault(g => g.ID == idVacuna);
            if (vacunaEncontrado != null)
            {
                _appContext.Vacunas.Remove(vacunaEncontrado);
                ///////////////
                _appContext.SaveChanges();
            }
            
        } 

        Vacuna IRepositorioVacuna.GetVacuna(int idVacuna){
            
            var vacunaEncontrado = _appContext.Vacunas.FirstOrDefault(g => g.ID == idVacuna);
            return vacunaEncontrado;

        }  
    }
}