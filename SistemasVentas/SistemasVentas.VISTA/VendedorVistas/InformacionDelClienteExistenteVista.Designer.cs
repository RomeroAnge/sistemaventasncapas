namespace SistemasVentas.VISTA.VendedorVistas
{
    partial class InformacionDelClienteExistenteVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionDelClienteExistenteVista));
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.DialogResult = DialogResult.Cancel;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(491, 12);
            button1.Name = "button1";
            button1.Size = new Size(38, 35);
            button1.TabIndex = 74;
            button1.Text = "✕";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(11, 19, 46);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(491, 326);
            button3.Name = "button3";
            button3.Size = new Size(45, 45);
            button3.TabIndex = 73;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(460, 359);
            dataGridView1.TabIndex = 72;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.DialogResult = DialogResult.OK;
            button2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(491, 68);
            button2.Name = "button2";
            button2.Size = new Size(38, 35);
            button2.TabIndex = 75;
            button2.Text = "✓";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // InformacionDelClienteExistenteVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 393);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Name = "InformacionDelClienteExistenteVista";
            StartPosition = FormStartPosition.CenterScreen;
            Load += InformacionDelClienteExistenteVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button2;
    }
}