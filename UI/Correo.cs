using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using MyM26.DAL;
using MyM26.BLL;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;

namespace MyM26.UI
{
    public partial class Correo : UserControl
    {
        public event EventHandler CorreoValidado;
        public Correo()
        {
            InitializeComponent();
            Conexion.Conectar();

        }

        private void Correo_Load(object sender, EventArgs e)
        {

        }


        public bool ValidarUser(string correo)
        {
            using (SqlConnection cn = new SqlConnection(Decla.ConnectionString))
            {
                cn.Open();
                string consulta = @"
                                     SELECT COUNT(*) 
                                FROM Usuario s 
                                INNER JOIN TipoUsuario t ON s.CodTipoUsuario = t.CodTipoUsuario 
                                WHERE s.Mail = @Mail 
                                AND t.Tipo = 'Administrador' 
                                AND s.Estado = 1
                                    ";

                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Mail", correo);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        /*
        private bool ValidarUsuario(string correo)
        {
            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            {
                conn.Open();
                string consulta = @"
                                SELECT COUNT(*) 
                                FROM Usuario s 
                                INNER JOIN TipoUsuario t ON s.CodTipoUsuario = t.CodTipoUsuario 
                                WHERE s.Mail = @Mail 
                                AND t.Tipo = 'Administrador' 
                                AND s.Estado = 1";

                SqlCommand cmd = new SqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@Mail", correo);
                int count =Convert.ToInt32( cmd.ExecuteScalar());
                return count > 0;
            }
        }*/


        private string GenerarToken()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void GuardarToken(string correo)
        {
            string token = GenerarToken();
            DateTime expira = DateTime.Now.AddMinutes(10);
            using (SqlConnection cn = new SqlConnection(Decla.ConnectionString))
            {
                cn.Open();
                string consulta = @"
                                       UPDATE  s
                                       SET s.TokenRecuperacion = @token,
                                       s.TokenExpira = @expira
                                       FROM Usuario s
                                       INNER JOIN TipoUsuario t ON s.CodTipoUsuario = t.CodTipoUsuario
                                       WHERE s.Mail = @correo
                                       AND t.Tipo = 'Administrador'";
                SqlCommand comando = new SqlCommand(consulta, cn);
                comando.Parameters.AddWithValue("@token", token);
                comando.Parameters.AddWithValue("@expira", expira);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.ExecuteNonQuery();
            }
            /*  private void GuardarToken(string correo)
             
            
            {
                string token = GenerarToken();
                DateTime expira = DateTime.Now.AddMinutes(10);

                using (SqlConnection cn = new SqlConnection(Decla.cnn.ConnectionString))
                {
                    cn.Open();
                    /*@"UPDATE Usuario 
                                 SET TokenRecuperacion=@token, TokenExpira=@expira 
                                 WHERE Correo=@correo AND TipoUsuario='Administrador'";

            string consulta = @"UPDATE  s
                                       SET s.TokenRecuperacion = @token,
                                       s.TokenExpira = @expira
                                       FROM Usuario s
                                       INNER JOIN TipoUsuario t ON s.CodTipoUsuario = t.CodTipoUsuario
                                       WHERE s.Mail = @correo
                                       AND t.Tipo = 'Administrador'";
            SqlCommand comando = new SqlCommand(consulta, cn);
            comando.Parameters.AddWithValue("@token", token);
                    comando.Parameters.AddWithValue("@expira", expira);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.ExecuteNonQuery();
                }
                EnviarCorreo(correo, token);
        }*/
        }

        /*private void EnviarCorreo(string destino, string token)
        {
            MailMessage mail = new MailMessage("primesystemsoport25@gmail.com", destino);
            mail.Subject = "Recuperación de contraseña";
            mail.Body = $"Tu Token de recuperación es: {token}\n" +
                "Este Token expira en 10 minutos y solo puede usarse una sola vez.";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("primesystemsoport25@gmail.com", "huus luox wcyv bvxr");
            smtp.EnableSsl = true;
            */

        private void EnviarCorreo(string destino, String token)
        {

            //Cuenta: soportesjpd@gmail.com
           //APP pass:  oyo vtvh teaf nrza
            MailAddress mail = new MailAddress("soportesjpd@gmail.com", destino);
            
        }
    }
}