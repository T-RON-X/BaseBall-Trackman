using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDdatos
{
    public class CD_ComboBox
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable MostrarEquipos()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListaEquipos";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            conexion.CerrarConexion();
            return Tabla;

        }

        public DataTable MostrarPosicionJugador(string Equipo, string Posicion)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListaPosicionJugador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Equipo", Equipo);
            comando.Parameters.AddWithValue("@Posicion", Posicion);
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;

        }

        public DataTable MostrarTipoSwing()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarSwing";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;

        }

        public DataTable MostrarStrikeZone()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarStrikeZone";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable MostrarCantado()
        {
            DataTable Tabla1 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarCantado";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla1.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla1;
        }

        public DataTable MostrarJugada()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarJugada";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable MostrarTrayectoria()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarTrayectoria";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable MostrarPitch()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarPitch";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable BuscarBateador(string Equipo)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SelectBateador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Equipo", Equipo);
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;
        }

    }
}
