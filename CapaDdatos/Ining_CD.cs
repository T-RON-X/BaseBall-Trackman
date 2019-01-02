using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDdatos
{
    public class Ining_CD
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable GuardarIning(int IningNumero, int TurnoID, int JugadaID, int CarreraH, int CarreraV)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarIning";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IningNumero", IningNumero);
            comando.Parameters.AddWithValue("@TurnoID", TurnoID);
            comando.Parameters.AddWithValue("@JugadaID", JugadaID);
            comando.Parameters.AddWithValue("@CarreraH", CarreraH);
            comando.Parameters.AddWithValue("@CarreraV", CarreraV);
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }
        

        public DataTable ReporteJuego(DateTime FechaDJuego)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ReporteJuegos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaDJuego", FechaDJuego);
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable RelacionJuegoIning(int IningID, int JuegoID, int JugadaID)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insertar_Rel_Juego_Ining";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IningID", IningID);
            comando.Parameters.AddWithValue("@JuegoID", JuegoID);
            comando.Parameters.AddWithValue("@JugadaID", JugadaID);
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }
    }
}
