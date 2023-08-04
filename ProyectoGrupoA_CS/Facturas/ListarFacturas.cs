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

namespace Facturas
{
    public partial class ListarFacturas : Form
    {
        Datos datos = new Datos();
        public ListarFacturas()
        {
            InitializeComponent();
            try
            {
                DGVListarFacturas.DataSource = datos.ListarFactura();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuFactura Menu = new FrmMenuFactura();
            Menu.Show();
        }
    }
}
