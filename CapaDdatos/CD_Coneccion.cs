using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDdatos
{
    public class CD_Conexion
    {
         private SqlConnection Conexion = new SqlConnection("Server=(Local);DataBase=Prospect Analizer;Integrated Security=true");
    
        public SqlConnection AbrirConexion()
        {
        if (Conexion.State == ConnectionState.Closed)
            Conexion.Open();
        return Conexion;
        }

         public SqlConnection CerrarConexion()
         {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
         }
}
}
