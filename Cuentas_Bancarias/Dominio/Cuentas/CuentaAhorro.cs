using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Dominio.Personas;

namespace Cuentas_Bancarias.Dominio.Cuentas
{
    public class CuentaAhorro : Cuenta
    {
        public float tasa_interes {  get; set; }
        public CuentaAhorro()
        {
        }

        public CuentaAhorro(int id, string numeroCuenta, DateTime fecha_apertura, Empleado ofcicial_cuenta, float tasaInteres) 
            : base(id, numeroCuenta, fecha_apertura, ofcicial_cuenta)
        {
            this.tasa_interes = tasaInteres;
        }
    }
}
