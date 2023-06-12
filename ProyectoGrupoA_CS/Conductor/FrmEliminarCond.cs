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
            try
            {
                datos.EliminarConductor(int.Parse(txtId.Text));
            }
            catch(FormatException)
            {
                MessageBox.Show("El id debe ser un numero entero");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEliminarCond_Load(object sender, EventArgs e)
        {

        }
    }
}
