namespace MyM26.screens
{
    partial class TargetaUsuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetaUsuario));
            btn_editar = new Button();
            pic_usu = new PictureBox();
            lbl_nombre = new Label();
            lbl_tipo = new Label();
            lbl_dni = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_usu).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_editar
            // 
            btn_editar.BackgroundImage = (Image)resources.GetObject("btn_editar.BackgroundImage");
            btn_editar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.FlatAppearance.BorderSize = 0;
            btn_editar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_editar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Location = new Point(267, 16);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(34, 30);
            btn_editar.TabIndex = 4;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // pic_usu
            // 
            pic_usu.BackColor = Color.Transparent;
            pic_usu.BackgroundImageLayout = ImageLayout.Zoom;
            pic_usu.Location = new Point(13, 16);
            pic_usu.Name = "pic_usu";
            pic_usu.Size = new Size(80, 74);
            pic_usu.TabIndex = 6;
            pic_usu.TabStop = false;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre.ForeColor = Color.Black;
            lbl_nombre.Location = new Point(99, 16);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(0, 17);
            lbl_nombre.TabIndex = 7;
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tipo.ForeColor = Color.Black;
            lbl_tipo.Location = new Point(99, 61);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(0, 17);
            lbl_tipo.TabIndex = 9;
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dni.ForeColor = Color.Black;
            lbl_dni.Location = new Point(99, 40);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(0, 17);
            lbl_dni.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pic_usu);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(lbl_nombre);
            panel1.Controls.Add(lbl_tipo);
            panel1.Controls.Add(lbl_dni);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 107);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint_1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(267, 59);
            button1.Name = "button1";
            button1.Size = new Size(34, 30);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TargetaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "TargetaUsuario";
            Size = new Size(313, 107);
            Load += TargetaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pic_usu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_editar;
        public PictureBox pic_usu;
        public Label lbl_nombre;
        public Label lbl_tipo;
        public Label lbl_dni;
        private Panel panel1;
        private Button button1;
    }
}
