using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace ProyectoGrupoA_CS
{
    public partial class MostrarFactura : Form
    {
        Datos datos = new Datos();
        public MostrarFactura()
        {
            InitializeComponent();
            DgvFacturas.DataSource = datos.ListarFactura();
        }



        private void BtnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Servicios servicios = new Servicios();
            servicios.Show();
        }

        
        public void LlenarFactura(int rowIndex)
        {
            DataGridViewRow selectedRow = DgvFacturas.Rows[rowIndex];
          
                lblFactura.Text = selectedRow.Cells["id_Factura"].Value.ToString();
                lblConductor.Text = selectedRow.Cells["nombre_conductor"].Value.ToString();
                lblIDConductor.Text = selectedRow.Cells["id_conductor"].Value.ToString();
                lblIdAmbulancia.Text = selectedRow.Cells["codigo_ambulancia"].Value.ToString();
                lblPlaca.Text = selectedRow.Cells["numero_placa"].Value.ToString();
                lblIDInsumo.Text = selectedRow.Cells["id_Insumos"].Value.ToString();
                lblInsumos.Text = selectedRow.Cells["insumo"].Value.ToString();
                lblIDServicio.Text = selectedRow.Cells["codigo_servicio"].Value.ToString();
                lblServicios.Text = selectedRow.Cells["nombre_servicio"].Value.ToString();
                lblDomicilio.Text = selectedRow.Cells["domicilio"].Value.ToString();
                lblDescripcion.Text = selectedRow.Cells["descripcion"].Value.ToString();
                lblEmision.Text = selectedRow.Cells["emision"].Value.ToString();
                lblSubtotal.Text = selectedRow.Cells["subtotal"].Value.ToString();
                lblTotal.Text = selectedRow.Cells["total"].Value.ToString();
                lblIDPaciente.Text = selectedRow.Cells["nombre"].Value.ToString();

        }

        private void MostrarFactura_Load(object sender, EventArgs e)
        {
            if (DgvFacturas.Rows.Count > 0)
            {
                int rowIndexToSelect = 0; // Índice de la fila que deseas seleccionar
                DgvFacturas.Rows[rowIndexToSelect].Selected = true;

                // Luego puedes llamar a la función para mostrar los datos de la fila seleccionada
                LlenarFactura(rowIndexToSelect);
            }

        }

        private void DgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvFacturas.SelectedRows.Count > 0)
            {
                int selectedRowIndex = DgvFacturas.SelectedRows[0].Index;
                LlenarFactura(selectedRowIndex);
            }
        }

        private void GenerarPDF(string outputPath)
        {
            Document doc = new Document();

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));
                doc.Open();

                // Agregar contenido al PDF
                doc.Add(new Paragraph($"Factura: {lblFactura.Text}"));
                doc.Add(new Paragraph($"Conductor: {lblConductor.Text}"));
                doc.Add(new Paragraph($"ID Conductor: {lblIDConductor.Text}"));
                doc.Add(new Paragraph($"ID Ambulancia: {lblIdAmbulancia.Text}"));
                doc.Add(new Paragraph($"Placa: {lblPlaca.Text}"));
                doc.Add(new Paragraph($"ID Insumo: {lblIDInsumo.Text}"));
                doc.Add(new Paragraph($"Insumo: {lblInsumos.Text}"));
                doc.Add(new Paragraph($"ID Servicio: {lblIDServicio.Text}"));
                doc.Add(new Paragraph($"Servicio: {lblServicios.Text}"));
                doc.Add(new Paragraph($"Domicilio: {lblDomicilio.Text}"));
                doc.Add(new Paragraph($"Descripción: {lblDescripcion.Text}"));
                doc.Add(new Paragraph($"Emisión: {lblEmision.Text}"));
                doc.Add(new Paragraph($"Subtotal: {lblSubtotal.Text}"));
                doc.Add(new Paragraph($"Total: {lblTotal.Text}"));
                doc.Add(new Paragraph($"ID Paciente: {lblIDPaciente.Text}"));

                doc.Close();

                MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGenerarFactura_Click(object sender, EventArgs e)
        {
            string baseFolderPath = @"C:\Users\Usuario\Desktop";
            string fileName = "Factura.pdf";
            string outputPath = Path.Combine(baseFolderPath, fileName);
            GenerarPDF(outputPath);
        }
    }
}
