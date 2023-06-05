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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            
            formLogin Principal = new formLogin();
            Principal.Show(); //Lo mismo de abajo pero no utilizado
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            
            formLogin Principal = new formLogin();
            Principal.Show(); //Nos muestra la pestaña de acceso a edicion de cliente.
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra la pestaña principal
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            FrmMenuCond frm = new FrmMenuCond();
            frm.Show(); //Nos muestra la pestaña de acceso a edicion de conductor.
        }
    }
}
