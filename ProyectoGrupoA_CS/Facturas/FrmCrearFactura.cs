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
    public partial class FrmCrearFactura : Form
    {
        public FrmCrearFactura()
        {
            InitializeComponent();
        }

        Datos datos = new Datos();
        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSeleccionada = DTPEmision.Value;
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD
                datos.CrearFacturas(TxtCodigo.Text, TxtCedula.Text, TxtNombre.Text, fechaFormateada, TxtTelefono.Text, TxtDomicilio.Text, TxtDescripcion.Text);
                MessageBox.Show("Factura agregada correctamente");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TxtCedula.Clear();
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            TxtDomicilio.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
                       
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuFactura Menu = new FrmMenuFactura();
            Menu.Show();
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}