using Ambulancia;
using Conductor;
using PrototipoProy;
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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {

            FormInicio Principal = new FormInicio();
            Principal.Show(); //Nos muestra la pestaña de acceso a edicion de cliente.
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            ListServicios frm = new ListServicios();
            frm.Show(); 
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            FrmMenuCond frm = new FrmMenuCond();
            frm.Show(); //Nos muestra la pestaña de acceso a edicion de conductor.
        }

        private void btnAmbulancia_Click(object sender, EventArgs e)
        {
            FrmMenuAmb frm = new FrmMenuAmb();
            frm.Show(); //Nos muestra la pestaña de acceso a edicion de ambulancia.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show(); //Nos muestra la ventana de acceso
            this.Close(); //Nos cierra la ventana actual
        }

        private void BtnInsumos_Click(object sender, EventArgs e)
        {

        }
    }
}
