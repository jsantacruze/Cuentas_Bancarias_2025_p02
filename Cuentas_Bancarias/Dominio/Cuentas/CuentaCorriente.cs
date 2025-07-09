using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Dominio.Personas;

namespace Cuentas_Bancarias.Dominio.Cuentas
{
    public class CuentaCorriente : Cuenta
    {
        public float cupo_sobregiro {  get; set; }

        public CuentaCorriente()
        {
        }

        public CuentaCorriente(int id, string numeroCuenta, DateTime fecha_apertura, Empleado ofcicial_cuenta, float cupoSobregiro) 
            : base(id, numeroCuenta, fecha_apertura, ofcicial_cuenta)
        {
            this.cupo_sobregiro = cupoSobregiro;
        }
    }
}
