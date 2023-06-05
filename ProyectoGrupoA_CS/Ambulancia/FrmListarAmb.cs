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
    public partial class FrmListarAmb : Form
    {
        Datos datos = new Datos();  
        public FrmListarAmb()
        {
            InitializeComponent();
            dataGridView1.DataSource = datos.ListarAmbulancias();
        }

        private void FrmListarAmb_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
