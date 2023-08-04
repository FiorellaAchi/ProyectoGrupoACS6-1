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
    public partial class FrmRegistrarAmbulancias : Form
    {
        Datos datos = new Datos();
        public FrmRegistrarAmbulancias()
        {
            InitializeComponent();
            DGVAmbulancias.DataSource = datos.ListarAmbulancias(); //Muestra los datos de la tabla en el DataGridView
        }

      

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); //Regresa al menu de ambulancias
            FrmMenuAmbulancia frmMenuAmbulancia = new FrmMenuAmbulancia(); //Abre el formulario del menu de ambulancias
            frmMenuAmbulancia.Show(); //Muestra el formulario
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {  
            try 
            {
                
                datos.InsertarAmbulancia(txtCodigo.Text, txtMarca.Text, txtNumeroPlaca.Text, txtAnio.Text, txtIdConductor.Text); //Inserta los datos en la base de datos
                DGVAmbulancias.DataSource = datos.ListarAmbulancias(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void LblMenu_Click(object sender, EventArgs e)
        {

        }

        private void lblIdConductor_Click(object sender, EventArgs e)
        {

        }

        private void txtIdConductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConductor_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAnio_Click(object sender, EventArgs e)
        {

        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
