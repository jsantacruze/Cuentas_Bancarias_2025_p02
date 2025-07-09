using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Dominio.Ubicaciones;

namespace Cuentas_Bancarias.Dominio.Personas
{
    public class Empleado : Persona
    {
        public float Salario { get; set; }
        public DateTime fecha_ingreso { get; set; }

        public Empleado()
        { 
        }

        public Empleado(int id, string nombre, string apellido, string email, string telefono, string movil, Direccion direccion, DateTime fecha_nacimiento,
            float salario, DateTime fechaIngreso, float calificacionCrediticia) 
            : base(id, nombre, apellido, email, telefono, movil, direccion, fecha_nacimiento, calificacionCrediticia)
        {
            this.Salario = salario;
            this.fecha_ingreso = fechaIngreso;
        }
    }
}
