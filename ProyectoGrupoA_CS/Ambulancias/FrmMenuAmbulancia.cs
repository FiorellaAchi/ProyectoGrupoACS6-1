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
    public partial class FrmMenuAmbulancia : Form
    {
        public FrmMenuAmbulancia()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); //Regresa al menu principal
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarAmbulancias frmRegistrarAmbulancias = new FrmRegistrarAmbulancias(); //Abre el formulario para registrar ambulancias
            frmRegistrarAmbulancias.Show(); //Muestra el formulario
            this.Hide(); //Oculta el formulario actual
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmActualizarAmbulancia frm = new FrmActualizarAmbulancia(); //Abre el formulario para actualizar ambulancias
            frm.Show(); //Muestra el formulario
            this.Hide(); //Oculta el formulario actual
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarAmbulancia frm = new FrmEliminarAmbulancia(); //Abre el formulario para eliminar ambulancias
            frm.Show(); //Muestra el formulario
            this.Hide(); //Oculta el formulario actual
        }
    }
}
