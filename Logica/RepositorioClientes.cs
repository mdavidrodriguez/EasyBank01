using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class RepositorioClientes
    {
        List<Cliente> listaclientes = new List<Cliente>();
        public string Adiccionar(Cliente cliente)
        {
            ServiciosClientes servicios = new ServiciosClientes();

            if (servicios.ClienteExist(cliente.IdCliente, listaclientes) != null)
            {
                listaclientes.Add(cliente);
                return "Cliente creado";
            }
            return "Cliente existente";
            Console.ReadLine();

        }
       
    }
}
