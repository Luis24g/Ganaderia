using Ganaderia.App.Dominio;
using System.Collections.Generic;
namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        Veterinario AddVeterinario(Veterinario veterinario);

        IEnumerable<Veterinario> GetAllVeterinarios();

        Veterinario UpdateVeterinario(Veterinario veterinario);

        void DeleteVeterinario(int idVeterinario);

        Veterinario GetVeterinario(int idVeterinario);

      
    }
}