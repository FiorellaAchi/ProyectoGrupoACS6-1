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
        Datos datos = new Datos(); //se instancia a la clase datos para poder utilizar sus metodos
        public FrmListarAmb()
        {
            InitializeComponent();
            try
            {
                dataGridView1.DataSource = datos.ListarAmbulancias(); //Aqui se utiliza un datagridview para mostrar los datos de la base de datos
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); //Aqui si presenta un error te lo indica
            }
            
        }

        private void FrmListarAmb_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //Esto cierra el formulario
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
