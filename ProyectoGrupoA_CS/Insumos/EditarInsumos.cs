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
    public partial class EditarInsumos : Form
    {
        Datos datos = new Datos();
        public EditarInsumos()
        {
            InitializeComponent();
            try
            {
                DgvListadoEditar.DataSource = datos.ListarInsumos();
                DgvListadoEditar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvListadoEditar.CellClick += DgvListadoEditar_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string estado = cmbEstado.SelectedItem.ToString(); //Se obtiene el valor del combobox
                DateTime fechaSeleccionada = DTPFecha.Value; //Se obtiene la fecha seleccionada en el datepicker
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD
                datos.ActualizarInsumos(txtCodigoNew.Text, txtInsumo.Text, fechaFormateada, txtProveedor.Text, estado); //Se actualizan los datos en la base de datos
                MessageBox.Show("Insumo editado correctamente");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion"); //Se controlan las excepciones
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  //Se controlan las excepciones
            }

            
            DgvListadoEditar.DataSource = datos.ListarInsumos();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuInsumos frmMenuInsumos = new FrmMenuInsumos(); //Con el boton regresar se cierra el formulario actual y se abre el menu de insumos
            frmMenuInsumos.Show();
        }

        private void DgvListadoEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Se obtiene el indice de la fila seleccionada
            {
                DataGridViewRow row = this.DgvListadoEditar.Rows[e.RowIndex]; //Se obtiene la fila seleccionada
                txtCodigoNew.Text = row.Cells["id_Insumos"].Value.ToString(); //Se obtiene el valor de la columna Codigo de la fila seleccionada
                txtInsumo.Text = row.Cells["insumo"].Value.ToString(); //Se obtiene el valor de la columna Insumo de la fila seleccionada
                DTPFecha.Text = row.Cells["fecha"].Value.ToString(); //Se obtiene el valor de la columna FechaIngreso de la fila seleccionada
                txtProveedor.Text = row.Cells["proveedor"].Value.ToString(); //Se obtiene el valor de la columna Proveedor de la fila seleccionada
                cmbEstado.Text = row.Cells["estado"].Value.ToString(); //Se obtiene el valor de la columna Estado de la fila seleccionada
            }
            {

            }
        }
    }
}
