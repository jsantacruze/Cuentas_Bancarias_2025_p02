using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Dominio.Personas;

namespace Cuentas_Bancarias.Dominio.Cuentas
{
    public class Cuenta
    {

        public int Id { get; set; } 
        public string NumeroCuenta { get; set; }
        public DateTime fecha_apertura { get; set; }
        public float Saldo { get; }
        public Empleado ofcicial_cuenta { get; set; }
        
        public List<MovimientoCuenta> movimientos { get; }

        public Cuenta()
        {
            this.movimientos = new List<MovimientoCuenta>();
        }

        public Cuenta(int id, string numeroCuenta, DateTime fecha_apertura, Empleado ofcicial_cuenta)
        {
            Id = id;
            NumeroCuenta = numeroCuenta;
            this.fecha_apertura = fecha_apertura;
            this.ofcicial_cuenta = ofcicial_cuenta;
            this.movimientos = new List<MovimientoCuenta>();
        }

        public void AddMovimientoCuenta()
        {

        }
    }
}
