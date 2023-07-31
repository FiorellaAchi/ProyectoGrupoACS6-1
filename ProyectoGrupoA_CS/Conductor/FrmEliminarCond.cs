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
        Datos datos = new Datos(); //Se instancia la clase Datos con el objetivo de acceder a los metodos
        public FrmEliminarCond()
        {
            InitializeComponent();
            try
            {
                DGVListadoDeConductores.DataSource = datos.ListarConductores(); //Se listan a los conductores con el objetivo de mostrarlos en el DGV
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Se muestra un mensaje de error en caso de que ocurra una excepcion
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.EliminarConductor(int.Parse(txtId.Text)); //Se procede a utilizar el metodo con el ID correspondiente
            }
            catch(FormatException) //Se toma la excepcion en caso de problemas
            {
                MessageBox.Show("El id debe ser un numero entero");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                DGVListadoDeConductores.DataSource = datos.ListarConductores(); //Se muestra los datos actualizados en el data grid view
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
