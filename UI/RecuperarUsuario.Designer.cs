namespace MyM26.UI
{
    partial class RecuperarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarUsuario));
            panel3 = new Panel();
            panel2 = new Panel();
            btn_salir = new Button();
            btn_mini = new Button();
            panelprincipal = new Panel();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(96, 624);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 61);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(127, 221);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 416);
            panel2.TabIndex = 9;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Transparent;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Zoom;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatAppearance.MouseDownBackColor = Color.FromArgb(215, 10, 60);
            btn_salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 10, 60);
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(1272, 1);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.RightToLeft = RightToLeft.No;
            btn_salir.Size = new Size(23, 43);
            btn_salir.TabIndex = 8;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_mini
            // 
            btn_mini.BackColor = Color.Transparent;
            btn_mini.BackgroundImage = (Image)resources.GetObject("btn_mini.BackgroundImage");
            btn_mini.BackgroundImageLayout = ImageLayout.Zoom;
            btn_mini.FlatAppearance.BorderSize = 0;
            btn_mini.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 82, 160);
            btn_mini.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 82, 160);
            btn_mini.FlatStyle = FlatStyle.Flat;
            btn_mini.Location = new Point(1243, 1);
            btn_mini.Margin = new Padding(3, 4, 3, 4);
            btn_mini.Name = "btn_mini";
            btn_mini.Size = new Size(23, 43);
            btn_mini.TabIndex = 7;
            btn_mini.UseVisualStyleBackColor = false;
            btn_mini.Click += btn_mini_Click;
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.Transparent;
            panelprincipal.BackgroundImageLayout = ImageLayout.Stretch;
            panelprincipal.Location = new Point(729, 139);
            panelprincipal.Margin = new Padding(3, 4, 3, 4);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(391, 679);
            panelprincipal.TabIndex = 11;
            panelprincipal.Paint += panelprincipal_Paint;
            // 
            // RecuperarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(115, 109, 244);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1312, 931);
            Controls.Add(panelprincipal);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btn_salir);
            Controls.Add(btn_mini);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecuperarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecuperarUsuario";
            Load += RecuperarUsuario_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Button btn_salir;
        private Button btn_mini;
        private Panel panelprincipal;
    }
}