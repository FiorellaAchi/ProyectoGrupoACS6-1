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

namespace Insumos
{
    public partial class EliminarInsumo : Form
    {
        Datos datos = new Datos();
        public EliminarInsumo()
        {
            InitializeComponent();
            try
            {
                DgvListadoEliminar.DataSource = datos.ListarInsumos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            datos.EliminarInsumos(txtInsumo.Text);
            MessageBox.Show("Insumo eliminado correctamente");
            try
            {
                DgvListadoEliminar.DataSource = datos.ListarInsumos();
                txtInsumo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarInsumo_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuInsumos frmMenuInsumos = new FrmMenuInsumos();
            frmMenuInsumos.Show();
        }
    }
}
