using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDdatos
{
    public class CD_Equipo
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;

        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEquipo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarEquipo(string Nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEquipo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void InsertarRela_Bateador_Turno(int IDJudador, int IDTurno)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarRela_Bateador_Turno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDJugador", IDJudador);
            comando.Parameters.AddWithValue("@IDTurno", IDTurno);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EditarEquipo(string Nombre, int ID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarEquipo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@ID", ID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
