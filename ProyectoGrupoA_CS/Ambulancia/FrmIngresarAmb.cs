﻿using Data;
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
    public partial class FrmIngresarAmb : Form
    {
        Datos datos = new Datos();
        public FrmIngresarAmb()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.InsertarAmbulancia(int.Parse(txtCodigo.Text), txtMarca.Text, txtNumeroPlaca.Text, int.Parse(txtAño.Text), int.Parse(txtId.Text));
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
