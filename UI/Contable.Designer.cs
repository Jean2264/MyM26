namespace MyM26.UI
{
    partial class Contable
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tableLayoutPanel1 = new TableLayoutPanel();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            table_mes3 = new TableLayoutPanel();
            lblDic = new Label();
            lblNov = new Label();
            lblOct = new Label();
            lblSep = new Label();
            lblAg = new Label();
            lblJl = new Label();
            lblJn = new Label();
            lblMay = new Label();
            lblAbr = new Label();
            lblMar = new Label();
            lblFeb = new Label();
            lblEne = new Label();
            panel2 = new Panel();
            table_mes2 = new TableLayoutPanel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            table_mes1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            panel3.SuspendLayout();
            table_mes3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(chart3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(chart1, 0, 0);
            tableLayoutPanel1.Controls.Add(chart2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 224F));
            tableLayoutPanel1.Size = new Size(1148, 698);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea1);
            chart3.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart3.Legends.Add(legend1);
            chart3.Location = new Point(3, 477);
            chart3.Name = "chart3";
            chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            chart3.Series.Add(series1);
            chart3.Size = new Size(682, 218);
            chart3.TabIndex = 6;
            chart3.Text = "chart3";
            // 
            // panel3
            // 
            panel3.Controls.Add(table_mes3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(691, 477);
            panel3.Name = "panel3";
            panel3.Size = new Size(454, 218);
            panel3.TabIndex = 5;
            // 
            // table_mes3
            // 
            table_mes3.ColumnCount = 3;
            table_mes3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table_mes3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table_mes3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table_mes3.Controls.Add(lblDic, 2, 3);
            table_mes3.Controls.Add(lblNov, 1, 3);
            table_mes3.Controls.Add(lblOct, 0, 3);
            table_mes3.Controls.Add(lblSep, 2, 2);
            table_mes3.Controls.Add(lblAg, 1, 2);
            table_mes3.Controls.Add(lblJl, 0, 2);
            table_mes3.Controls.Add(lblJn, 2, 1);
            table_mes3.Controls.Add(lblMay, 1, 1);
            table_mes3.Controls.Add(lblAbr, 0, 1);
            table_mes3.Controls.Add(lblMar, 2, 0);
            table_mes3.Controls.Add(lblFeb, 1, 0);
            table_mes3.Controls.Add(lblEne, 0, 0);
            table_mes3.Dock = DockStyle.Fill;
            table_mes3.Location = new Point(0, 0);
            table_mes3.Name = "table_mes3";
            table_mes3.RowCount = 4;
            table_mes3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes3.Size = new Size(454, 218);
            table_mes3.TabIndex = 2;
            // 
            // lblDic
            // 
            lblDic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDic.AutoSize = true;
            lblDic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDic.Location = new Point(305, 197);
            lblDic.Name = "lblDic";
            lblDic.Size = new Size(146, 21);
            lblDic.TabIndex = 11;
            lblDic.Text = "label1";
            // 
            // lblNov
            // 
            lblNov.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNov.AutoSize = true;
            lblNov.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNov.Location = new Point(154, 197);
            lblNov.Name = "lblNov";
            lblNov.Size = new Size(145, 21);
            lblNov.TabIndex = 10;
            lblNov.Text = "label1";
            // 
            // lblOct
            // 
            lblOct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOct.AutoSize = true;
            lblOct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOct.Location = new Point(3, 197);
            lblOct.Name = "lblOct";
            lblOct.Size = new Size(145, 21);
            lblOct.TabIndex = 9;
            lblOct.Text = "label1";
            // 
            // lblSep
            // 
            lblSep.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSep.AutoSize = true;
            lblSep.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSep.Location = new Point(305, 141);
            lblSep.Name = "lblSep";
            lblSep.Size = new Size(146, 21);
            lblSep.TabIndex = 8;
            lblSep.Text = "label1";
            // 
            // lblAg
            // 
            lblAg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAg.AutoSize = true;
            lblAg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAg.Location = new Point(154, 141);
            lblAg.Name = "lblAg";
            lblAg.Size = new Size(145, 21);
            lblAg.TabIndex = 7;
            lblAg.Text = "label1";
            // 
            // lblJl
            // 
            lblJl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblJl.AutoSize = true;
            lblJl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJl.Location = new Point(3, 141);
            lblJl.Name = "lblJl";
            lblJl.Size = new Size(145, 21);
            lblJl.TabIndex = 6;
            lblJl.Text = "label1";
            // 
            // lblJn
            // 
            lblJn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblJn.AutoSize = true;
            lblJn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJn.Location = new Point(305, 87);
            lblJn.Name = "lblJn";
            lblJn.Size = new Size(146, 21);
            lblJn.TabIndex = 5;
            lblJn.Text = "label1";
            // 
            // lblMay
            // 
            lblMay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMay.AutoSize = true;
            lblMay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMay.Location = new Point(154, 87);
            lblMay.Name = "lblMay";
            lblMay.Size = new Size(145, 21);
            lblMay.TabIndex = 4;
            lblMay.Text = "label1";
            // 
            // lblAbr
            // 
            lblAbr.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAbr.AutoSize = true;
            lblAbr.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbr.Location = new Point(3, 87);
            lblAbr.Name = "lblAbr";
            lblAbr.Size = new Size(145, 21);
            lblAbr.TabIndex = 3;
            lblAbr.Text = "label1";
            // 
            // lblMar
            // 
            lblMar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMar.AutoSize = true;
            lblMar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMar.Location = new Point(305, 33);
            lblMar.Name = "lblMar";
            lblMar.Size = new Size(146, 21);
            lblMar.TabIndex = 2;
            lblMar.Text = "label1";
            // 
            // lblFeb
            // 
            lblFeb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFeb.AutoSize = true;
            lblFeb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeb.Location = new Point(154, 33);
            lblFeb.Name = "lblFeb";
            lblFeb.Size = new Size(145, 21);
            lblFeb.TabIndex = 1;
            lblFeb.Text = "label1";
            // 
            // lblEne
            // 
            lblEne.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEne.AutoSize = true;
            lblEne.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEne.Location = new Point(3, 33);
            lblEne.Name = "lblEne";
            lblEne.Size = new Size(145, 21);
            lblEne.TabIndex = 0;
            lblEne.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(table_mes2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(691, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 231);
            panel2.TabIndex = 4;
            // 
            // table_mes2
            // 
            table_mes2.ColumnCount = 3;
            table_mes2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table_mes2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table_mes2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table_mes2.Dock = DockStyle.Fill;
            table_mes2.Location = new Point(0, 0);
            table_mes2.Name = "table_mes2";
            table_mes2.RowCount = 4;
            table_mes2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes2.Size = new Size(454, 231);
            table_mes2.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            chart1.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(3, 3);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(682, 231);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea3);
            chart2.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chart2.Legends.Add(legend3);
            chart2.Location = new Point(3, 240);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart2.Series.Add(series3);
            chart2.Size = new Size(682, 231);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // panel1
            // 
            panel1.Controls.Add(table_mes1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(691, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 231);
            panel1.TabIndex = 3;
            // 
            // table_mes1
            // 
            table_mes1.ColumnCount = 3;
            table_mes1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table_mes1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table_mes1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table_mes1.Dock = DockStyle.Fill;
            table_mes1.Location = new Point(0, 0);
            table_mes1.Name = "table_mes1";
            table_mes1.RowCount = 4;
            table_mes1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            table_mes1.Size = new Size(454, 231);
            table_mes1.TabIndex = 2;
            // 
            // Contable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "Contable";
            Size = new Size(1148, 698);
            Load += Contable_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            panel3.ResumeLayout(false);
            table_mes3.ResumeLayout(false);
            table_mes3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Panel panel1;
        private Panel panel3;
        private TableLayoutPanel table_mes3;
        private Label lblEne;
        private TableLayoutPanel table_mes2;
        private TableLayoutPanel table_mes1;
        private Label lblDic;
        private Label lblNov;
        private Label lblOct;
        private Label lblSep;
        private Label lblAg;
        private Label lblJl;
        private Label lblJn;
        private Label lblMay;
        private Label lblAbr;
        private Label lblMar;
        private Label lblFeb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}
