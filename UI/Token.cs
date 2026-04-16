using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using MyM26.DAL;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class Token : UserControl
    {
        public event EventHandler TokenValidado;
        public Token()
        {
            InitializeComponent();
            Conexion.Conectar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Token_Load(object sender, EventArgs e)
        {
           
        }

        public bool validarToken(string correo, string tokenIngresado)
        {
            using (SqlConnection cn = new SqlConnection(Decla.ConnectionString))
            {
                cn.Open();

                string query = @"
            SELECT s.TokenRecuperacion, s.TokenExpira, s.Usuario 
            FROM Usuario s
            INNER JOIN TipoUsuario t ON s.CodTipoUsuario = t.CodTipoUsuario
            WHERE s.Mail = @correo
            AND t.Tipo = 'Administrador'";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@correo", correo);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string tokenDb = reader["TokenRecuperacion"]?.ToString().Trim();
                    DateTime expira = Convert.ToDateTime(reader["TokenExpira"]);

                    RecUser.usuario = reader["Usuario"].ToString();
                  
                    if (!string.IsNullOrEmpty(tokenDb) &&
                        tokenDb.Equals(tokenIngresado.Trim(), StringComparison.OrdinalIgnoreCase) &&
                        DateTime.Now <= expira)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void btn_verifi_Click(object sender, EventArgs e)
        {
            if (validarToken(RecUser.correo, txt_token.Text))
            {
               
                TokenValidado?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Token inválido o expirado. Por favor, intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
