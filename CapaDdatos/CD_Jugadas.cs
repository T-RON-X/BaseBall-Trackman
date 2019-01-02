using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDdatos
{
    public class CD_Jugadas
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable GuardarJugadas(int NombreJugada, int BolaTrayectoria, int FuerzaBateo, bool Primera, bool Segunda, bool Tercera)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarJugada";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreJugada", NombreJugada);
            comando.Parameters.AddWithValue("@Trayectoria", BolaTrayectoria);
            comando.Parameters.AddWithValue("@FuerzaBateo", FuerzaBateo);
            comando.Parameters.AddWithValue("@Primera", Primera);
            comando.Parameters.AddWithValue("@Segunda", Segunda);
            comando.Parameters.AddWithValue("@Tercera", Tercera);
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable GuardarTurno(int IDPitcher, int Velocidad, int IDSwing, int IDStrikeZ, int IDCantado)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarTurno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDpitcher", IDPitcher);
            comando.Parameters.AddWithValue("@Velocidad", Velocidad);
            comando.Parameters.AddWithValue("@IDswing", IDSwing);
            comando.Parameters.AddWithValue("@IDStrikeZ", IDStrikeZ);
            comando.Parameters.AddWithValue("@IDcatado", IDCantado);
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable InsertarJuegos(DateTime Fecha)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarJuegos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void GuardarIning(int IDPitcher, int Velocidad, int IDSwing, int IDStrikeZ, int IDCantado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarTurno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDpitcher", IDPitcher);
            comando.Parameters.AddWithValue("@Velocidad", Velocidad);
            comando.Parameters.AddWithValue("@IDswing", IDSwing);
            comando.Parameters.AddWithValue("@IDStrikeZ", IDStrikeZ);
            comando.Parameters.AddWithValue("@IDcatado", IDCantado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
