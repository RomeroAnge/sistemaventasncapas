namespace SistemasVentas.VISTA.UsuarioVista
{
    partial class UsuarioInsertarVistas
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
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(367, 279);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 55;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 27);
            dateTimePicker1.TabIndex = 54;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 140);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(334, 27);
            textBox3.TabIndex = 53;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 147);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 52;
            label7.Text = "PASSWORD";
            // 
            // button2
            // 
            button2.Location = new Point(166, 279);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 51;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(520, 57);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 50;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 27);
            textBox2.TabIndex = 49;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 27);
            textBox1.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 184);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 47;
            label3.Text = "FECHA REGISTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 110);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 46;
            label2.Text = "NOMBRE USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 61);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 45;
            label1.Text = "PERSONA";
            // 
            // UsuarioInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 352);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioInsertarVistas";
            Text = "UsuarioInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Label label7;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}