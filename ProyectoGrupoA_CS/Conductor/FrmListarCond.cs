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
    public partial class FrmListarCond : Form
    {
        Datos datos = new Datos();
        public FrmListarCond()
        {
            InitializeComponent();
            try
            {
                dataGridView1.DataSource = datos.ListarConductores(); //listar los conductores
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); //Muestra un mensaje en caso de hallar error
            }
           
        }

        private void FrmListarCond_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario
        }
    }
}
