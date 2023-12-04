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
            label3 = new Label();
            label2 = new Label();
            correlativatxt = new ComboBox();
            cursotxt = new ComboBox();
            btncargar = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            promediotxt = new ComboBox();
            cursopromediotxt = new ComboBox();
            btnpromedio = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            label1.Location = new Point(371, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 37);
            label1.TabIndex = 3;
            label1.Text = "Requisitos Academicos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(correlativatxt);
            groupBox1.Controls.Add(cursotxt);
            groupBox1.Controls.Add(btncargar);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(62, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 490);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Correlativa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 237);
            label3.Name = "label3";
            label3.Size = new Size(245, 37);
            label3.TabIndex = 4;
            label3.Text = "Eligir Correlitividad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 97);
            label2.Name = "label2";
            label2.Size = new Size(152, 37);
            label2.TabIndex = 3;
            label2.Text = "Eligir Curso";
            // 
            // correlativatxt
            // 
            correlativatxt.DropDownStyle = ComboBoxStyle.DropDownList;
            correlativatxt.FormattingEnabled = true;
            correlativatxt.Location = new Point(48, 277);
            correlativatxt.Name = "correlativatxt";
            correlativatxt.Size = new Size(232, 23);
            correlativatxt.TabIndex = 2;
            // 
            // cursotxt
            // 
            cursotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            cursotxt.FormattingEnabled = true;
            cursotxt.Location = new Point(48, 137);
            cursotxt.Name = "cursotxt";
            cursotxt.Size = new Size(232, 23);
            cursotxt.TabIndex = 1;
            // 
            // btncargar
            // 
            btncargar.BackColor = Color.Black;
            btncargar.FlatStyle = FlatStyle.Flat;
            btncargar.ForeColor = Color.White;
            btncargar.Location = new Point(102, 451);
            btncargar.Name = "btncargar";
            btncargar.Size = new Size(121, 33);
            btncargar.TabIndex = 0;
            btncargar.Text = "cargar";
            btncargar.UseVisualStyleBackColor = false;
            btncargar.Click += btncargar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(promediotxt);
            groupBox2.Controls.Add(cursopromediotxt);
            groupBox2.Controls.Add(btnpromedio);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(644, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 490);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Promedio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(64, 237);
            label4.Name = "label4";
            label4.Size = new Size(200, 37);
            label4.TabIndex = 4;
            label4.Text = "Eligir Promedio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(86, 97);
            label5.Name = "label5";
            label5.Size = new Size(152, 37);
            label5.TabIndex = 3;
            label5.Text = "Eligir Curso";
            // 
            // promediotxt
            // 
            promediotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            promediotxt.FormattingEnabled = true;
            promediotxt.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10" });
            promediotxt.Location = new Point(48, 277);
            promediotxt.Name = "promediotxt";
            promediotxt.Size = new Size(232, 23);
            promediotxt.TabIndex = 2;
            // 
            // cursopromediotxt
            // 
            cursopromediotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            cursopromediotxt.FormattingEnabled = true;
            cursopromediotxt.Location = new Point(48, 137);
            cursopromediotxt.Name = "cursopromediotxt";
            cursopromediotxt.Size = new Size(232, 23);
            cursopromediotxt.TabIndex = 1;
            // 
            // btnpromedio
            // 
            btnpromedio.BackColor = Color.Black;
            btnpromedio.FlatStyle = FlatStyle.Flat;
            btnpromedio.ForeColor = Color.White;
            btnpromedio.Location = new Point(102, 451);
            btnpromedio.Name = "btnpromedio";
            btnpromedio.Size = new Size(121, 33);
            btnpromedio.TabIndex = 0;
            btnpromedio.Text = "cargar";
            btnpromedio.UseVisualStyleBackColor = false;
            btnpromedio.Click += btnpromedio_Click;
            // 
            // requisitosAcademicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1060, 614);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "requisitosAcademicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "requisitosAcademicos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btncargar;
        private ComboBox cursotxt;
        private Label label3;
        private Label label2;
        private ComboBox correlativatxt;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private ComboBox promediotxt;
        private ComboBox cursopromediotxt;
        private Button btnpromedio;
    }
}