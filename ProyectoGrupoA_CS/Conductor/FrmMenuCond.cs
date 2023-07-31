using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conductor
{
    public partial class FrmMenuCond : Form
    {
        public FrmMenuCond()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); //Regresa al menu principal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIngresarCond frmIngresarCond = new FrmIngresarCond(); //Crea una instancia del formulario FrmIngresarCond
            frmIngresarCond.Show(); //Para ingresar al mismo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEliminarCond frmEliminarCond = new FrmEliminarCond(); //Crea una instancia del formulario FrmEliminarCond
            frmEliminarCond.Show(); // Ingresar al mismo
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmListarCond frmListarCond = new FrmListarCond(); //Crea una instancia del formulario FrmListarCond
            frmListarCond.Show(); //Ingresar al mismo
        }

        private void FrmMenuCond_Load(object sender, EventArgs e)
        {

        }

        public Button Button1 { get => button1; set => button1 = value; } //Se crean los metodos get y set para los botones
        public Button Button2 { get => button2; set => button2 = value; }
        public Button Button3 { get => button3; set => button3 = value; }
        public Button Button4 { get => button4; set => button4 = value; }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmModificarCond frm = new FrmModificarCond(); //Crea una instancia del formulario FrmModificarCond
            frm.Show();
        }
    }
}
