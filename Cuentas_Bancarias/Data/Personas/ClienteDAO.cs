using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Data.Base;

namespace Cuentas_Bancarias.Data.Personas
{
    public class ClienteDAO : BaseDAO<Dominio.Personas.Cliente>
    {
        private static ClienteDAO _instancia;

        public static ClienteDAO Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ClienteDAO();
                return _instancia;
            }
        }
        public ClienteDAO() : base("clientes.json") 
        { 
        }

        public Dominio.Personas.Cliente getByID(int id)
        {
            var result = this.data.Where(p => p.Id == id).FirstOrDefault();
            return result;
        }

        public List<Dominio.Personas.Cliente> getByApellidosNombres(string filtro)
        {
            var result = this.data.Where(p => p.Apellido.Contains(filtro) || p.Nombre.Contains(filtro)).ToList();
            return result;
        }

        public List<Dominio.Personas.Cliente> getBySucursal(int id_sucursal)
        {
            var result = this.data.Where(p => p.sucursal_pertenece.Id == id_sucursal).ToList();
            return result;
        }
    }
}
