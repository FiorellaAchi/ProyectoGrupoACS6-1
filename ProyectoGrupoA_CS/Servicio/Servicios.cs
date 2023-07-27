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

namespace Servicio
{
    public partial class FrmServicios : Form
    {
        Datos datos = new Datos();
        String codigo;
        public FrmServicios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo=datos.InsertarServicio();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datos.EliminarServicio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
