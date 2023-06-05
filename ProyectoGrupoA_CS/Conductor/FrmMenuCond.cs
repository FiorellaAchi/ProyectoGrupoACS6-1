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
    }
}
