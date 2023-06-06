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
    public partial class FrmMenuAmb : Form
    {
        public FrmMenuAmb()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIngresarAmb ingreso = new FrmIngresarAmb(); //Ingreso de datos 
            ingreso.Show();
        }

        private void ListarAmbulancias_Click(object sender, EventArgs e)
        {
            FrmListarAmb listar = new FrmListarAmb(); //Listar las ambulancias que hay en el sistema
            listar.Show();
        }

        private void ModificarAmbulancia_Click(object sender, EventArgs e)
        {
            FrmModificarAmb modificar = new FrmModificarAmb(); //Muestra el formulario de modificar los datos de las ambulancias
            modificar.Show();
        }

        private void EliminarDatosAmbulancia_Click(object sender, EventArgs e)
        {
            FrmEliminarAmb eliminar = new FrmEliminarAmb(); //Permite eliminar los datos de las ambulancias.
            eliminar.Show();
        }
    }
}
