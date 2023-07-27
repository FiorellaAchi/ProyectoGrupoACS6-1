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

namespace ProyectoGrupoA_CS
{
    public partial class ListServicios : Form
    {
        Datos datos = new Datos();
        public ListServicios()
        {
            InitializeComponent();
            try
            {
                dataGridView1.DataSource = datos.ListarServicios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListServicios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
