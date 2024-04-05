namespace SistemasVentas.VISTA.GerenteVistas
{
    partial class GerenteReporteVentasVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenteReporteVentasVista));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            vistaToolStripMenuItem = new ToolStripMenuItem();
            ordenarPorToolStripMenuItem = new ToolStripMenuItem();
            díaToolStripMenuItem = new ToolStripMenuItem();
            mesToolStripMenuItem = new ToolStripMenuItem();
            añoToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { vistaToolStripMenuItem });
            menuStrip1.Location = new Point(195, 448);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(119, 35);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // vistaToolStripMenuItem
            // 
            vistaToolStripMenuItem.BackColor = Color.Transparent;
            vistaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordenarPorToolStripMenuItem });
            vistaToolStripMenuItem.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vistaToolStripMenuItem.Image = (Image)resources.GetObject("vistaToolStripMenuItem.Image");
            vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            vistaToolStripMenuItem.Size = new Size(111, 31);
            vistaToolStripMenuItem.Text = "Vista";
            // 
            // ordenarPorToolStripMenuItem
            // 
            ordenarPorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { díaToolStripMenuItem, mesToolStripMenuItem, añoToolStripMenuItem });
            ordenarPorToolStripMenuItem.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordenarPorToolStripMenuItem.Image = (Image)resources.GetObject("ordenarPorToolStripMenuItem.Image");
            ordenarPorToolStripMenuItem.Name = "ordenarPorToolStripMenuItem";
            ordenarPorToolStripMenuItem.Size = new Size(228, 28);
            ordenarPorToolStripMenuItem.Text = "Ordenar Por:";
            // 
            // díaToolStripMenuItem
            // 
            díaToolStripMenuItem.Name = "díaToolStripMenuItem";
            díaToolStripMenuItem.Size = new Size(224, 28);
            díaToolStripMenuItem.Text = "Día";
            díaToolStripMenuItem.Click += díaToolStripMenuItem_Click;
            // 
            // mesToolStripMenuItem
            // 
            mesToolStripMenuItem.Name = "mesToolStripMenuItem";
            mesToolStripMenuItem.Size = new Size(224, 28);
            mesToolStripMenuItem.Text = "Mes";
            mesToolStripMenuItem.Click += mesToolStripMenuItem_Click;
            // 
            // añoToolStripMenuItem
            // 
            añoToolStripMenuItem.Name = "añoToolStripMenuItem";
            añoToolStripMenuItem.Size = new Size(224, 28);
            añoToolStripMenuItem.Text = "Año";
            añoToolStripMenuItem.Click += añoToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(11, 19, 46);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(575, 44);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(274, 51);
            label1.Name = "label1";
            label1.Size = new Size(25, 27);
            label1.TabIndex = 18;
            label1.Text = "a";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(316, 51);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(253, 27);
            dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(13, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(607, 376);
            dataGridView1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(233, 27);
            label2.TabIndex = 14;
            label2.Text = "Ventas Generales:";
            // 
            // GerenteReporteVentasVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 478);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GerenteReporteVentasVista";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem ordenarPorToolStripMenuItem;
        private ToolStripMenuItem díaToolStripMenuItem;
        private ToolStripMenuItem mesToolStripMenuItem;
        private ToolStripMenuItem añoToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem vistaToolStripMenuItem;
        private Button button2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label2;
    }
}