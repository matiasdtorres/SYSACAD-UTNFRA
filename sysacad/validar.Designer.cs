namespace sysacad
{
    partial class validar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(validar));
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            asistenciastxt = new TextBox();
            profetxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            validartxt = new ComboBox();
            btncargar = new Button();
            label3 = new Label();
            label2 = new Label();
            materiatxt = new ComboBox();
            alumnotxt = new ComboBox();
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
            label1.Location = new Point(474, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 3;
            label1.Text = "Validar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(33, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(994, 490);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Asistencias";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(asistenciastxt);
            groupBox2.Controls.Add(profetxt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(validartxt);
            groupBox2.Controls.Add(btncargar);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(materiatxt);
            groupBox2.Controls.Add(alumnotxt);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(154, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(684, 462);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "-";
            // 
            // asistenciastxt
            // 
            asistenciastxt.Location = new Point(61, 272);
            asistenciastxt.Name = "asistenciastxt";
            asistenciastxt.ReadOnly = true;
            asistenciastxt.Size = new Size(569, 23);
            asistenciastxt.TabIndex = 12;
            // 
            // profetxt
            // 
            profetxt.Location = new Point(366, 72);
            profetxt.Name = "profetxt";
            profetxt.ReadOnly = true;
            profetxt.Size = new Size(264, 23);
            profetxt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(442, 32);
            label6.Name = "label6";
            label6.Size = new Size(115, 37);
            label6.TabIndex = 10;
            label6.Text = "Profesor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(266, 231);
            label5.Name = "label5";
            label5.Size = new Size(145, 37);
            label5.TabIndex = 8;
            label5.Text = "Asistencias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(289, 308);
            label4.Name = "label4";
            label4.Size = new Size(99, 37);
            label4.TabIndex = 6;
            label4.Text = "Validar";
            // 
            // validartxt
            // 
            validartxt.DropDownStyle = ComboBoxStyle.DropDownList;
            validartxt.FormattingEnabled = true;
            validartxt.Items.AddRange(new object[] { "VALIDADO", "CHEQUEAR" });
            validartxt.Location = new Point(200, 348);
            validartxt.Name = "validartxt";
            validartxt.Size = new Size(264, 23);
            validartxt.TabIndex = 5;
            // 
            // btncargar
            // 
            btncargar.BackColor = Color.Black;
            btncargar.FlatStyle = FlatStyle.Flat;
            btncargar.Location = new Point(283, 407);
            btncargar.Name = "btncargar";
            btncargar.Size = new Size(110, 36);
            btncargar.TabIndex = 4;
            btncargar.Text = "Cargar";
            btncargar.UseVisualStyleBackColor = false;
            btncargar.Click += btncargar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(282, 135);
            label3.Name = "label3";
            label3.Size = new Size(110, 37);
            label3.TabIndex = 3;
            label3.Text = "Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(156, 32);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 2;
            label2.Text = "Curso";
            // 
            // materiatxt
            // 
            materiatxt.DropDownStyle = ComboBoxStyle.DropDownList;
            materiatxt.FormattingEnabled = true;
            materiatxt.Location = new Point(61, 72);
            materiatxt.Name = "materiatxt";
            materiatxt.Size = new Size(264, 23);
            materiatxt.TabIndex = 0;
            // 
            // alumnotxt
            // 
            alumnotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            alumnotxt.FormattingEnabled = true;
            alumnotxt.Location = new Point(200, 175);
            alumnotxt.Name = "alumnotxt";
            alumnotxt.Size = new Size(264, 23);
            alumnotxt.TabIndex = 1;
            // 
            // validar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1060, 614);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "validar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "validar";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox asistenciastxt;
        private TextBox profetxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox validartxt;
        private Button btncargar;
        private Label label3;
        private Label label2;
        private ComboBox materiatxt;
        private ComboBox alumnotxt;
    }
}