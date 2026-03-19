using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using MyM26.DAL;
using MyM26.BLL;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyM26.UI
{
    public partial class Correo : UserControl
    {
        public event EventHandler CorreoValidado;
        public Correo()
        {
            InitializeComponent();
           
        }

        private void Correo_Load(object sender, EventArgs e)
        {

        }
    }
}
