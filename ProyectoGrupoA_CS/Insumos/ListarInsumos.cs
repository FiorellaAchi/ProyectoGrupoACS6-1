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
    public partial class ListarInsumos : Form
    {
        Data.Datos datos = new Datos();
        public ListarInsumos()
        {
            InitializeComponent();
            try
            {
                DgvListado.DataSource = datos.ListarInsumos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarInsumos_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formularioC = new FrmMenuInsumos();
            formularioC.Show();
        }
    }
}
