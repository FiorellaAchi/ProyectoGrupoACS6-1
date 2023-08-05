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

namespace ProyectoGrupoA_CS
{
    public partial class Servicios : Form
    {
        Datos datos = Datos.getObject();
        public Servicios()
        {
            InitializeComponent();
        }

        private void BtnEmergencia_Click(object sender, EventArgs e)
        {
            datos.InsertarServicio();
            MessageBox.Show("Emergencia Registrada");
            this.Hide();
            MostrarFactura frm = new MostrarFactura();
            frm.Show();
            
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void BtnEliminarCancelarServicio_Click(object sender, EventArgs e)
        {
            datos.EliminarServicio();
            MessageBox.Show("Servicio Eliminado");
        }

    }
}
