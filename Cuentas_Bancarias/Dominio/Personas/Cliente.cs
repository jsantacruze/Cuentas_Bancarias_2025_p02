using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Dominio.Empresa;
using Cuentas_Bancarias.Dominio.Ubicaciones;

namespace Cuentas_Bancarias.Dominio.Personas
{
    public class Cliente : Persona
    {
        public Sucursal sucursal_pertenece {  get; set; }

        public Cliente()
        {
        }

        public Cliente(int id, string nombre, string apellido, string email, string telefono, string movil, Direccion direccion, DateTime fecha_nacimiento
            , Sucursal sucursal, float calificacio_crediticia) 
            : base(id, nombre, apellido, email, telefono, movil, direccion, fecha_nacimiento, calificacio_crediticia)
        {
            this.sucursal_pertenece = sucursal;
        }
    }
}
