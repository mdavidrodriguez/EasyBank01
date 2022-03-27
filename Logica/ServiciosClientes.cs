using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logica
{
    public class ServiciosClientes
    {
        public Cliente ClienteExist(string idCliente, List<Cliente> listaClientes)
        {
            foreach (var item in listaClientes)
            {
                if (idCliente == item.IdCliente)
                {
                    return item;    
                }
            }           
            return null;
        }
    }
}
