namespace MyM26.UI
{
    partial class TargetaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetaArticulo));
            pictureBox1 = new PictureBox();
            lbl_nombre = new Label();
            lbl_precio = new Label();
            button1 = new Button();
            button2 = new Button();
            lbl_stock = new Label();
            lbl_pxm = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(39, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 94);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_nombre.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_nombre.Location = new Point(8, 111);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(58, 17);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_precio.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_precio.Location = new Point(8, 149);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(33, 17);
            lbl_precio.TabIndex = 2;
            lbl_precio.Text = "P/U:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.morado;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(75, 199);
            button1.Name = "button1";
            button1.Size = new Size(58, 23);
            button1.TabIndex = 3;
            button1.Text = "Editar articulo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.rojo;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(142, 199);
            button2.Name = "button2";
            button2.Size = new Size(58, 23);
            button2.TabIndex = 4;
            button2.Text = "Eliminar articulo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lbl_stock
            // 
            lbl_stock.AutoSize = true;
            lbl_stock.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_stock.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_stock.Location = new Point(8, 130);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(41, 17);
            lbl_stock.TabIndex = 5;
            lbl_stock.Text = "Stock";
            // 
            // lbl_pxm
            // 
            lbl_pxm.AutoSize = true;
            lbl_pxm.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_pxm.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_pxm.Location = new Point(8, 170);
            lbl_pxm.Name = "lbl_pxm";
            lbl_pxm.Size = new Size(36, 17);
            lbl_pxm.TabIndex = 6;
            lbl_pxm.Text = "P/M:";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.CheckedBackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(8, 199);
            button3.Name = "button3";
            button3.Size = new Size(58, 23);
            button3.TabIndex = 7;
            button3.Text = "Ver articulo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TargetaArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button3);
            Controls.Add(lbl_pxm);
            Controls.Add(lbl_stock);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_nombre);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "TargetaArticulo";
            Size = new Size(207, 237);
            Load += TargetaArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_nombre;
        private Label lbl_precio;
        private Button button1;
        private Button button2;
        private Label lbl_stock;
        private Label lbl_pxm;
        private Button button3;
    }
}
