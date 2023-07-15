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
    public partial class FrmMenuInsumos : Form
    {
        public FrmMenuInsumos()
        {
            InitializeComponent();
        }

        private void BtnIngresarInsumos_Click(object sender, EventArgs e)
        {
            Form formulario = new CrearInsumos();
            Form formularioC = new FrmMenuInsumos();
            formulario.Show();
            formularioC.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
