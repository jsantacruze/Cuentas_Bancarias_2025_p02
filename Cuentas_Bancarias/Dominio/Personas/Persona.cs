using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Dominio.Ubicaciones;

namespace Cuentas_Bancarias.Dominio.Personas
{
    public class Persona
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public String Telefono { get; set; }
        public string Movil {  get; set; }
        public Direccion Direccion { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public float calificacion_crediticia { get; set; }

        public Persona()
        {
        }

        public Persona(int id, string nombre, string apellido, string email, string telefono, string movil, Direccion direccion, DateTime fecha_nacimiento,
            float calificacionCrediticia)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Movil = movil;
            Direccion = direccion;
            this.fecha_nacimiento = fecha_nacimiento;
            this.calificacion_crediticia = calificacionCrediticia;
        }

        public string getEdadAsString()
        {
            return "";
        }
    }
}
