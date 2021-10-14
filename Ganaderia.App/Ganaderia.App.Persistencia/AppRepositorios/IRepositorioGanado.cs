using Ganaderia.App.Dominio;
using System.Collections.Generic;
namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanado
    {
        Ganado AddGanado(Ganado ganado);

        IEnumerable<Ganado> GetAllGanados();

        Ganado UpdateGanado(Ganado ganado);

        void DeleteGanado(int idGanado);

        Ganado GetGanado(int idGanado);

      
    }
}