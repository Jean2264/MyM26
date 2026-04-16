namespace MyM26.UI
{
    partial class Correo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correo));
            label1 = new Label();
            txt_correo = new TextBox();
            btn_verifi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 191);
            label1.Name = "label1";
            label1.Size = new Size(258, 56);
            label1.TabIndex = 0;
            label1.Text = "Por favor ingrese su correo\r\nelectronico para verificar";
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(65, 295);
            txt_correo.Margin = new Padding(3, 4, 3, 4);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(236, 27);
            txt_correo.TabIndex = 1;
            // 
            // btn_verifi
            // 
            btn_verifi.BackgroundImage = Properties.Resources.verde;
            btn_verifi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_verifi.FlatAppearance.BorderSize = 0;
            btn_verifi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_verifi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_verifi.FlatStyle = FlatStyle.Flat;
            btn_verifi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_verifi.ForeColor = Color.White;
            btn_verifi.Location = new Point(102, 460);
            btn_verifi.Margin = new Padding(3, 4, 3, 4);
            btn_verifi.Name = "btn_verifi";
            btn_verifi.Size = new Size(169, 53);
            btn_verifi.TabIndex = 2;
            btn_verifi.Text = "Verificar correo";
            btn_verifi.UseVisualStyleBackColor = true;
            // 
            // Correo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btn_verifi);
            Controls.Add(txt_correo);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Correo";
            Size = new Size(391, 679);
            Load += Correo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_correo;
        private Button btn_verifi;
    }
}
