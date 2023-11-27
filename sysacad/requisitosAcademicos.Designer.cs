namespace sysacad
{
    partial class requisitosAcademicos
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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            label1.Location = new Point(351, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 37);
            label1.TabIndex = 3;
            label1.Text = "Requisitos Academicos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 490);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cursos pre-requisitos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(369, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 490);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nivel de creditos acumulados";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(718, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(333, 490);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Promedio academico";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(102, 451);
            button1.Name = "button1";
            button1.Size = new Size(121, 33);
            button1.TabIndex = 0;
            button1.Text = "cargar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(108, 451);
            button2.Name = "button2";
            button2.Size = new Size(121, 33);
            button2.TabIndex = 1;
            button2.Text = "cargar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(109, 451);
            button3.Name = "button3";
            button3.Size = new Size(121, 33);
            button3.TabIndex = 2;
            button3.Text = "cargar";
            button3.UseVisualStyleBackColor = false;
            // 
            // requisitosAcademicos
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
            Name = "requisitosAcademicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "requisitosAcademicos";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}