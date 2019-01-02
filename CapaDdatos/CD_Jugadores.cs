using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDdatos
{
    public class CD_Jugadores
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable Mostrar(string Variable, string Modo)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarJugador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Variable", Variable);
            comando.Parameters.AddWithValue("@Modo", Modo);
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return Tabla;

        }
        public void insertarJugador(string Documento, int Equipo, string Nombre, string Apellido, int Peso, int Estatura, int Edad, bool Estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarJugador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Documento", Documento);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Estatura", Estatura);
            comando.Parameters.AddWithValue("@Edad", Edad);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.Parameters.AddWithValue("@Peso", Peso);
            comando.Parameters.AddWithValue("@Equipo", Equipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void insertarPosision(string Documento, int ps)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insert_Rel_Pos_Jug";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Posicion", ps);
            comando.Parameters.AddWithValue("@Documento", Documento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EditarJugador(string Documento, int Equipo, string Nombre, string Apellido, int Peso, int Estatura, int Edad, bool Estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Editar_Jugador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Documento", Documento);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Estatura", Estatura);
            comando.Parameters.AddWithValue("@Edad", Edad);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.Parameters.AddWithValue("@Peso", Peso);
            comando.Parameters.AddWithValue("@Equipo", Equipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EditarPosicion(string Documento, int ps)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Update_Rel_Pos_Jug";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Documento", Documento);
            comando.Parameters.AddWithValue("@Posicion", ps);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}