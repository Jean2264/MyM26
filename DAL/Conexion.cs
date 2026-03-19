using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MyM26.DAL
{
   public static class Conexion
    {

        public static void Conectar()
        {
            Decla.ConnectionString = @"data source=localhost; initial catalog=MyM7;trusted_Connection=true;";
            Decla.cnn = new SqlConnection(Decla.ConnectionString);
        }
    }
}
