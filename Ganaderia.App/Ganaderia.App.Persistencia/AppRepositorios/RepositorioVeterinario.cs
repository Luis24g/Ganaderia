using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Ganaderia.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {

        public AppContext _appContext;
        public RepositorioVeterinario(AppContext appContext){
            _appContext = appContext;
        }


      Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario){
            var veterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
      }

      IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios(){
          return _appContext.Veterinarios;
      }

      Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(g => g.ID == veterinario.ID);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Nombre = veterinario.Nombre;
                veterinarioEncontrado.Apellidos = veterinario.Apellidos;
                ///////////////
                _appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }   

          void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(g => g.ID == idVeterinario);
            if (veterinarioEncontrado != null)
            {
                _appContext.Veterinarios.Remove(veterinarioEncontrado);
                ///////////////
                _appContext.SaveChanges();
            }
            
        } 

        Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario){
            
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(g => g.ID == idVeterinario);
            return veterinarioEncontrado;

        }  
    }
}