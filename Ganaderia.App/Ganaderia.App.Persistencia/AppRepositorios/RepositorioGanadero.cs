using Ganaderia.App.Dominio;
namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanadero : IRepositorioGanadero
    {

        public AppContext _appContext;
        RepositorioGanadero(AppContext appContext){
            _appContext = appContext;
        }


      Ganadero IRepositorioGanadero.AddGanadero(Ganadero ganadero){
            var ganaderoAdicionado = _appContext.Ganaderos.Add(ganadero);
            _appContext.SaveChanges();
            return ganaderoAdicionado.Entity;
      }   
    }
}