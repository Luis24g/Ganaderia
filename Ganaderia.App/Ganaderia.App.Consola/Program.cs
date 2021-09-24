using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;
namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repoGanadero = new RepositorioGanadero(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddGanadero();
        }

        private static void AddGanadero(){
            var ganadero= new Ganadero{
                Nombre= "Luis",
                Apellidos="Rincon",
                NumeroTelefono="123456",
                Direccion="Calle falsa 123",
                Correo="HolaMundo@gmail.com",
                Password= "12345",
                latitude= 12345,
                longitud= 6789
            };
            _repoGanadero.AddGanadero(ganadero);
        }
    }
}
