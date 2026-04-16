using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using MyM26.Entidades;
using MyM26.Entidades.Usuario;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private async Task<bool> GuardarToken(string correo)
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

          return  await EnviarCorreo(correo, token);
        }




        public static async Task<bool> EnviarCorreo(string destino, String token)
        {
            try
            {
                MailMessage mes = new MailMessage();
                mes.From = new MailAddress("soportesjpd@gmail.com", "Soportesjpd");
                mes.To.Add(destino);
                mes.Subject = "Token de seguridad para recuperación de contraseña";
                mes.Body = $@"
                              <div style='font-family: Arial;'>
                                  <h2>Recuperación de contraseña</h2>
                                  <p>Tu código de verificación es:</p>
                                  <h1 style='color:#da1e1e;'>{token}</h1>
                                  <p>Este código expira en <b>10 minutos</b>.</p>
                              </div>";
                mes.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("soportesjpd@gmail.com", "kidu iami vkvw ulwg");

                smtp.EnableSsl = true;

                await smtp.SendMailAsync(mes);

                return true;

            }
            catch (Exception ex)
            {

                return false;
            }

        }

        private async void btn_verifi_Click(object sender, EventArgs e)
        {
            btn_verifi.Enabled = false; // Evitar múltiples clics
            if (!ValidarUser(txt_correo.Text))
            {
                MessageBox.Show("Correo no registrado o no es un administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          bool enviado = await GuardarToken(txt_correo.Text);
            if(enviado)
            {
                MessageBox.Show("Token enviado al correo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RecUser.correo = txt_correo.Text;
                //disparo el evento para que el padre sepa que el correo fue validado y pueda mostrar el siguiente paso
                CorreoValidado?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Error al enviar el correo. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_verifi.Enabled = true; // Rehabilitar el botón para intentar de nuevo
            }

          

          
           
           
        }
    }
}