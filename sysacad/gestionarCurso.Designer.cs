﻿namespace sysacad
{
    partial class gestionarCurso
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            fechalimitetxt = new DateTimePicker();
            divcursotxt = new ComboBox();
            aulacursotxt = new ComboBox();
            profesorcursotxt = new ComboBox();
            turnocursotxt = new ComboBox();
            diacursotxt = new ComboBox();
            cuatricursotxt = new ComboBox();
            descripcioncursotxt = new TextBox();
            label22 = new Label();
            label10 = new Label();
            cuposcursotxt = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnregistrar = new Button();
            groupBox3 = new GroupBox();
            nombreeliminarcursotxt = new ComboBox();
            label24 = new Label();
            btneliminar = new Button();
            btneditar = new Button();
            groupBox2 = new GroupBox();
            label11 = new Label();
            fechalimiteeditartxt = new DateTimePicker();
            diveditarcursotxt = new ComboBox();
            aulaeditarcursotxt = new ComboBox();
            profesoreditarcursotxt = new ComboBox();
            turnoeditarcursotxt = new ComboBox();
            diaeditarcursotxt = new ComboBox();
            cuatrieditarcursotxt = new ComboBox();
            descripcioneditarcursotxt = new TextBox();
            label12 = new Label();
            label13 = new Label();
            cuposeditarcursotxt = new NumericUpDown();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            nombreeditarcursotxt = new TextBox();
            label23 = new Label();
            cursos = new DataGridView();
            nombrecursotxt = new ComboBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cuposcursotxt).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cuposeditarcursotxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursos).BeginInit();
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
            label1.Location = new Point(393, 4);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 1;
            label1.Text = "Gestionar Cursos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 46);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(nombrecursotxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(fechalimitetxt);
            groupBox1.Controls.Add(divcursotxt);
            groupBox1.Controls.Add(aulacursotxt);
            groupBox1.Controls.Add(profesorcursotxt);
            groupBox1.Controls.Add(turnocursotxt);
            groupBox1.Controls.Add(diacursotxt);
            groupBox1.Controls.Add(cuatricursotxt);
            groupBox1.Controls.Add(descripcioncursotxt);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cuposcursotxt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(13, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 416);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(63, 270);
            label3.Name = "label3";
            label3.Size = new Size(190, 21);
            label3.TabIndex = 37;
            label3.Text = "Fecha limite inscripciones:";
            // 
            // fechalimitetxt
            // 
            fechalimitetxt.Location = new Point(58, 294);
            fechalimitetxt.Name = "fechalimitetxt";
            fechalimitetxt.Size = new Size(200, 23);
            fechalimitetxt.TabIndex = 31;
            // 
            // divcursotxt
            // 
            divcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            divcursotxt.FormattingEnabled = true;
            divcursotxt.Items.AddRange(new object[] { "A", "B", "C", "D" });
            divcursotxt.Location = new Point(113, 144);
            divcursotxt.Name = "divcursotxt";
            divcursotxt.Size = new Size(178, 23);
            divcursotxt.TabIndex = 36;
            // 
            // aulacursotxt
            // 
            aulacursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            aulacursotxt.FormattingEnabled = true;
            aulacursotxt.Items.AddRange(new object[] { "300", "301", "302", "303", "304", "305", "306", "307", "308" });
            aulacursotxt.Location = new Point(114, 115);
            aulacursotxt.Name = "aulacursotxt";
            aulacursotxt.Size = new Size(178, 23);
            aulacursotxt.TabIndex = 35;
            // 
            // profesorcursotxt
            // 
            profesorcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            profesorcursotxt.FormattingEnabled = true;
            profesorcursotxt.Location = new Point(113, 57);
            profesorcursotxt.Name = "profesorcursotxt";
            profesorcursotxt.Size = new Size(178, 23);
            profesorcursotxt.TabIndex = 34;
            // 
            // turnocursotxt
            // 
            turnocursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            turnocursotxt.FormattingEnabled = true;
            turnocursotxt.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            turnocursotxt.Location = new Point(113, 203);
            turnocursotxt.Name = "turnocursotxt";
            turnocursotxt.Size = new Size(178, 23);
            turnocursotxt.TabIndex = 33;
            // 
            // diacursotxt
            // 
            diacursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            diacursotxt.FormattingEnabled = true;
            diacursotxt.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" });
            diacursotxt.Location = new Point(113, 174);
            diacursotxt.Name = "diacursotxt";
            diacursotxt.Size = new Size(178, 23);
            diacursotxt.TabIndex = 32;
            // 
            // cuatricursotxt
            // 
            cuatricursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            cuatricursotxt.FormattingEnabled = true;
            cuatricursotxt.Items.AddRange(new object[] { "1", "2" });
            cuatricursotxt.Location = new Point(113, 86);
            cuatricursotxt.Name = "cuatricursotxt";
            cuatricursotxt.Size = new Size(178, 23);
            cuatricursotxt.TabIndex = 31;
            // 
            // descripcioncursotxt
            // 
            descripcioncursotxt.BackColor = Color.White;
            descripcioncursotxt.ForeColor = Color.Black;
            descripcioncursotxt.Location = new Point(9, 351);
            descripcioncursotxt.Multiline = true;
            descripcioncursotxt.Name = "descripcioncursotxt";
            descripcioncursotxt.Size = new Size(282, 59);
            descripcioncursotxt.TabIndex = 24;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(9, 328);
            label22.Name = "label22";
            label22.Size = new Size(91, 21);
            label22.TabIndex = 23;
            label22.Text = "Descripcion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(9, 234);
            label10.Name = "label10";
            label10.Size = new Size(135, 21);
            label10.TabIndex = 20;
            label10.Text = "Cupos Disponible:";
            // 
            // cuposcursotxt
            // 
            cuposcursotxt.BackColor = Color.White;
            cuposcursotxt.ForeColor = Color.Black;
            cuposcursotxt.Location = new Point(173, 234);
            cuposcursotxt.Name = "cuposcursotxt";
            cuposcursotxt.Size = new Size(118, 23);
            cuposcursotxt.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(9, 203);
            label9.Name = "label9";
            label9.Size = new Size(51, 21);
            label9.TabIndex = 19;
            label9.Text = "Turno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(9, 176);
            label8.Name = "label8";
            label8.Size = new Size(33, 21);
            label8.TabIndex = 17;
            label8.Text = "Dia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(9, 147);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 15;
            label7.Text = "Division";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 116);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 12;
            label6.Text = "Aula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 87);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 11;
            label5.Text = "Cuatrimestre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 58);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 9;
            label4.Text = "Profesor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 28);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.Black;
            btnregistrar.FlatStyle = FlatStyle.Flat;
            btnregistrar.ForeColor = Color.White;
            btnregistrar.Location = new Point(127, 474);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(78, 27);
            btnregistrar.TabIndex = 4;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Black;
            groupBox3.Controls.Add(nombreeliminarcursotxt);
            groupBox3.Controls.Add(label24);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(347, 487);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(354, 83);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Curso";
            // 
            // nombreeliminarcursotxt
            // 
            nombreeliminarcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            nombreeliminarcursotxt.FormattingEnabled = true;
            nombreeliminarcursotxt.Location = new Point(138, 34);
            nombreeliminarcursotxt.Name = "nombreeliminarcursotxt";
            nombreeliminarcursotxt.Size = new Size(180, 23);
            nombreeliminarcursotxt.TabIndex = 31;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(35, 34);
            label24.Name = "label24";
            label24.Size = new Size(68, 21);
            label24.TabIndex = 25;
            label24.Text = "Nombre";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Black;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(485, 584);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(78, 27);
            btneliminar.TabIndex = 28;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Black;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.ForeColor = Color.White;
            btneditar.Location = new Point(857, 474);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(78, 27);
            btneditar.TabIndex = 29;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(fechalimiteeditartxt);
            groupBox2.Controls.Add(diveditarcursotxt);
            groupBox2.Controls.Add(aulaeditarcursotxt);
            groupBox2.Controls.Add(profesoreditarcursotxt);
            groupBox2.Controls.Add(turnoeditarcursotxt);
            groupBox2.Controls.Add(diaeditarcursotxt);
            groupBox2.Controls.Add(cuatrieditarcursotxt);
            groupBox2.Controls.Add(descripcioneditarcursotxt);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(cuposeditarcursotxt);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(nombreeditarcursotxt);
            groupBox2.Controls.Add(label23);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(743, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 416);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editar Curso";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(62, 270);
            label11.Name = "label11";
            label11.Size = new Size(190, 21);
            label11.TabIndex = 38;
            label11.Text = "Fecha limite inscripciones:";
            // 
            // fechalimiteeditartxt
            // 
            fechalimiteeditartxt.Location = new Point(57, 294);
            fechalimiteeditartxt.Name = "fechalimiteeditartxt";
            fechalimiteeditartxt.Size = new Size(200, 23);
            fechalimiteeditartxt.TabIndex = 37;
            // 
            // diveditarcursotxt
            // 
            diveditarcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            diveditarcursotxt.FormattingEnabled = true;
            diveditarcursotxt.Items.AddRange(new object[] { "A", "B", "C", "D" });
            diveditarcursotxt.Location = new Point(113, 144);
            diveditarcursotxt.Name = "diveditarcursotxt";
            diveditarcursotxt.Size = new Size(178, 23);
            diveditarcursotxt.TabIndex = 37;
            // 
            // aulaeditarcursotxt
            // 
            aulaeditarcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            aulaeditarcursotxt.FormattingEnabled = true;
            aulaeditarcursotxt.Items.AddRange(new object[] { "300", "301", "302", "303", "304", "305", "306", "307", "308" });
            aulaeditarcursotxt.Location = new Point(113, 116);
            aulaeditarcursotxt.Name = "aulaeditarcursotxt";
            aulaeditarcursotxt.Size = new Size(178, 23);
            aulaeditarcursotxt.TabIndex = 37;
            // 
            // profesoreditarcursotxt
            // 
            profesoreditarcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            profesoreditarcursotxt.FormattingEnabled = true;
            profesoreditarcursotxt.Location = new Point(113, 58);
            profesoreditarcursotxt.Name = "profesoreditarcursotxt";
            profesoreditarcursotxt.Size = new Size(178, 23);
            profesoreditarcursotxt.TabIndex = 35;
            // 
            // turnoeditarcursotxt
            // 
            turnoeditarcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            turnoeditarcursotxt.FormattingEnabled = true;
            turnoeditarcursotxt.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            turnoeditarcursotxt.Location = new Point(113, 203);
            turnoeditarcursotxt.Name = "turnoeditarcursotxt";
            turnoeditarcursotxt.Size = new Size(178, 23);
            turnoeditarcursotxt.TabIndex = 34;
            // 
            // diaeditarcursotxt
            // 
            diaeditarcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            diaeditarcursotxt.FormattingEnabled = true;
            diaeditarcursotxt.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" });
            diaeditarcursotxt.Location = new Point(113, 174);
            diaeditarcursotxt.Name = "diaeditarcursotxt";
            diaeditarcursotxt.Size = new Size(178, 23);
            diaeditarcursotxt.TabIndex = 34;
            // 
            // cuatrieditarcursotxt
            // 
            cuatrieditarcursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            cuatrieditarcursotxt.FormattingEnabled = true;
            cuatrieditarcursotxt.Items.AddRange(new object[] { "1", "2" });
            cuatrieditarcursotxt.Location = new Point(113, 87);
            cuatrieditarcursotxt.Name = "cuatrieditarcursotxt";
            cuatrieditarcursotxt.Size = new Size(178, 23);
            cuatrieditarcursotxt.TabIndex = 34;
            // 
            // descripcioneditarcursotxt
            // 
            descripcioneditarcursotxt.BackColor = Color.White;
            descripcioneditarcursotxt.ForeColor = Color.Black;
            descripcioneditarcursotxt.Location = new Point(9, 350);
            descripcioneditarcursotxt.Multiline = true;
            descripcioneditarcursotxt.Name = "descripcioneditarcursotxt";
            descripcioneditarcursotxt.Size = new Size(282, 60);
            descripcioneditarcursotxt.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(9, 327);
            label12.Name = "label12";
            label12.Size = new Size(91, 21);
            label12.TabIndex = 23;
            label12.Text = "Descripcion";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(9, 234);
            label13.Name = "label13";
            label13.Size = new Size(135, 21);
            label13.TabIndex = 20;
            label13.Text = "Cupos Disponible:";
            // 
            // cuposeditarcursotxt
            // 
            cuposeditarcursotxt.BackColor = Color.White;
            cuposeditarcursotxt.ForeColor = Color.Black;
            cuposeditarcursotxt.Location = new Point(173, 234);
            cuposeditarcursotxt.Name = "cuposeditarcursotxt";
            cuposeditarcursotxt.Size = new Size(118, 23);
            cuposeditarcursotxt.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(9, 203);
            label14.Name = "label14";
            label14.Size = new Size(51, 21);
            label14.TabIndex = 19;
            label14.Text = "Turno";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(9, 176);
            label15.Name = "label15";
            label15.Size = new Size(33, 21);
            label15.TabIndex = 17;
            label15.Text = "Dia";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(9, 147);
            label17.Name = "label17";
            label17.Size = new Size(66, 21);
            label17.TabIndex = 15;
            label17.Text = "Division";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(9, 116);
            label18.Name = "label18";
            label18.Size = new Size(41, 21);
            label18.TabIndex = 12;
            label18.Text = "Aula";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(9, 87);
            label19.Name = "label19";
            label19.Size = new Size(100, 21);
            label19.TabIndex = 11;
            label19.Text = "Cuatrimestre";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(9, 58);
            label20.Name = "label20";
            label20.Size = new Size(69, 21);
            label20.TabIndex = 9;
            label20.Text = "Profesor";
            // 
            // nombreeditarcursotxt
            // 
            nombreeditarcursotxt.BackColor = Color.LightGray;
            nombreeditarcursotxt.ForeColor = Color.Black;
            nombreeditarcursotxt.Location = new Point(113, 28);
            nombreeditarcursotxt.Name = "nombreeditarcursotxt";
            nombreeditarcursotxt.ReadOnly = true;
            nombreeditarcursotxt.Size = new Size(178, 23);
            nombreeditarcursotxt.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(9, 28);
            label23.Name = "label23";
            label23.Size = new Size(68, 21);
            label23.TabIndex = 4;
            label23.Text = "Nombre";
            // 
            // cursos
            // 
            cursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursos.Location = new Point(347, 62);
            cursos.Name = "cursos";
            cursos.ReadOnly = true;
            cursos.RowTemplate.Height = 25;
            cursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursos.Size = new Size(354, 406);
            cursos.TabIndex = 30;
            cursos.CellClick += cursos_CellClick;
            // 
            // nombrecursotxt
            // 
            nombrecursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            nombrecursotxt.FormattingEnabled = true;
            nombrecursotxt.Items.AddRange(new object[] { "Programacion 1", "Programacion 2", "Laboratorio 1", "Laboratorio 2", "Ingles 1", "Ingles 2", "Matematica 1", "Matematica 2" });
            nombrecursotxt.Location = new Point(113, 27);
            nombrecursotxt.Name = "nombrecursotxt";
            nombrecursotxt.Size = new Size(178, 23);
            nombrecursotxt.TabIndex = 38;
            // 
            // gestionarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1060, 614);
            Controls.Add(cursos);
            Controls.Add(groupBox2);
            Controls.Add(btneditar);
            Controls.Add(btneliminar);
            Controls.Add(groupBox3);
            Controls.Add(btnregistrar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "gestionarCurso";
            Load += gestionarCurso_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cuposcursotxt).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cuposeditarcursotxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label10;
        private NumericUpDown cuposcursotxt;
        private Button btnregistrar;
        private GroupBox groupBox3;
        private Label label24;
        private Button btneliminar;
        private Button btneditar;
        private TextBox descripcioncursotxt;
        private Label label22;
        private GroupBox groupBox2;
        private TextBox descripcioneditarcursotxt;
        private Label label12;
        private Label label13;
        private NumericUpDown cuposeditarcursotxt;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox nombreeditarcursotxt;
        private Label label23;
        private DataGridView cursos;
        private ComboBox cuatricursotxt;
        private ComboBox diacursotxt;
        private ComboBox turnocursotxt;
        private ComboBox cuatrieditarcursotxt;
        private ComboBox turnoeditarcursotxt;
        private ComboBox diaeditarcursotxt;
        private ComboBox profesorcursotxt;
        private ComboBox profesoreditarcursotxt;
        private ComboBox nombreeliminarcursotxt;
        private ComboBox divcursotxt;
        private ComboBox aulacursotxt;
        private ComboBox diveditarcursotxt;
        private ComboBox aulaeditarcursotxt;
        private DateTimePicker fechalimitetxt;
        private Label label3;
        private Label label11;
        private DateTimePicker fechalimiteeditartxt;
        private ComboBox nombrecursotxt;
    }
}