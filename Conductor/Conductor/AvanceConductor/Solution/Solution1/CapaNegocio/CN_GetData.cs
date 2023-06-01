using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_GetData
    {
        private CD_GetData dataManager;

        public CN_GetData()
        {
            dataManager = new CD_GetData();
        }
        // Método para guardar los datos de un conductor utilizando la capa de datos
        public void GuardarConductor(string nombre, string cedula, string celular, string licencia, string direccion, string unidadCargo, int diasLaborados)
        { // Llama al método GuardarConductor de la capa de datos
            dataManager.GuardarConductor(nombre, cedula, celular, licencia, direccion, unidadCargo, diasLaborados);
        }
    }
}


