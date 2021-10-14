using System.Collections.Generic;
namespace Ganaderia.App.Dominio
{
    public class Ganadero:Persona
    {
        public float latitude {get; set; }
        public float longitud {get; set; }
        public List <Ganado> ListaGanado {get; set;} 
        
    }
}