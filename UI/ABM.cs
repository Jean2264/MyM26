using MyM26.Entidades.Articulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MyM26.Entidades.Comun;

using MyM26.Entidades.Usuario;
using MyM26.DAL;
using MyM26.BLL;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace MyM26.screens
{
    public partial class ABM : Form
    {
        public string Modo;
        public Articulos ar;
        public string cod;
        string cb;
        public ABM(Articulos aa)
        {
            InitializeComponent();
            Conexion.Conectar();
            ar = aa;
        }

        public ABM()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void AVM_Load(object sender, EventArgs e)
        {
            if (Modo == "Añadir")
            {
                label_Title.Text = "Añadir Artículo";
                btn_añadir.Text = "Añadir Artículo";

                Combos();


            }
            else if (Modo== "Añadir-Compra")
            {
                label_Title.Text = "Añadir Artículo";
                btn_añadir.Text = "Añadir Artículo";

                Combos();
            }
            else if (Modo == "Modificar")
            {
                label_Title.Text = "Modificar Artículo";
                btn_añadir.Text = "Modificar Artículo";
                pic_art.BackgroundImageLayout = ImageLayout.None;
                if (pic_art != null)
                {
                    pic_art.BackgroundImage = null;
                    pic_art.Image = null; // También limpiamos la imagen principal por las dudas
                }


                btn_buscar.Visible = true;
                txt_CodArt.ReadOnly = true;
                txt_CodArt.BackColor = Color.Gainsboro;
                txt_nombre.ReadOnly = true;
                txt_nombre.BackColor = Color.Gainsboro;
                txt_cb.ReadOnly = true;
                txt_cb.BackColor = Color.Gainsboro;


                cmb_categoria.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_Subcate.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_prov.DropDownStyle = ComboBoxStyle.DropDown;
                foreach (Control ctrl in this.Controls)
                {

                    if (ctrl is ComboBox)
                    {
                        ((ComboBox)ctrl).Enabled = false;
                        ((ComboBox)ctrl).BackColor = Color.White;
                        ((ComboBox)ctrl).ForeColor = Color.Black;
                    }
                }
                txt_P_P.ReadOnly = true;
                txt_P_P.BackColor = Color.Gainsboro;
                txt_D_P.ReadOnly = true;
                txt_D_P.BackColor = Color.Gainsboro;

                BuscarArt();
            }
            else
            {
                label_Title.Text = "Vista Artículo";
                pic_art.BackgroundImageLayout = ImageLayout.None;
                if (pic_art != null)
                {
                    pic_art.BackgroundImage = null;
                    pic_art.Image = null;
                }
                cmb_categoria.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_Subcate.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_prov.DropDownStyle = ComboBoxStyle.DropDown;

                BuscarArt();
                btn_añadir.Visible = false;
                btn_buscar.Visible = false;
                numeric_C_M.Enabled = false;
                numeric_C_U.Enabled = false;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ((TextBox)ctrl).Enabled = false;
                        ((TextBox)ctrl).BackColor = Color.White;
                    }
                    else if (ctrl is ComboBox)
                    {
                        ((ComboBox)ctrl).Enabled = false;
                        ((ComboBox)ctrl).BackColor = Color.White;
                        ((ComboBox)ctrl).ForeColor = Color.Black;
                    }
                }
                numeric_C_M.ReadOnly = true;

                numeric_C_U.ReadOnly = true;
                {

                }
            }
        }
        private void Combos()
        {
            //Para categoria
            cmb_categoria.DataSource = ArticuloDatos.MostrarCategoriaBox();
            cmb_categoria.DisplayMember = "Categoria";
            cmb_categoria.ValueMember = "CodCategoria";
            cmb_categoria.SelectedIndex = -1;



            //Para proveedor
            cmb_prov.DataSource = ArticuloDatos.MostrarProvBox();
            cmb_prov.DisplayMember = "NombreCompleto";
            cmb_prov.ValueMember = "Cuit";
            cmb_prov.SelectedIndex = -1;
        }
        private void btn_buscar_Click_1(object sender, EventArgs e)
        {

            /* using (OpenFileDialog abrir = new OpenFileDialog())
             {
                 abrir.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.webp";
                 abrir.Title = "Seleccionar imagen del producto";

                 if (abrir.ShowDialog() == DialogResult.OK)
                 {
                     try
                     {
                         // Leemos el archivo a un arreglo de bytes primero. 
                         // Esto evita que la "compu chica" bloquee el archivo.
                         byte[] datosImagen = System.IO.File.ReadAllBytes(abrir.FileName);

                         using (var ms = new System.IO.MemoryStream(datosImagen))
                         {
                             // Cargamos desde memoria
                             Image imgOriginal = Image.FromStream(ms);

                             // Asignamos al BackgroundImage como hiciste vos (que te funcionó mejor)
                             pic_art.Image = new Bitmap(imgOriginal);
                             pic_art.BackgroundImageLayout = ImageLayout.Stretch;
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("No se pudo procesar esta imagen específica.\n" +
                                         "Intenta abrirla con Paint y guardarla como PNG.\n\n" +
                                         "Error técnico: " + ex.Message,
                                         "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                 }
             }*/

            /*  OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Seleccione una imagen";
            abrir.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                //pic_usu_Buscar.Image = Image.FromFile(abrir.FileName);
                pic_usu_Buscar.BackgroundImage = Image.FromFile(abrir.FileName);
                pic_usu_Buscar.SizeMode = PictureBoxSizeMode.StretchImage;
            }*/

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Seleccione una imagen";
            abrir.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

            if(abrir.ShowDialog() == DialogResult.OK) 
             
            
            { 
                pic_art.Image= Image.FromFile(abrir.FileName);
                pic_art.BackgroundImage  = null;
                pic_art.SizeMode = PictureBoxSizeMode.StretchImage;
            
            }
        }

        //Para articulo

        public void BuscarArt()
        {

            ArticuloNegocio neg = new ArticuloNegocio();
            VArticulo art = neg.TomarInfo(cod);

            if (art == null)
            {
                return;
                this.Close();
            }


            txt_CodArt.Text = art.CodArt;
            txt_nombre.Text = art.Nombre;
            txt_cb.Text = art.CodigoBarra;
            cmb_categoria.Text = art.Categoria;
            cmb_Subcate.Text = art.Subcategoria;
            cmb_prov.Text = art.Prov;
            txt_P_U.Text = art.PrecioUnitario.ToString();
            int cantidad = Convert.ToInt32(art.Cantidad);
            int canTM = Convert.ToInt32(art.CantMinMayor);

            numeric_C_U.Value = Math.Min(numeric_C_U.Maximum, Math.Max(numeric_C_U.Minimum, cantidad));
            numeric_C_M.Value = Math.Min(numeric_C_M.Maximum, Math.Max(numeric_C_M.Minimum, canTM));
            txt_P_M.Text = art.PrecioXMayor.ToString();
            txt_P_P.Text = art.Costo.ToString();
            txt_D_P.Text = art.Descuento.ToString();

            if (art.Imagen != null)
            {
                using (MemoryStream ms = new MemoryStream(art.Imagen))
                {
                    pic_art.Image = Image.FromStream(ms);
                    pic_art.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        private VArticulo CargarCampos()
        {

            string cta = cmb_categoria.SelectedValue?.ToString() ?? "";
            string cst = cmb_Subcate.SelectedValue?.ToString() ?? "";
            string prv = cmb_prov.SelectedValue?.ToString() ?? "";


            decimal.TryParse(txt_P_M.Text, out decimal pm);
            decimal.TryParse(txt_P_P.Text, out decimal costo);
            decimal.TryParse(txt_D_P.Text, out decimal desc);
            decimal.TryParse(txt_P_U.Text, out decimal precioUnit);

            decimal costoParcial = (costo - desc);
            decimal Total = costoParcial * (int)numeric_C_U.Value;

            cb = txt_cb.Text;
            VArticulo ar = new VArticulo
            {
                Nombre = txt_nombre.Text.Trim(),
                CodigoBarra = txt_cb.Text.Trim(),
                CodCategoria = cta,
                CodSubcategoria = cst,
                cuitProv = prv,
                TipoMovimiento = "Alta de articulo",

                DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha dado de alta al articulo: " + txt_nombre.Text + ")",


                PrecioUnitario = precioUnit,
                Costo = costo,
                Descuento = desc,
                PrecioXMayor = pm,
                Detalle = "Compra" ,
                Monto =Total,
                Ganancia = (precioUnit - costo),
                Cantidad = (int)numeric_C_U.Value,
                CantMinMayor = (int)numeric_C_M.Value
            };



            Image img = pic_art.Image ?? Properties.Resources.M_M__1_;
            ar.Imagen = ImagenABytes(img);

            return ar;
        }

        private VArticulo CargarCampoModi()
        {
            decimal.TryParse(txt_P_M.Text, out decimal pm);
            decimal.TryParse(txt_P_U.Text, out decimal precioUnit);
            decimal.TryParse(txt_P_P.Text, out decimal costo);

            VArticulo art = new VArticulo
            {
                PrecioXMayor = pm,
                Costo = costo,
                PrecioUnitario = precioUnit,
                codArtRef = txt_CodArt.Text,
                Cantidad = (int)numeric_C_U.Value,
                CantMinMayor = (int)numeric_C_M.Value,
                TipoMovimiento = "modificación de articulo",

                DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha modificado la info del articulo: " + txt_nombre.Text + ")",
            };

            Image img = pic_art.Image ?? Properties.Resources.M_M__1_;
            art.Imagen = ImagenABytes(img);

            return art;
        }

        private byte[] ImagenABytes(Image imagen)
        {
            if (imagen == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            if (Modo == "Añadir")
            {
                VArticulo art = CargarCampos();
                string cb = txt_cb.Text;
                int EstadoCB = VerificarArt(cb);
                ArticuloDatos dt = new ArticuloDatos();
                //Existe Codigo de barra
                if (EstadoCB == 1)
                {
                    MessageBox.Show("Ya existe un articulo activo con ese codigo de barras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EstadoCB == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "El articulo existe pero esta dado de baja.\n ¿Desea reactivarlo?", "Reactivar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        dt.ReactivarArt(cb);
                        MessageBox.Show("Articulo reactivado correctamente.");
                        ar.LlenarArt();
                        this.Close();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }


                ArticuloNegocio neg = new ArticuloNegocio();
                Resultado resultado = neg.ValidarArticulo(art);
                if (!resultado.EsValido)
                {
                    MostrarErrores(resultado);
                    return;
                }

                ArticuloDatos dat = new ArticuloDatos();
                dat.AltaCompleto(art);
                limparCampos();
                ar.LlenarArt();
                dat.AltaHistoricoCompleto(art);
                dat.ALtaCompletoIntOutVarios(art);

                //Hola ola 
            }

            if (Modo == "Modificar")
            {
                VArticulo art = CargarCampoModi();

                ArticuloNegocio neg = new ArticuloNegocio();
                Resultado resultado = neg.validarModi(art);
                if (!resultado.EsValido)
                {
                    MostrarErrores(resultado);
                    return;
                }
                ArticuloDatos dt = new ArticuloDatos();
                dt.ModiCompleto(art);
                limparCampos();
                ar.LlenarArt();
                dt.AltaHistoricoCompleto(art);
                this.Close();


            }
            if(Modo == "Añadir-Compra")
            {
                VArticulo art = CargarCampos();
                string cb = txt_cb.Text;
                int EstadoCB = VerificarArt(cb);
                ArticuloDatos dt = new ArticuloDatos();
                //Existe Codigo de barra
                if (EstadoCB == 1)
                {
                    MessageBox.Show("Ya existe un articulo activo con ese codigo de barras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EstadoCB == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "El articulo existe pero esta dado de baja.\n ¿Desea reactivarlo?", "Reactivar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        dt.ReactivarArt(cb);
                        MessageBox.Show("Articulo reactivado correctamente.");
                        ar.LlenarArt();
                        this.Close();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }


                ArticuloNegocio neg = new ArticuloNegocio();
                Resultado resultado = neg.ValidarArticulo(art);
                if (!resultado.EsValido)
                {
                    MostrarErrores(resultado);
                    return;
                }

                ArticuloDatos dat = new ArticuloDatos();
                dat.AltaCompleto(art);
                limparCampos();
                
                dat.AltaHistoricoCompleto(art);
                AvisosGlobales.AvisarCompraFinalizada();
                this.Close();
            }
        }

        public void limparCampos()
        {
            txt_CodArt.Clear();
            txt_nombre.Clear();
            txt_cb.Clear();
            cmb_categoria.SelectedIndex = -1;
            cmb_Subcate.SelectedIndex = -1;
            cmb_prov.SelectedIndex = -1;
            txt_P_U.Clear();
            numeric_C_U.Value = 0;
            numeric_C_M.Value = 0;
            txt_P_M.Clear();
            txt_P_P.Clear();
            txt_D_P.Clear();
            pic_art.Image = null;
        }
        public void MostrarErrores(Resultado resultado)
        {
            foreach (var error in resultado.Errores)
            {
                switch (error.Campo)
                {
                    case "Nombre":
                        errorProvider1.SetError(txt_nombre, error.Mensaje);
                        break;
                    case "CodigoBarra":
                        errorProvider1.SetError(txt_cb, error.Mensaje);
                        break;
                    case "Categoria":
                        errorProvider1.SetError(cmb_categoria, error.Mensaje);
                        break;
                    case "Subcategoria":
                        errorProvider1.SetError(cmb_Subcate, error.Mensaje);
                        break;
                    case "Proveedor":
                        errorProvider1.SetError(cmb_prov, error.Mensaje);
                        break;
                    case "PU":
                        errorProvider1.SetError(txt_P_U, error.Mensaje);
                        break;
                    case "Cantidad":
                        errorProvider1.SetError(numeric_C_U, error.Mensaje);
                        break;

                }
            }
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_categoria.SelectedValue != null)
            {
                string cd = cmb_categoria.SelectedValue.ToString();

                //Para subcategoria
                cmb_Subcate.DataSource = ArticuloDatos.MostrarSubcategoriaBox(cd);
                cmb_Subcate.DisplayMember = "Subcategoria";
                cmb_Subcate.ValueMember = "CodSubcategoria";
                cmb_Subcate.SelectedIndex = -1;
            }
        }

        public int VerificarArt(string cb)
        {
            string consulta = "SELECT Estado FROM Articulo WHERE CodigoBarra = @cb";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@cb", cb);

                conn.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado == null)
                    return -1; // no existe

                return Convert.ToInt32(resultado); // devuelve 0 o 1
            }
        }

        private void txt_nombre_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            bool isALtgr = e.Control && e.Alt;
            if ((e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //bloquear ALtGr + Q
            if (e.Control && e.Alt && e.KeyCode == Keys.Q)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txt_nombre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void txt_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_cb_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txt_cb_KeyDown(object sender, KeyEventArgs e)
        {
            bool isALtgr = e.Control && e.Alt;
            if ((e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //bloquear ALtGr + Q
            if (e.Control && e.Alt && e.KeyCode == Keys.Q)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
