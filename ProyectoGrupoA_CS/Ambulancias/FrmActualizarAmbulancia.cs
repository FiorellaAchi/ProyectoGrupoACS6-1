using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulancias
{
    public partial class FrmActualizarAmbulancia : Form
    {
        Datos Datos = new Datos();
        public FrmActualizarAmbulancia()
        {
            InitializeComponent();
            dgvAmbulancia.DataSource = Datos.ListarAmbulancias(); //Muestra los datos de la tabla en el DataGridView
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); //Regresa al menu de ambulancias
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try 
            {
                Datos.ActualizarAmbulancia(txtCodigo.Text, txtMarcaAmbulancias.Text, txtPlaca.Text, txtAnioAmbulancia.Text, txtConductorID.Text); //Actualiza los datos en la base de datos
                dgvAmbulancia.DataSource = Datos.ListarAmbulancias(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
