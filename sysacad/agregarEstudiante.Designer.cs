namespace sysacad
{
    partial class agregarEstudiante
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
            label1 = new Label();
            nombretxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            direcciontxt = new TextBox();
            label5 = new Label();
            telefonotxt = new TextBox();
            label6 = new Label();
            apellidotxt = new TextBox();
            groupBox1 = new GroupBox();
            btncrearlegajo = new Button();
            legajotxt = new TextBox();
            label8 = new Label();
            btncrearcontraseña = new Button();
            label7 = new Label();
            contraseñaTemporaltxt = new TextBox();
            label2 = new Label();
            emailtxt = new TextBox();
            btnregistrar = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(361, 5);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 0;
            label1.Text = "Registrar Estudiante";
            // 
            // nombretxt
            // 
            nombretxt.BackColor = Color.Black;
            nombretxt.ForeColor = Color.White;
            nombretxt.Location = new Point(99, 34);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(217, 23);
            nombretxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 32);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 63);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 4;
            label4.Text = "Apellido";
            // 
            // direcciontxt
            // 
            direcciontxt.BackColor = Color.Black;
            direcciontxt.ForeColor = Color.White;
            direcciontxt.Location = new Point(99, 92);
            direcciontxt.Name = "direcciontxt";
            direcciontxt.Size = new Size(217, 23);
            direcciontxt.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 94);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 7;
            label5.Text = "Direccion";
            // 
            // telefonotxt
            // 
            telefonotxt.BackColor = Color.Black;
            telefonotxt.ForeColor = Color.White;
            telefonotxt.Location = new Point(99, 121);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(217, 23);
            telefonotxt.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 121);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 9;
            label6.Text = "Telefono";
            // 
            // apellidotxt
            // 
            apellidotxt.BackColor = Color.Black;
            apellidotxt.ForeColor = Color.White;
            apellidotxt.Location = new Point(99, 63);
            apellidotxt.Name = "apellidotxt";
            apellidotxt.Size = new Size(217, 23);
            apellidotxt.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(btncrearlegajo);
            groupBox1.Controls.Add(legajotxt);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btncrearcontraseña);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(contraseñaTemporaltxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(emailtxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(apellidotxt);
            groupBox1.Controls.Add(telefonotxt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(direcciontxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nombretxt);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(344, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 409);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion del estudiante";
            // 
            // btncrearlegajo
            // 
            btncrearlegajo.FlatStyle = FlatStyle.Flat;
            btncrearlegajo.ForeColor = Color.White;
            btncrearlegajo.Location = new Point(133, 355);
            btncrearlegajo.Name = "btncrearlegajo";
            btncrearlegajo.Size = new Size(63, 23);
            btncrearlegajo.TabIndex = 18;
            btncrearlegajo.Text = "Generar";
            btncrearlegajo.UseVisualStyleBackColor = true;
            btncrearlegajo.Click += btncrearlegajo_Click;
            // 
            // legajotxt
            // 
            legajotxt.BackColor = Color.Black;
            legajotxt.ForeColor = Color.White;
            legajotxt.Location = new Point(52, 326);
            legajotxt.Name = "legajotxt";
            legajotxt.Size = new Size(217, 23);
            legajotxt.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(123, 302);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 16;
            label8.Text = "N° Legajo";
            // 
            // btncrearcontraseña
            // 
            btncrearcontraseña.FlatStyle = FlatStyle.Flat;
            btncrearcontraseña.ForeColor = Color.White;
            btncrearcontraseña.Location = new Point(133, 251);
            btncrearcontraseña.Name = "btncrearcontraseña";
            btncrearcontraseña.Size = new Size(63, 23);
            btncrearcontraseña.TabIndex = 15;
            btncrearcontraseña.Text = "Generar";
            btncrearcontraseña.UseVisualStyleBackColor = true;
            btncrearcontraseña.Click += btncrearcontraseña_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(75, 198);
            label7.Name = "label7";
            label7.Size = new Size(177, 21);
            label7.TabIndex = 14;
            label7.Text = "Contraseña Provisoria";
            // 
            // contraseñaTemporaltxt
            // 
            contraseñaTemporaltxt.BackColor = Color.Black;
            contraseñaTemporaltxt.ForeColor = Color.White;
            contraseñaTemporaltxt.Location = new Point(52, 222);
            contraseñaTemporaltxt.Name = "contraseñaTemporaltxt";
            contraseñaTemporaltxt.Size = new Size(217, 23);
            contraseñaTemporaltxt.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 150);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // emailtxt
            // 
            emailtxt.BackColor = Color.Black;
            emailtxt.ForeColor = Color.White;
            emailtxt.Location = new Point(99, 150);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(217, 23);
            emailtxt.TabIndex = 11;
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.Black;
            btnregistrar.FlatStyle = FlatStyle.Flat;
            btnregistrar.ForeColor = Color.White;
            btnregistrar.Location = new Point(579, 497);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(93, 36);
            btnregistrar.TabIndex = 12;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 46);
            panel1.TabIndex = 13;
            // 
            // agregarEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1060, 614);
            Controls.Add(panel1);
            Controls.Add(btnregistrar);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "agregarEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "agregarEstudiante";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox nombretxt;
        private Label label3;
        private Label label4;
        private TextBox direcciontxt;
        private Label label5;
        private TextBox telefonotxt;
        private Label label6;
        private TextBox apellidotxt;
        private GroupBox groupBox1;
        private Button btnregistrar;
        private Panel panel1;
        private TextBox emailtxt;
        private Label label2;
        private Label label7;
        private TextBox contraseñaTemporaltxt;
        private Button btncrearcontraseña;
        private Button btncrearlegajo;
        private TextBox legajotxt;
        private Label label8;
    }
}