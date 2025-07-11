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
    public partial class frmPersonasList : Form
    {
        public frmPersonasList()
        {
            InitializeComponent();
        }

        private void frmPersonasList_Load(object sender, EventArgs e)
        {
            this.cmbTipoBusqueda.SelectedIndex = 0;
        }

        private void Buscar()
        {
            if (string.IsNullOrWhiteSpace(txtFiltro.Text.Trim())
                && this.cmbTipoBusqueda.SelectedIndex != 2)
            {
                MessageBox.Show("Debe ingresar un criterio de búsqueda.", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            switch (cmbTipoBusqueda.SelectedIndex)
            {
                case 0:
                    personaBindingSource.DataSource =
                        Data.Personas.PersonaDAO.Instancia.getByID(int.Parse(txtFiltro.Text.Trim())); 
                    break;
                case 1:
                    personaBindingSource.DataSource =
                        Data.Personas.PersonaDAO.Instancia.getByApellidosNombres(txtFiltro.Text.Trim()); 
                    break;
                case 2:
                    personaBindingSource.DataSource =
                        Data.Personas.PersonaDAO.Instancia.getAll();
                    break;
            }
            this.txtFiltro.Text = string.Empty;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void personaDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var persona_actual = personaBindingSource.Current as Dominio.Personas.Persona;
            if (persona_actual != null)
            {
                frmPersonaDetail form = new frmPersonaDetail(persona_actual.Id);
                form.ShowDialog();
            }
        }
    }
}
