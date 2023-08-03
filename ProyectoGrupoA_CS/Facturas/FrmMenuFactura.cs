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
    public partial class FrmMenuFactura : Form
    {
        public FrmMenuFactura()
        {
            InitializeComponent();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FrmCrearFactura frm = new FrmCrearFactura(); //Nos lleva al formulario de crear factura
            frm.Show();
            this.Hide();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarFacturas listarFacturas = new ListarFacturas(); //Nos lleva al formulario de listar facturas
            listarFacturas.Show();
            this.Hide();
        }

        private void BtnEditarFactura_Click(object sender, EventArgs e)
        {
            FrmEditarFactura frmEditarFactura = new FrmEditarFactura(); //Nos lleva al formulario de editar facturas
            frmEditarFactura.Show();
            this.Hide();
        }

        private void BtnEliminarFactura_Click(object sender, EventArgs e)
        {
            EliminarFacturas eliminarFacturas = new EliminarFacturas(); //Nos lleva al formulario de eliminar facturas
            eliminarFacturas.Show();
            this.Hide();
        }
    }
}
