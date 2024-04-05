namespace SistemasVentas.VISTA.VendedorVistas
{
    partial class InformacionDelClienteVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionDelClienteVista));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(119, 15);
            label1.Name = "label1";
            label1.Size = new Size(311, 27);
            label1.TabIndex = 4;
            label1.Text = "Información del Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 72);
            label2.Name = "label2";
            label2.Size = new Size(116, 27);
            label2.TabIndex = 5;
            label2.Text = "Persona:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(65, 113);
            label3.Name = "label3";
            label3.Size = new Size(77, 27);
            label3.TabIndex = 6;
            label3.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(39, 153);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 7;
            label4.Text = "Codigo:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(11, 19, 46);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(466, 65);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(11, 19, 46);
            button3.DialogResult = DialogResult.Cancel;
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(119, 207);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(104, 36);
            button3.TabIndex = 14;
            button3.Text = "Atrás";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(11, 19, 46);
            button4.DialogResult = DialogResult.OK;
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLight;
            button4.Location = new Point(322, 207);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(141, 36);
            button4.TabIndex = 15;
            button4.Text = "Continuar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(148, 153);
            label5.Name = "label5";
            label5.Size = new Size(0, 27);
            label5.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(148, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 34);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(148, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 34);
            textBox2.TabIndex = 16;
            // 
            // InformacionDelClienteVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 273);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InformacionDelClienteVista";
            StartPosition = FormStartPosition.CenterScreen;
            Load += InformacionDelClienteVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}