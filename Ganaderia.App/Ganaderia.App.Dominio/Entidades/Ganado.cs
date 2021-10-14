using System.Collections.Generic;
namespace Ganaderia.App.Dominio
{
    public class Ganado
    {
        public int Id { get; set; }
        public string Raza { get; set; }
        public string Alias { get; set; }
        public int cantidad { get; set; }
        public Veterinario veterinario { get; set; }
        public List <Vacuna> Vacunas { get; set; }
    }
}