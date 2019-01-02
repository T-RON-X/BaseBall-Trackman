using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDdatos
{
    class TurnoBateo_CDcs
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void GuardarJugadas(int TipoPitcheo, int StrikeZone, int Swing, int Cantado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarTurnoBateo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Pitcheo", TipoPitcheo);
            comando.Parameters.AddWithValue("@StrikeZone", StrikeZone);
            comando.Parameters.AddWithValue("@Swing", Swing);
            comando.Parameters.AddWithValue("@Cantado", Cantado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}
