using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanado : IRepositorioGanado
    {

        public AppContext _appContext;
        public RepositorioGanado(AppContext appContext){
            _appContext = appContext;
        }


      Ganado IRepositorioGanado.AddGanado(Ganado ganado){
            var ganadoAdicionado = _appContext.Ganados.Add(ganado);
            _appContext.SaveChanges();
            return ganadoAdicionado.Entity;
      }

      IEnumerable<Ganado> IRepositorioGanado.GetAllGanados(){
          return _appContext.Ganados;
      }

      Ganado IRepositorioGanado.UpdateGanado(Ganado ganado)
        {
            var ganadoEncontrado = _appContext.Ganados.FirstOrDefault(g => g.Id == ganado.Id);
            if (ganadoEncontrado != null)
            {
                ganadoEncontrado.Raza = ganado.Raza;
                ganadoEncontrado.Alias = ganado.Alias;
                ///////////////
                _appContext.SaveChanges();
            }
            return ganadoEncontrado;
        }   

          void IRepositorioGanado.DeleteGanado(int idGanado)
        {
            var ganadoEncontrado = _appContext.Ganados.FirstOrDefault(g => g.Id == idGanado);
            if (ganadoEncontrado != null)
            {
                _appContext.Ganados.Remove(ganadoEncontrado);
                ///////////////
                _appContext.SaveChanges();
            }
            
        } 

        Ganado IRepositorioGanado.GetGanado(int idGanado){
            
            var ganadoEncontrado = _appContext.Ganados.FirstOrDefault(g => g.Id == idGanado);
            return ganadoEncontrado;

        }  
    }
}