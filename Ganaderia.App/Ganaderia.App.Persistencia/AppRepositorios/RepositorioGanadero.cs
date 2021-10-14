using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanadero : IRepositorioGanadero
    {

        public AppContext _appContext;
        public RepositorioGanadero(AppContext appContext){
            _appContext = appContext;
        }


      Ganadero IRepositorioGanadero.AddGanadero(Ganadero ganadero){
            var ganaderoAdicionado = _appContext.Ganaderos.Add(ganadero);
            _appContext.SaveChanges();
            return ganaderoAdicionado.Entity;
      }

      IEnumerable<Ganadero> IRepositorioGanadero.GetAllGanaderos(){
          return _appContext.Ganaderos;
      }

      Ganadero IRepositorioGanadero.UpdateGanadero(Ganadero ganadero)
        {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.ID == ganadero.ID);
            if (ganaderoEncontrado != null)
            {
                ganaderoEncontrado.Nombre = ganadero.Nombre;
                ganaderoEncontrado.Apellidos = ganadero.Apellidos;
                ///////////////
                _appContext.SaveChanges();
            }
            return ganaderoEncontrado;
        }   

          void IRepositorioGanadero.DeleteGanadero(int idGanadero)
        {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.ID == idGanadero);
            if (ganaderoEncontrado != null)
            {
                _appContext.Ganaderos.Remove(ganaderoEncontrado);
                ///////////////
                _appContext.SaveChanges();
            }
            
        } 

        Ganadero IRepositorioGanadero.GetGanadero(int idGanadero){
            
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.ID == idGanadero);
            return ganaderoEncontrado;

        }  
    }
}