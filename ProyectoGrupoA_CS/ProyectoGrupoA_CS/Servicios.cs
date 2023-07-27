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

namespace ProyectoGrupoA_CS
{
    public partial class frmServicios : Form
    {
        Datos datos = Datos.getObject();
        public frmServicios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos.InsertarServicio();
            MessageBox.Show("Emergencia Registrada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datos.EliminarServicio();
            MessageBox.Show("Servicio Eliminado");
        }
    }
}
