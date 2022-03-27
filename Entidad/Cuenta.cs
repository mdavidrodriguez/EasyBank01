using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    internal class Cuenta
    {
        public Cuenta(double numeroCuenta, Cliente cliente, double saldo)
        {
            NumeroCuenta = numeroCuenta;
            this.cliente = cliente;
            Saldo = saldo;
        }

        public double NumeroCuenta { get; set; }
        public Cliente cliente { get; set; }
        public double Saldo { get; set; }

    }
}
