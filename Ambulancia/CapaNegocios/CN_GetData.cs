using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_GetData
    {
        private CD_GetData objectCD = new CD_GetData();

        private DataTable CN_ShowData(String sql_Text)
        {
            DataTable myTable = new DataTable();
            myTable = objectCD.GetData(sql_Text);

            return myTable;
        }

        public DataTable ListarAmbulancia()
        {
            String sql_Text = "select * from ambulancia order by codigo";
            DataTable tablaRetorno = new DataTable();
            tablaRetorno = CN_ShowData(sql_Text);

            return tablaRetorno;
        }
        public void agregarAmbulancia(string codigo, string marca, string numero_placa, string anio, string id_conductor)
        {
            objectCD.AgregarAmbulancia(int.Parse(codigo),marca,numero_placa,int.Parse(anio),id_conductor);
        }

        public void ModificarAmbulancia(string codigo, string marca, string numero_placa, string anio, string id_conductor)
        {
            objectCD.ModificarAmbulancia(int.Parse(codigo), marca, numero_placa, int.Parse(anio), id_conductor);
        }

        public void EliminarAmbulancia(string codigo)
        {
            objectCD.EliminarAmbulancia(int.Parse(codigo));
        }

        

    }

}