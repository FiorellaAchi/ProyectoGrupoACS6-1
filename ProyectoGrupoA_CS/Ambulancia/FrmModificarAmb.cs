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
    public partial class FrmModificarAmb : Form
    {
        Datos datos = new Datos();
        public FrmModificarAmb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos.ActualizarAmbulancia(int.Parse(txtCodigo.Text), txtMarca.Text, txtNumeroPlaca.Text, int.Parse(txtAño.Text), int.Parse(txtId.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
