using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using Entidad;
namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logica.RepositorioClientes repositorio1 = new Logica.RepositorioClientes();
            //repositorio1.Adiccionar(p);
            Cliente p1 = new Cliente("1273664", "Mateo Rodriguez");
            Console.WriteLine(repositorio1.Adiccionar(p1));
            Console.ReadLine();
            // Console.WriteLine("Cliente agregado");
            //// logica.RepositorioPersonas repositorio = new logica.RepositorioPersonas();

        }
    }
}
