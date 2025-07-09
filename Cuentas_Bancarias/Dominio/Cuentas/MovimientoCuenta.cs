using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Dominio.Empresa;
using Cuentas_Bancarias.Dominio.Personas;

namespace Cuentas_Bancarias.Dominio.Cuentas
{
    public class MovimientoCuenta
    {

        public int Id { get; set; }
        public DateTime fecha_movimiento { get; set; }
        public float Monto { get; set; }
        public string DetalleMovimiento { get; set; }

        public Empleado responsable { get; set; }
        public Sucursal sucursal { get; set; }
        public TipoMovimientoCuenta tipo { get; set; }


        public MovimientoCuenta()
        {
        }

        public MovimientoCuenta(int id, DateTime fecha_movimiento, float monto, string detalleMovimiento, Empleado responsable, Sucursal sucursal, TipoMovimientoCuenta tipo)
        {
            Id = id;
            this.fecha_movimiento = fecha_movimiento;
            Monto = monto;
            DetalleMovimiento = detalleMovimiento;
            this.responsable = responsable;
            this.sucursal = sucursal;
            this.tipo = tipo;
        }
    }
}
