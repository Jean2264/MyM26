using Microsoft.VisualBasic.ApplicationServices;
using MyM26.Entidades.Usuario;
using MyM26.Querys;
using MyM26.screens;
using MyM26.UI;
namespace MyM26
{
    public partial class Principal : Form
    {
        bool isMaximized = false;
        public VUser _usuarioActual; // Variable para almacenar el usuario actual

        public string name;
        public string tipo;
        public byte[] foto;

        private List<Button> buttons;
        public Principal()
        {
            InitializeComponent();

            buttons = new List<Button> { btn_principal, btn_usurios, btn_art,
                btn_cajas, button6, button1, btn_ventas, btn_compras,btn_contables, button2 };
           
        }

        public Principal(VUser user)
        {
            InitializeComponent();
            buttons = new List<Button> { btn_principal, btn_usurios, btn_art,
                btn_cajas, button6, button1, btn_ventas, btn_compras,btn_contables, button2 };
            this._usuarioActual = user; // Asignar el usuario actual
        }

        private Button BotonActivo = null;

        private void ActivarBoton(Button btnActivo)
        {
            // Restaurar todos los botones
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.Transparent; // Color por defecto
                // Aquí podrías restaurar la imagen original si es necesario
            }
            // Activar solo el botón clickeado
            btnActivo.BackColor = Color.FromArgb(10, 75, 145);
            // Aquí podrías cambiar la imagen del botón si es necesario
            // Guardar el botón activo
            BotonActivo = btnActivo;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MostrarUserControl(UserControl uc)
        {
            panelprincipal.Controls.Clear(); // Limpiar lo que haya antes
            uc.Dock = DockStyle.Fill;        // Que ocupe todo el panel
            panelprincipal.Controls.Add(uc);
            panelprincipal.BackColor = this.BackColor; // mismo púrpura que el Form

            panelprincipal.Visible = true; // mostrar el panel
            uc.BringToFront();                // Traerlo al frente
        }

        private void btn_maxi_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                btn_maxi.Image = Properties.Resources.tNormal;
                btn_maxi.BackgroundImageLayout = ImageLayout.Stretch;

                isMaximized = false;
            }
            else
            {
                // Obtenemos el area de trabajo del monitor actual excluyendo a la barra de tareas
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

                this.WindowState = FormWindowState.Maximized;
                btn_maxi.Image = Properties.Resources.tMax;
                btn_maxi.BackgroundImageLayout = ImageLayout.Stretch;
                isMaximized = true;
            }
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_usurios_Click(object sender, EventArgs e)
        {
            Users uc = new Users();
            MostrarUserControl(uc);
            ActivarBoton(btn_usurios);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            

            lbl_name.Text = name;
            lbl_tipo.Text = tipo;
            if (foto!= null)
            {
                using (MemoryStream ms = new MemoryStream(foto))
                {
                    pcb_perfil.Image = Image.FromStream(ms);
                    pcb_perfil.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

      
            btn_art.Enabled = _usuarioActual.ProductosAC;
            btn_cajas.Enabled = _usuarioActual.CajasAc;
                button6.Enabled = _usuarioActual.ClientesAc;
                button1.Enabled = _usuarioActual.ProveedoresAc;
                btn_usurios.Enabled = _usuarioActual.UsuariosAc;
                btn_ventas.Enabled = _usuarioActual.VentasAc;
                btn_compras.Enabled = _usuarioActual.ComprasAc;
                btn_contables.Enabled =     _usuarioActual.ContableAc;
                button2.Enabled = _usuarioActual.EmpleadosAc;

            if(tipo== "Administrador")
            {
                btn_principal.Enabled = true;
            }
            else if( tipo != "Administrador")
            {
                btn_principal.Enabled = false;
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ClienteProveedor uc = new ClienteProveedor();
            uc.Modal = "Clientes";
            MostrarUserControl(uc);
            ActivarBoton(button6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteProveedor uc = new ClienteProveedor();
            uc.Modal = "Proveedor";
            MostrarUserControl(uc);
            ActivarBoton(button1);
        }

        private void btn_art_Click(object sender, EventArgs e)
        {
            Articulos uc = new Articulos();
            MostrarUserControl(uc);
            ActivarBoton(btn_art);
        }

        private void btn_cajas_Click(object sender, EventArgs e)
        {
            Caja cj = new Caja();
            MostrarUserControl(cj);
            ActivarBoton(btn_cajas);

        }

        private void btn_principal_Click(object sender, EventArgs e)
        {
            Home cj = new Home();
            MostrarUserControl (cj);
           
            ActivarBoton(btn_principal);
        }

        private void btn_contables_Click(object sender, EventArgs e)
        {
            Contable cj = new Contable();
            MostrarUserControl(cj);
            ActivarBoton(btn_contables);
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            Compras cj = new Compras();
            MostrarUserControl (cj);
            ActivarBoton(btn_compras);
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Ventas cj = new Ventas();
            MostrarUserControl(cj);
            ActivarBoton(btn_ventas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleados cj = new Empleados();
            MostrarUserControl(cj);
            ActivarBoton(button2);
        }

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
