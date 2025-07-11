using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuentas_Bancarias.Presentacion.Personas
{
    public partial class frmPersonaDetail : Form
    {
        private int _idPersona;
        private bool _isNew = true;

        /// <summary>
        /// Constructor para crear un formulario de detalle de persona nuevo, que permite ingresar los datos de una nueva persona.
        /// </summary>
        public frmPersonaDetail()
        {
            InitializeComponent();
            _isNew = true;
            crEar_nueva_persona();
        }

        /// <summary>
        /// Constructor para crear un formulario de detalle de persona con un ID específico, que permite cargar una persona que ya existe en la base de datos.
        /// </summary>
        /// <param name="id_persona"></param>
        public frmPersonaDetail(int id_persona)
        {
            InitializeComponent();
            _idPersona = id_persona;
            _isNew = false;
            load_persona();
        }

        private void load_persona()
        {
           personaBindingSource.DataSource =
               Data.Personas.PersonaDAO.Instancia.getByID(_idPersona);
        }
        private void crEar_nueva_persona()
        {
            personaBindingSource.DataSource =
                
                new Dominio.Personas.Persona()
                {
                    Id = Data.Personas.PersonaDAO.Instancia.getNextId(),
                    Direccion = new Dominio.Ubicaciones.Direccion(),
                    fecha_nacimiento = DateTime.Now,
                    calificacion_crediticia = 0
                };
        }
    }
}
