namespace SistemasVentas.VISTA.InventarioVistas
{
    partial class InventarioCategoriasVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioCategoriasVista));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button5 = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Eliminar = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 19, 46);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 70);
            panel1.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(11, 19, 46);
            button5.FlatAppearance.BorderColor = Color.FromArgb(11, 19, 46);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.icons8_menú_40;
            button5.Location = new Point(13, 13);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(53, 49);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(99, 25);
            label1.Name = "label1";
            label1.Size = new Size(142, 27);
            label1.TabIndex = 3;
            label1.Text = "Categorias";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 19, 46);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(577, 89);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(11, 19, 46);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(529, 89);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(32, 93);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar";
            textBox1.Size = new Size(491, 34);
            textBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 141);
            label2.Name = "label2";
            label2.Size = new Size(220, 27);
            label2.TabIndex = 17;
            label2.Text = "Lista Categorias";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(11, 19, 46);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(577, 188);
            button4.Name = "button4";
            button4.Size = new Size(51, 43);
            button4.TabIndex = 21;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(11, 19, 46);
            button3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(517, 188);
            button3.Name = "button3";
            button3.Size = new Size(45, 43);
            button3.TabIndex = 22;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Editar });
            dataGridView1.Location = new Point(32, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(479, 269);
            dataGridView1.TabIndex = 23;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Eliminar.DefaultCellStyle = dataGridViewCellStyle1;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 125;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            Editar.DefaultCellStyle = dataGridViewCellStyle2;
            Editar.HeaderText = "Editar";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Width = 125;
            // 
            // InventarioCategoriasVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 508);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InventarioCategoriasVista";
            StartPosition = FormStartPosition.CenterScreen;
            Load += InventarioCategoriasVista_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button5;
        private DataGridViewTextBoxColumn Eliminar;
        private DataGridViewImageColumn Editar;
    }
}