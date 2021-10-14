using Ganaderia.App.Dominio;
using System.Collections.Generic;
namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioVacuna
    {
        Vacuna AddVacuna(Vacuna vacuna);

        IEnumerable<Vacuna> GetAllVacunas();

        Vacuna UpdateVacuna(Vacuna vacuna);

        void DeleteVacuna(int idVacuna);

        Vacuna GetVacuna(int idVacuna);

      
    }
}