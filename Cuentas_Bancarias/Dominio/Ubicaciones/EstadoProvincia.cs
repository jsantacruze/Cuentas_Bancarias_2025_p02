using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas_Bancarias.Dominio.Ubicaciones
{
    public class EstadoProvincia
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public Pais pais { get; set; }

        public EstadoProvincia()
        {
        }

        public EstadoProvincia(string id, string nombre, Pais pais)
        {
            this.id = id;
            this.nombre = nombre;
            this.pais = pais;
        }
    }
}
