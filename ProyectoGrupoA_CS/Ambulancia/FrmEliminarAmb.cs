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

namespace Ambulancia
{
    public partial class FrmEliminarAmb : Form
    {
        Datos datos = new Datos();
        public FrmEliminarAmb()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.EliminarAmbulancia(int.Parse(txtCodigo.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("El codigo debe ser un numero entero");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
