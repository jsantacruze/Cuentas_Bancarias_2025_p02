using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Dominio.Personas;

namespace Cuentas_Bancarias.Dominio.Cuentas
{
    public class TarjetaCredito : Cuenta
    {
        public float cupo_credito {  get; set; }
        public bool activa_consumo_internacional { get; set; }
        public List<Persona> garantes { get; set; }
        public TarjetaCredito()
        {
            this.garantes = new List<Persona>();
        }

        public TarjetaCredito(int id, string numeroCuenta, DateTime fecha_apertura, Empleado ofcicial_cuenta, 
            float cupoCredito, bool activaConsumosInternacional) 
            : base(id, numeroCuenta, fecha_apertura, ofcicial_cuenta)
        {
            this.cupo_credito = cupoCredito;
            this.activa_consumo_internacional = activaConsumosInternacional;
            this.garantes = new List<Persona>();
        }

        public void AddGarante(Persona p)
        {
            if (p.calificacion_crediticia < 500)
                throw new Exception("No cumple con la calficación para ser garante");

                this.garantes.Add(p);
        }

        public void RemoveGarante(Persona p)
        {
            this.garantes.Remove(p);
        }
    }
}
