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

namespace Facturas
{
    public partial class EliminarFacturas : Form
    {
        Datos datos = new Datos();
        public EliminarFacturas()
        {
            InitializeComponent();
            try
            {
                DGVListado.DataSource = datos.ListarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmMenuFactura menus = new FrmMenuFactura();
            menus.Show();
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            datos.EliminarFacturas(TxtCodigo.Text);
            MessageBox.Show("Factura eliminada correctamente");
            try
            {
                DGVListado.DataSource = datos.ListarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }