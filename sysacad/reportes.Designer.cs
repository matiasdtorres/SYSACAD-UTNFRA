namespace sysacad
{
    partial class reportes
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
            groupBox1 = new GroupBox();
            cursostxt = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btncurso = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            legajotxt = new TextBox();
            btnestudiante = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            legajopagostxt = new TextBox();
            btnpagos = new Button();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            label1.Location = new Point(441, 4);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 3;
            label1.Text = "Reportes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cursostxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btncurso);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 213);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estudiantes Inscriptos";
            // 
            // cursostxt
            // 
            cursostxt.DropDownStyle = ComboBoxStyle.DropDownList;
            cursostxt.FormattingEnabled = true;
            cursostxt.Location = new Point(6, 106);
            cursostxt.Name = "cursostxt";
            cursostxt.Size = new Size(194, 23);
            cursostxt.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 19);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 5;
            label2.Text = "Informe Estudiantes Inscriptos";
            // 
            // btncurso
            // 
            btncurso.BackColor = Color.Black;
            btncurso.FlatStyle = FlatStyle.Flat;
            btncurso.Location = new Point(217, 181);
            btncurso.Name = "btncurso";
            btncurso.Size = new Size(75, 26);
            btncurso.TabIndex = 5;
            btncurso.Text = "Descargar";
            btncurso.UseVisualStyleBackColor = false;
            btncurso.Click += btncurso_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(legajotxt);
            groupBox2.Controls.Add(btnestudiante);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(386, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 213);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Estudiante";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 36);
            label6.Name = "label6";
            label6.Size = new Size(167, 15);
            label6.TabIndex = 7;
            label6.Text = "de un estudiante en especifico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Legajo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 5;
            label5.Text = "Informe para obtener datos";
            // 
            // legajotxt
            // 
            legajotxt.Location = new Point(6, 106);
            legajotxt.Name = "legajotxt";
            legajotxt.Size = new Size(169, 23);
            legajotxt.TabIndex = 5;
            // 
            // btnestudiante
            // 
            btnestudiante.BackColor = Color.Black;
            btnestudiante.FlatStyle = FlatStyle.Flat;
            btnestudiante.Location = new Point(217, 181);
            btnestudiante.Name = "btnestudiante";
            btnestudiante.Size = new Size(75, 26);
            btnestudiante.TabIndex = 5;
            btnestudiante.Text = "Descargar";
            btnestudiante.UseVisualStyleBackColor = false;
            btnestudiante.Click += btnestudiante_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(legajopagostxt);
            groupBox3.Controls.Add(btnpagos);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(750, 198);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(298, 213);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pagos Estudiante";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 36);
            label7.Name = "label7";
            label7.Size = new Size(167, 15);
            label7.TabIndex = 7;
            label7.Text = "de un estudiante en especifico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 88);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 6;
            label8.Text = "Legajo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(180, 15);
            label9.TabIndex = 5;
            label9.Text = "Informe para consultar los pagos";
            // 
            // legajopagostxt
            // 
            legajopagostxt.Location = new Point(6, 106);
            legajopagostxt.Name = "legajopagostxt";
            legajopagostxt.Size = new Size(169, 23);
            legajopagostxt.TabIndex = 5;
            // 
            // btnpagos
            // 
            btnpagos.BackColor = Color.Black;
            btnpagos.FlatStyle = FlatStyle.Flat;
            btnpagos.Location = new Point(217, 181);
            btnpagos.Name = "btnpagos";
            btnpagos.Size = new Size(75, 26);
            btnpagos.TabIndex = 5;
            btnpagos.Text = "Descargar";
            btnpagos.UseVisualStyleBackColor = false;
            btnpagos.Click += btnpagos_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1, 36);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 9;
            label10.Text = "en curso especifico";
            // 
            // reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1060, 614);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "reportes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btncurso;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private TextBox legajotxt;
        private Button btnestudiante;
        private Label label6;
        private ComboBox cursostxt;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox legajopagostxt;
        private Button btnpagos;
        private Label label10;
    }
}