using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas_Bancarias.Dominio.Ubicaciones
{
    public class Ciudad
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public EstadoProvincia estado_provincia { get; set; }

        public Ciudad()
        {
        }

        public Ciudad(string id, string nombre, EstadoProvincia estado_provincia)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado_provincia = estado_provincia;
        }
    }
}
