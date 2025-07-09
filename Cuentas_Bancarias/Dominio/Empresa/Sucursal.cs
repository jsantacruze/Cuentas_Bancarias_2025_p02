using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Dominio.Personas;
using Cuentas_Bancarias.Dominio.Ubicaciones;

namespace Cuentas_Bancarias.Dominio.Empresa
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activa { get; set; }
        public Direccion direccion { get; set; }
        public Empleado empleado_responsable { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Sucursal()
        {
        }

        public Sucursal(int id, string nombre, bool activa, Direccion direccion, Empleado empleado_responsable, string telefono, string email)
        {
            Id = id;
            Nombre = nombre;
            Activa = activa;
            this.direccion = direccion;
            this.empleado_responsable = empleado_responsable;
            Telefono = telefono;
            Email = email;
        }
    }
}
