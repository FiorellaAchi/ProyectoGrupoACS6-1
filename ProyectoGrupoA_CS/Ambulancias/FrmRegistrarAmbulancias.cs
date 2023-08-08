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

namespace Ambulancias
{
    public partial class FrmRegistrarAmbulancias : Form
    {
        Datos datos = new Datos();
        public FrmRegistrarAmbulancias()
        {
            InitializeComponent();
            DGVAmbulancias.DataSource = datos.ListarAmbulancias(); //Muestra los datos de la tabla en el DataGridView
        }

      

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); //Regresa al menu de ambulancias
            FrmMenuAmbulancia frmMenuAmbulancia = new FrmMenuAmbulancia(); //Abre el formulario del menu de ambulancias
            frmMenuAmbulancia.Show(); //Muestra el formulario
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {  
            try 
            {
                
                datos.InsertarAmbulancia(txtCodigo.Text, txtMarca.Text, txtNumeroPlaca.Text, txtAnio.Text, txtIdConductor.Text); //Inserta los datos en la base de datos
                DGVAmbulancias.DataSource = datos.ListarAmbulancias(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
