using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas_Bancarias.Dominio.Ubicaciones
{
    public class Direccion
    {
        public int id { get; set; }
        public string calle_principal { get; set; }
        public string calle_secundaria { get; set; }
        public string referencia { get; set; }
        public string codigo_postal { get; set; }
        public UbicacioGeografica ubicacio_geografica { get; set; }
        public Ciudad Ciudad { get; set; }


        public Direccion()
        {
        }

        public Direccion(int id, string calle_principal, string calle_secundaria, string referencia, string codigo_postal, UbicacioGeografica ubicacio_geografica, Ciudad ciudad)
        {
            this.id = id;
            this.calle_principal = calle_principal;
            this.calle_secundaria = calle_secundaria;
            this.referencia = referencia;
            this.codigo_postal = codigo_postal;
            this.ubicacio_geografica = ubicacio_geografica;
            Ciudad = ciudad;
        }
    }
}
