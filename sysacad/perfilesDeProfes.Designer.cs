namespace sysacad
{
    partial class perfilesDeProfes
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
            panelprofes = new DataGridView();
            groupBox2 = new GroupBox();
            emaileditartxt = new TextBox();
            label9 = new Label();
            especializacioneditartxt = new ComboBox();
            direccioneditartxt = new TextBox();
            label6 = new Label();
            label12 = new Label();
            telefonoeditartxt = new TextBox();
            label19 = new Label();
            label20 = new Label();
            apellidoeditartxt = new TextBox();
            nombreeditartxt = new TextBox();
            label21 = new Label();
            usuarioeditartxt = new TextBox();
            label23 = new Label();
            btneditar = new Button();
            btnasignar = new Button();
            groupBox3 = new GroupBox();
            asignarcursotxt = new ComboBox();
            elegirprofeparacursotxt = new ComboBox();
            label11 = new Label();
            label24 = new Label();
            btnregistrar = new Button();
            groupBox1 = new GroupBox();
            btncrearcontraseña = new Button();
            label13 = new Label();
            contraseñaTemporaltxt = new TextBox();
            emailtxt = new TextBox();
            label8 = new Label();
            direcciontxt = new TextBox();
            label7 = new Label();
            especializaciontxt = new ComboBox();
            telefonotxt = new TextBox();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            apellidotxt = new TextBox();
            nombretxt = new TextBox();
            label3 = new Label();
            usuariotxt = new TextBox();
            label2 = new Label();
            btneliminarprofe = new Button();
            groupBox4 = new GroupBox();
            elegirprofeeliminartxt = new ComboBox();
            label25 = new Label();
            ((System.ComponentModel.ISupportInitialize)panelprofes).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(308, 2);
            label1.Name = "label1";
            label1.Size = new Size(442, 37);
            label1.TabIndex = 5;
            label1.Text = "Gestionar Perfiles de Profesores";
            // 
            // panelprofes
            // 
            panelprofes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panelprofes.Location = new Point(346, 57);
            panelprofes.Name = "panelprofes";
            panelprofes.ReadOnly = true;
            panelprofes.RowTemplate.Height = 25;
            panelprofes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            panelprofes.Size = new Size(354, 386);
            panelprofes.TabIndex = 37;
            panelprofes.CellClick += panelprofes_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(emaileditartxt);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(especializacioneditartxt);
            groupBox2.Controls.Add(direccioneditartxt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(telefonoeditartxt);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(apellidoeditartxt);
            groupBox2.Controls.Add(nombreeditartxt);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(usuarioeditartxt);
            groupBox2.Controls.Add(label23);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(742, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 386);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editar Profesor";
            // 
            // emaileditartxt
            // 
            emaileditartxt.BackColor = Color.White;
            emaileditartxt.ForeColor = Color.Black;
            emaileditartxt.Location = new Point(113, 183);
            emaileditartxt.Name = "emaileditartxt";
            emaileditartxt.Size = new Size(178, 23);
            emaileditartxt.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(9, 182);
            label9.Name = "label9";
            label9.Size = new Size(48, 21);
            label9.TabIndex = 44;
            label9.Text = "Email";
            // 
            // especializacioneditartxt
            // 
            especializacioneditartxt.DropDownStyle = ComboBoxStyle.DropDownList;
            especializacioneditartxt.FormattingEnabled = true;
            especializacioneditartxt.Items.AddRange(new object[] { "Programacion", "Ingles", "Matematica", "Arquitectura y S.O" });
            especializacioneditartxt.Location = new Point(9, 269);
            especializacioneditartxt.Name = "especializacioneditartxt";
            especializacioneditartxt.Size = new Size(282, 23);
            especializacioneditartxt.TabIndex = 36;
            // 
            // direccioneditartxt
            // 
            direccioneditartxt.BackColor = Color.White;
            direccioneditartxt.ForeColor = Color.Black;
            direccioneditartxt.Location = new Point(113, 151);
            direccioneditartxt.Name = "direccioneditartxt";
            direccioneditartxt.Size = new Size(178, 23);
            direccioneditartxt.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(97, 234);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 35;
            label6.Text = "Especializacion";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(9, 150);
            label12.Name = "label12";
            label12.Size = new Size(75, 21);
            label12.TabIndex = 42;
            label12.Text = "Direccion";
            // 
            // telefonoeditartxt
            // 
            telefonoeditartxt.BackColor = Color.White;
            telefonoeditartxt.ForeColor = Color.Black;
            telefonoeditartxt.Location = new Point(113, 119);
            telefonoeditartxt.Name = "telefonoeditartxt";
            telefonoeditartxt.Size = new Size(178, 23);
            telefonoeditartxt.TabIndex = 35;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(9, 118);
            label19.Name = "label19";
            label19.Size = new Size(68, 21);
            label19.TabIndex = 11;
            label19.Text = "Telefono";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(9, 89);
            label20.Name = "label20";
            label20.Size = new Size(67, 21);
            label20.TabIndex = 9;
            label20.Text = "Apellido";
            // 
            // apellidoeditartxt
            // 
            apellidoeditartxt.BackColor = Color.White;
            apellidoeditartxt.ForeColor = Color.Black;
            apellidoeditartxt.Location = new Point(113, 89);
            apellidoeditartxt.Name = "apellidoeditartxt";
            apellidoeditartxt.Size = new Size(178, 23);
            apellidoeditartxt.TabIndex = 8;
            // 
            // nombreeditartxt
            // 
            nombreeditartxt.BackColor = Color.White;
            nombreeditartxt.ForeColor = Color.Black;
            nombreeditartxt.Location = new Point(113, 59);
            nombreeditartxt.Name = "nombreeditartxt";
            nombreeditartxt.Size = new Size(178, 23);
            nombreeditartxt.TabIndex = 7;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(9, 59);
            label21.Name = "label21";
            label21.Size = new Size(68, 21);
            label21.TabIndex = 6;
            label21.Text = "Nombre";
            // 
            // usuarioeditartxt
            // 
            usuarioeditartxt.BackColor = Color.White;
            usuarioeditartxt.ForeColor = Color.Black;
            usuarioeditartxt.Location = new Point(113, 28);
            usuarioeditartxt.Name = "usuarioeditartxt";
            usuarioeditartxt.Size = new Size(178, 23);
            usuarioeditartxt.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(9, 28);
            label23.Name = "label23";
            label23.Size = new Size(64, 21);
            label23.TabIndex = 4;
            label23.Text = "Usuario";
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Black;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.ForeColor = Color.White;
            btneditar.Location = new Point(855, 439);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(78, 27);
            btneditar.TabIndex = 36;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btnasignar
            // 
            btnasignar.BackColor = Color.Black;
            btnasignar.FlatStyle = FlatStyle.Flat;
            btnasignar.ForeColor = Color.White;
            btnasignar.Location = new Point(240, 567);
            btnasignar.Name = "btnasignar";
            btnasignar.Size = new Size(78, 27);
            btnasignar.TabIndex = 35;
            btnasignar.Text = "Asignar";
            btnasignar.UseVisualStyleBackColor = false;
            btnasignar.Click += btnasignar_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Black;
            groupBox3.Controls.Add(asignarcursotxt);
            groupBox3.Controls.Add(elegirprofeparacursotxt);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label24);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(102, 489);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(354, 77);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Asignar Curso a Profesor";
            // 
            // asignarcursotxt
            // 
            asignarcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            asignarcursotxt.FormattingEnabled = true;
            asignarcursotxt.Location = new Point(138, 48);
            asignarcursotxt.Name = "asignarcursotxt";
            asignarcursotxt.Size = new Size(178, 23);
            asignarcursotxt.TabIndex = 30;
            // 
            // elegirprofeparacursotxt
            // 
            elegirprofeparacursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            elegirprofeparacursotxt.FormattingEnabled = true;
            elegirprofeparacursotxt.Location = new Point(138, 21);
            elegirprofeparacursotxt.Name = "elegirprofeparacursotxt";
            elegirprofeparacursotxt.Size = new Size(178, 23);
            elegirprofeparacursotxt.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(42, 48);
            label11.Name = "label11";
            label11.Size = new Size(51, 21);
            label11.TabIndex = 27;
            label11.Text = "Curso";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(35, 19);
            label24.Name = "label24";
            label24.Size = new Size(69, 21);
            label24.TabIndex = 25;
            label24.Text = "Profesor";
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.Black;
            btnregistrar.FlatStyle = FlatStyle.Flat;
            btnregistrar.ForeColor = Color.White;
            btnregistrar.Location = new Point(126, 439);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(78, 27);
            btnregistrar.TabIndex = 32;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(btncrearcontraseña);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(contraseñaTemporaltxt);
            groupBox1.Controls.Add(emailtxt);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(direcciontxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(especializaciontxt);
            groupBox1.Controls.Add(telefonotxt);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(apellidotxt);
            groupBox1.Controls.Add(nombretxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(usuariotxt);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 386);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Profesor";
            // 
            // btncrearcontraseña
            // 
            btncrearcontraseña.FlatStyle = FlatStyle.Flat;
            btncrearcontraseña.ForeColor = Color.White;
            btncrearcontraseña.Location = new Point(123, 355);
            btncrearcontraseña.Name = "btncrearcontraseña";
            btncrearcontraseña.Size = new Size(63, 23);
            btncrearcontraseña.TabIndex = 44;
            btncrearcontraseña.Text = "Generar";
            btncrearcontraseña.UseVisualStyleBackColor = true;
            btncrearcontraseña.Click += btncrearcontraseña_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(65, 302);
            label13.Name = "label13";
            label13.Size = new Size(177, 21);
            label13.TabIndex = 43;
            label13.Text = "Contraseña Provisoria";
            // 
            // contraseñaTemporaltxt
            // 
            contraseñaTemporaltxt.BackColor = Color.Black;
            contraseñaTemporaltxt.ForeColor = Color.White;
            contraseñaTemporaltxt.Location = new Point(42, 326);
            contraseñaTemporaltxt.Name = "contraseñaTemporaltxt";
            contraseñaTemporaltxt.Size = new Size(217, 23);
            contraseñaTemporaltxt.TabIndex = 42;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = Color.White;
            emailtxt.ForeColor = Color.Black;
            emailtxt.Location = new Point(113, 182);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(178, 23);
            emailtxt.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(9, 181);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 40;
            label8.Text = "Email";
            // 
            // direcciontxt
            // 
            direcciontxt.BackColor = Color.White;
            direcciontxt.ForeColor = Color.Black;
            direcciontxt.Location = new Point(113, 150);
            direcciontxt.Name = "direcciontxt";
            direcciontxt.Size = new Size(178, 23);
            direcciontxt.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(9, 149);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 38;
            label7.Text = "Direccion";
            // 
            // especializaciontxt
            // 
            especializaciontxt.DropDownStyle = ComboBoxStyle.DropDownList;
            especializaciontxt.FormattingEnabled = true;
            especializaciontxt.Items.AddRange(new object[] { "Programacion", "Ingles", "Matematica", "Arquitectura y S.O" });
            especializaciontxt.Location = new Point(9, 269);
            especializaciontxt.Name = "especializaciontxt";
            especializaciontxt.Size = new Size(282, 23);
            especializaciontxt.TabIndex = 37;
            // 
            // telefonotxt
            // 
            telefonotxt.BackColor = Color.White;
            telefonotxt.ForeColor = Color.Black;
            telefonotxt.Location = new Point(113, 119);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(178, 23);
            telefonotxt.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(98, 234);
            label10.Name = "label10";
            label10.Size = new Size(113, 21);
            label10.TabIndex = 20;
            label10.Text = "Especializacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 118);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 11;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 89);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 9;
            label4.Text = "Apellido";
            // 
            // apellidotxt
            // 
            apellidotxt.BackColor = Color.White;
            apellidotxt.ForeColor = Color.Black;
            apellidotxt.Location = new Point(113, 89);
            apellidotxt.Name = "apellidotxt";
            apellidotxt.Size = new Size(178, 23);
            apellidotxt.TabIndex = 8;
            // 
            // nombretxt
            // 
            nombretxt.BackColor = Color.White;
            nombretxt.ForeColor = Color.Black;
            nombretxt.Location = new Point(113, 59);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(178, 23);
            nombretxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 59);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // usuariotxt
            // 
            usuariotxt.BackColor = Color.White;
            usuariotxt.ForeColor = Color.Black;
            usuariotxt.Location = new Point(113, 28);
            usuariotxt.Name = "usuariotxt";
            usuariotxt.Size = new Size(178, 23);
            usuariotxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 28);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // btneliminarprofe
            // 
            btneliminarprofe.BackColor = Color.Black;
            btneliminarprofe.FlatStyle = FlatStyle.Flat;
            btneliminarprofe.ForeColor = Color.White;
            btneliminarprofe.Location = new Point(731, 567);
            btneliminarprofe.Name = "btneliminarprofe";
            btneliminarprofe.Size = new Size(78, 27);
            btneliminarprofe.TabIndex = 37;
            btneliminarprofe.Text = "Eliminar";
            btneliminarprofe.UseVisualStyleBackColor = false;
            btneliminarprofe.Click += btneliminarprofe_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Black;
            groupBox4.Controls.Add(elegirprofeeliminartxt);
            groupBox4.Controls.Add(label25);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(593, 489);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(354, 77);
            groupBox4.TabIndex = 36;
            groupBox4.TabStop = false;
            groupBox4.Text = "Eliminar Profesor";
            // 
            // elegirprofeeliminartxt
            // 
            elegirprofeeliminartxt.DropDownStyle = ComboBoxStyle.DropDownList;
            elegirprofeeliminartxt.FormattingEnabled = true;
            elegirprofeeliminartxt.Location = new Point(138, 30);
            elegirprofeeliminartxt.Name = "elegirprofeeliminartxt";
            elegirprofeeliminartxt.Size = new Size(178, 23);
            elegirprofeeliminartxt.TabIndex = 30;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.White;
            label25.Location = new Point(35, 31);
            label25.Name = "label25";
            label25.Size = new Size(69, 21);
            label25.TabIndex = 25;
            label25.Text = "Profesor";
            // 
            // perfilesDeProfes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1060, 614);
            Controls.Add(btneliminarprofe);
            Controls.Add(panelprofes);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(btneditar);
            Controls.Add(btnasignar);
            Controls.Add(groupBox3);
            Controls.Add(btnregistrar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "perfilesDeProfes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "perfilesDeProfes";
            Load += perfilesDeProfes_Load;
            ((System.ComponentModel.ISupportInitialize)panelprofes).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView panelprofes;
        private GroupBox groupBox2;
        private TextBox usuarioeditartxt;
        private Label label23;
        private Button btneditar;
        private Button btnasignar;
        private GroupBox groupBox3;
        private Label label11;
        private Label label24;
        private Button btnregistrar;
        private GroupBox groupBox1;
        private Label label10;
        private TextBox usuariotxt;
        private Label label2;
        private Label label20;
        private TextBox apellidoeditartxt;
        private TextBox nombreeditartxt;
        private Label label21;
        private Label label4;
        private TextBox apellidotxt;
        private TextBox nombretxt;
        private Label label3;
        private Button btneliminarprofe;
        private GroupBox groupBox4;
        private Label label25;
        private ComboBox especializacioneditartxt;
        private Label label6;
        private TextBox telefonoeditartxt;
        private Label label19;
        private ComboBox especializaciontxt;
        private TextBox telefonotxt;
        private Label label5;
        private ComboBox asignarcursotxt;
        private ComboBox elegirprofeparacursotxt;
        private ComboBox elegirprofeeliminartxt;
        private TextBox emailtxt;
        private Label label8;
        private TextBox direcciontxt;
        private Label label7;
        private TextBox emaileditartxt;
        private Label label9;
        private TextBox direccioneditartxt;
        private Label label12;
        private Button btncrearcontraseña;
        private Label label13;
        private TextBox contraseñaTemporaltxt;
    }
}