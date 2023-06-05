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

namespace Conductor
{
    public partial class FrmEliminarCond : Form
    {
        Datos datos = new Datos();
        public FrmEliminarCond()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos.EliminarConductor(int.Parse(txtId.Text));
        }
    }
}
