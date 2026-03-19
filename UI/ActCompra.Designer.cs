namespace MyM26.UI
{
    partial class ActCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActCompra));
            txt_costo = new TextBox();
            numeric_cantidad = new NumericUpDown();
            txt_desc = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            label_title = new Label();
            btn_salir = new Button();
            cmb_prov = new ComboBox();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numeric_cantidad).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txt_costo
            // 
            txt_costo.Location = new Point(18, 122);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(150, 23);
            txt_costo.TabIndex = 0;
            // 
            // numeric_cantidad
            // 
            numeric_cantidad.Location = new Point(18, 175);
            numeric_cantidad.Name = "numeric_cantidad";
            numeric_cantidad.Size = new Size(150, 23);
            numeric_cantidad.TabIndex = 1;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(18, 228);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(150, 23);
            txt_desc.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 104, 233);
            button1.CausesValidation = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 104, 233);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 104, 233);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 284);
            button1.Name = "button1";
            button1.Size = new Size(115, 30);
            button1.TabIndex = 3;
            button1.Text = "Actualizar compra";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 104);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Costo proveedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 157);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 210);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 7;
            label3.Text = "Descuento proveedor";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label_title);
            panel1.Controls.Add(btn_salir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 23);
            panel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(172, 3);
            button2.Name = "button2";
            button2.Size = new Size(15, 15);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(3, 3);
            label_title.Name = "label_title";
            label_title.Size = new Size(0, 15);
            label_title.TabIndex = 16;
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(345, 3);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(15, 15);
            btn_salir.TabIndex = 1;
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // cmb_prov
            // 
            cmb_prov.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_prov.FormattingEnabled = true;
            cmb_prov.Location = new Point(18, 66);
            cmb_prov.Name = "cmb_prov";
            cmb_prov.Size = new Size(150, 23);
            cmb_prov.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 48);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 10;
            label4.Text = "Proveedor";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ActCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(191, 331);
            Controls.Add(label4);
            Controls.Add(cmb_prov);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txt_desc);
            Controls.Add(numeric_cantidad);
            Controls.Add(txt_costo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActCompra";
            Text = "ActCompra";
            Load += ActCompra_Load;
            ((System.ComponentModel.ISupportInitialize)numeric_cantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_costo;
        private NumericUpDown numeric_cantidad;
        private TextBox txt_desc;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Label label_title;
        private Button btn_salir;
        private Button button2;
        private ComboBox cmb_prov;
        private Label label4;
        private ErrorProvider errorProvider1;
    }
}