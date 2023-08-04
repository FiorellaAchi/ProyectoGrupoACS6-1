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
    public partial class EliminarFacturas : Form
    {
        Datos datos = new Datos();
        public EliminarFacturas()
        {
            InitializeComponent();
            try
            {
                DGVListado.DataSource = datos.ListarFactura();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmMenuFactura menus = new FrmMenuFactura();
            menus.Show(); //Aqui regresamos al menu principal
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            datos.EliminarFactura(TxtCodigo.Text); //Aqui se elimina la factura seleccionada
            MessageBox.Show("Factura eliminada correctamente");
            try
            {
                DGVListado.DataSource = datos.ListarFactura(); //Tras eliminar la factura, se actualiza el DGV
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
