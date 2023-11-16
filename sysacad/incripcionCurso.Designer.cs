namespace sysacad
{
    partial class incripcionCurso
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
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            legajo = new Label();
            groupBox1.SuspendLayout();
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
            label1.Location = new Point(263, 4);
            label1.Name = "label1";
            label1.Size = new Size(419, 37);
            label1.TabIndex = 2;
            label1.Text = "Inscripcion a cursos del legajo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(364, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 248);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de materia";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(94, 214);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 4;
            button1.Text = "Inscribirme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 178);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 7;
            label9.Text = "cuposmateria1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 161);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 6;
            label8.Text = "Cupos Maximos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 133);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 5;
            label7.Text = "descripcionmateria1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 116);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 4;
            label6.Text = "Descripcion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 90);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 3;
            label5.Text = "codigomateria1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 70);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 2;
            label4.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 43);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 1;
            label3.Text = "nombremateria1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // legajo
            // 
            legajo.Anchor = AnchorStyles.None;
            legajo.AutoSize = true;
            legajo.BackColor = Color.Transparent;
            legajo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            legajo.ForeColor = Color.White;
            legajo.ImageAlign = ContentAlignment.MiddleRight;
            legajo.Location = new Point(673, 4);
            legajo.Name = "legajo";
            legajo.Size = new Size(123, 37);
            legajo.TabIndex = 4;
            legajo.Text = "LEGAJO";
            // 
            // incripcionCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1060, 614);
            Controls.Add(legajo);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "incripcionCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "incripcionCurso";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label9;
        private Label legajo;
    }
}