using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.Articulos;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class ActCompra : Form
    {
        public string cod;
        public string cdRef;
        public string prov;
        public string cuitProv;
        public string name;
        public ActCompra(string cb)
        {
            InitializeComponent();
            this.cod = cb;
            Conexion.Conectar();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActCompra_Load(object sender, EventArgs e)
        {

            llenar();
        }

        public void llenar()
        {
            ArticuloNegocio neg = new ArticuloNegocio();
            VArticulo art = neg.traerCompra(cod);

            if (art == null) return;


            cmb_prov.DataSource = ArticuloDatos.MostrarProvBox();
            cmb_prov.DisplayMember = "NombreCompleto";
            cmb_prov.ValueMember = "Cuit";
            cdRef = art.CodArt;
            name = art.Nombre;

            if (!string.IsNullOrEmpty(art.cuitProv))
            {
                cmb_prov.SelectedValue = art.cuitProv;
            }


            txt_costo.Text = art.Costo.ToString("N2");
            txt_desc.Text = art.Descuento.ToString();

            int cantidad = Convert.ToInt32(art.Cantidad);
            numeric_cantidad.Value = Math.Clamp(cantidad, (int)numeric_cantidad.Minimum, (int)numeric_cantidad.Maximum);
        }

        public void MostrarErrores(Resultado resultado)
        {
            foreach (var error in resultado.Errores)
            {
                switch (error.Campo)
                {

                    case "Proveedor":
                        errorProvider1.SetError(cmb_prov, error.Mensaje);
                        break;

                    case "Cantidad":
                        errorProvider1.SetError(numeric_cantidad, error.Mensaje);
                        break;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VArticulo art = CargarCampos();
           

            ArticuloNegocio neg = new ArticuloNegocio();
            Resultado resultado = neg.ValidarParaCompra(art);
            if (!resultado.EsValido)
            {
                MostrarErrores(resultado);
                return;
            }
            ArticuloDatos datos = new ArticuloDatos();
            datos.NodiArtCompletoH(art);
            datos.AltaHistoricoCompleto(art);
            txt_costo.Clear();
            txt_desc.Clear();
            cmb_prov.SelectedIndex = -1;
            numeric_cantidad.Value = 0;

            AvisosGlobales.AvisarCompraFinalizada();
            this.Close();

        }

        /*  private VArticulo CargarCampos()
        {

            string cta = cmb_categoria.SelectedValue?.ToString() ?? "";
            string cst = cmb_Subcate.SelectedValue?.ToString() ?? "";
            string prv = cmb_prov.SelectedValue?.ToString() ?? "";


            decimal.TryParse(txt_P_M.Text, out decimal pm);
            decimal.TryParse(txt_P_P.Text, out decimal costo);
            decimal.TryParse(txt_D_P.Text, out decimal desc);
            decimal.TryParse(txt_P_U.Text, out decimal precioUnit);
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

                Ganancia = (precioUnit - costo),
                Cantidad = (int)numeric_C_U.Value,
                CantMinMayor = (int)numeric_C_M.Value
            };



            Image img = pic_art.Image ?? Properties.Resources.M_M__1_;
            ar.Imagen = ImagenABytes(img);

            return ar;
        }
*/
        /*create table HCompra
(
IdHcompra int not null,
FechaAlta datetime default getdate(),
CodHCompra varchar(10) unique,
DNI varchar(8),
Cuit varchar(11),
SubTotal decimal(12,2),
Descuento decimal(12,2),
Total decimal(12,2),
primary key(IdHcompra),
foreign key(DNI) references Usuario(DNI),
foreign key(Cuit) references Proveedor (Cuit)
)

create table HCompraDetalle
(
IdHCompraDetalle int not null,
 CodHCDetalle varchar(10) unique not null,
 CodHCompra varchar(10),
 CodigoArticulo varchar(10),
 Descripcion varchar(100),
 PrecioUnitario decimal(12,2),
 Cantidad int,
 PrecioXCantidad decimal(12,2),
 primary key(IdHCompraDetalle),
 foreign key (CodHCompra) references HCompra(CodHCompra),
 foreign key (CodigoArticulo) references Articulo (CodigoArticulo)
 )*/
        private VArticulo CargarCampos()
        {
            string prv = cmb_prov.SelectedValue?.ToString() ?? "";
            decimal.TryParse(txt_costo.Text, out decimal costo);
            decimal.TryParse(txt_desc.Text, out decimal desc);
            VArticulo ar = new VArticulo
            {
                Costo = costo,
                cuitProv = prv,
                CodArt = cdRef,
                Nombre= name,
                Descuento = desc,
                Cantidad = (int)numeric_cantidad.Value,
                TipoMovimiento = "Alta de Compra",

                DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha dado de alta a una compra de: " + name + ")",

            };
            return ar;
        }
    }
}
