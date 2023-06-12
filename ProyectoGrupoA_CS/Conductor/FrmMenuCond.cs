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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIngresarCond frmIngresarCond = new FrmIngresarCond();
            frmIngresarCond.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEliminarCond frmEliminarCond = new FrmEliminarCond();
            frmEliminarCond.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmListarCond frmListarCond = new FrmListarCond();
            frmListarCond.Show();
        }

        private void FrmMenuCond_Load(object sender, EventArgs e)
        {

        }

        public Button Button1 { get => button1; set => button1 = value; }
        public Button Button2 { get => button2; set => button2 = value; }
        public Button Button3 { get => button3; set => button3 = value; }
        public Button Button4 { get => button4; set => button4 = value; }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmModificarCond frm = new FrmModificarCond();
            frm.Show();
        }
    }
}
