using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormConductor : Form
    {
        private CN_GetData dataManager;
        public FormConductor()
        {
            InitializeComponent();
            dataManager = new CN_GetData();
        }

        private void FormConductor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {// Obtener los datos de los campos de texto
            string nombre = textnombrecompleto.Text;
            string cedula = textcedula.Text;
            string celular = textnumerocelular.Text;
            string licencia = textlicencia.Text;
            string direccion = textdirecciondomiciliaria.Text;
            string unidadCargo = textunidadcargo.Text;
            int diasLaborados = int.Parse(textdiaslaborados.Text);
            // Obtener los datos de los campos de texto
            dataManager.GuardarConductor(nombre, cedula, celular, licencia, direccion, unidadCargo, diasLaborados);

            MessageBox.Show("Los datos del conductor se han guardado correctamente.");
        }

        private void buttonCerrarSesión_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarconductor_Click(object sender, EventArgs e)
        {

        }

        private void buttonListarconductores_Click(object sender, EventArgs e)
        {

        }

        private void buttonConsultarconductor_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarconductor_Click(object sender, EventArgs e)
        {

        }
    }
}
