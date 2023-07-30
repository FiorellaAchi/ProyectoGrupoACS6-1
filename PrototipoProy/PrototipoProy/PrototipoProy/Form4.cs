using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoProy
{
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }
        //muestra todos los usuarios en un datagridview
        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            dgvUsuarios.DataSource = db.ListarUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio Principal = new FormInicio();
            Principal.Show();
        }
    }
}
