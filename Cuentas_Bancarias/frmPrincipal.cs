using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuentas_Bancarias
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listaDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Personas.frmPersonasList form = new Presentacion.Personas.frmPersonasList();
            form.MdiParent = this;
            form.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Data.Personas.PersonaDAO.Instancia.Add(new Dominio.Personas.Persona()
            //{
            //    Id = 1,
            //    Apellido = "Gomez",
            //    Nombre = "Juan",
            //    fecha_nacimiento = new DateTime(1990, 1, 1),
            //    Email = "juan@gmail.com",
            //    Telefono = "123456789",
            //    Movil = "987654321",
            //    Direccion = new Dominio.Ubicaciones.Direccion()
            //    {
            //        calle_principal = "Calle Falsa",
            //        calle_secundaria = "123",
            //        referencia = "nueva direccion",
            //        codigo_postal = "12345"
            //    },
            //    calificacion_crediticia = 900
            //});
        }
    }
}
