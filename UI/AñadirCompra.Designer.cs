namespace MyM26.UI
{
    partial class AñadirCompra
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirCompra));
            textBox1 = new TextBox();
            button1 = new Button();
            btn_salir = new Button();
            panel1 = new Panel();
            label_title = new Label();
            button2 = new Button();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 108);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 37);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.DragEnter += textBox1_DragEnter;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.MouseDown += textBox1_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 134, 233);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 134, 233);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 134, 233);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(67, 177);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(97, 31);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(215, 4);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(17, 20);
            btn_salir.TabIndex = 2;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label_title);
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 31);
            panel1.TabIndex = 3;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(3, 4);
            label_title.Name = "label_title";
            label_title.Size = new Size(0, 20);
            label_title.TabIndex = 16;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(394, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(17, 20);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 84);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingresar codigo de barras";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AñadirCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(235, 264);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AñadirCompra";
            Text = "AñadirCompra";
            Load += AñadirCompra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button btn_salir;
        private Panel panel1;
        private Label label_title;
        private Button button2;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}