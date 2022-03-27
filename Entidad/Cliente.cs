using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public  string Nombre { get; set; }
        public Cliente()
        {

        }

        public Cliente(string idCliente, string nombre)
        {
            IdCliente = idCliente;
            Nombre = nombre;
        }
    }
}
