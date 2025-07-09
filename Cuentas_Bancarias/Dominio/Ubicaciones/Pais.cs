using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas_Bancarias.Dominio.Ubicaciones
{
    public class Pais
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string prefijo_telefonico_internacional { get; set; }

        public Pais()
        {
        }

        public Pais(string id, string nombre, string prefijo_telefonico_internacional)
        {
            this.id = id;
            this.nombre = nombre;
            this.prefijo_telefonico_internacional = prefijo_telefonico_internacional;
        }
    }
}
