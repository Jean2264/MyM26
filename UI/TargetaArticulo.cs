using MyM26.BLL;
using MyM26.DAL;
using MyM26.DAL;
using MyM26.Entidades.Articulos;
using MyM26.Entidades.Usuario;
using MyM26.Querys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class TargetaArticulo : UserControl
    {

        public string codArt;
        public string nombre;
        public decimal pu;
        public decimal pm;
        public int cantidad;
        public event Action<string> EditarArt;
        public event Action<string> VistaArt;
        public event Action DatoEliminado;
        public TargetaArticulo()
        {
            InitializeComponent();
            Conexion.Conectar();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox1.Paint += (s, e) =>
            {
                using (Pen p = new Pen(Color.LightGray, 2)) // color y grosor
                {
                    e.Graphics.DrawRectangle(p, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
                }
            };
        }

        private void TargetaArticulo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cod = codArt;
            EditarArt?.Invoke(cod);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cod = codArt;
            VistaArt?.Invoke(cod);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cod = codArt;

            DialogResult reasultado = MessageBox.Show("¿Esta seguro de eliminar a este articulo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reasultado != DialogResult.Yes)
                return;

           
            ArticuloNegocio neg = new ArticuloNegocio();
            VArticulo art = neg.EliminarArt(cod);

            // Si el negocio falló y devolvió null, lo creamos aquí para que no de error
            if (art == null) art = new VArticulo { codArtRef = cod };

            // Verificamos que la sesión global exista
            if (UsuarioActivo.Datos == null)
            {
                MessageBox.Show("Sesión expirada");
                return;
            }

            art.TipoMovimiento = "Baja de articulo";

                art.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha dado de baja al articulo: " + lbl_nombre.Text + ")";

            ArticuloDatos dt = new ArticuloDatos();
            dt.AltaHistoricoCompleto(art);
            DatoEliminado?.Invoke();
           
           
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Foto
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }

        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Nombre
        {
            get { return codArt; }
            set
            {
                codArt = value; lbl_nombre.Text = codArt;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
                lbl_stock.Text = "Stock: " + value.ToString();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public decimal PU
        {
            get { return pu; }
            set
            {

                pu = value;
                lbl_precio.Text = "P.U: " + value.ToString();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public decimal PM
        {
            get { return pm; }
            set
            {
                pm = value;
                lbl_pxm.Text = "P.M: " + value.ToString();
            }
        }
    }
}
