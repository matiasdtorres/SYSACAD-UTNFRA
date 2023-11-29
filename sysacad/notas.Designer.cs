namespace sysacad
{
    partial class notas
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
            usuarioescondidotxt = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            numeronotatxt = new ComboBox();
            label4 = new Label();
            estadonotatxt = new ComboBox();
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
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(392, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 3;
            label1.Text = "Cargar Notas";
            // 
            // usuarioescondidotxt
            // 
            usuarioescondidotxt.AutoSize = true;
            usuarioescondidotxt.ForeColor = Color.Black;
            usuarioescondidotxt.Location = new Point(446, 46);
            usuarioescondidotxt.Name = "usuarioescondidotxt";
            usuarioescondidotxt.Size = new Size(101, 15);
            usuarioescondidotxt.TabIndex = 4;
            usuarioescondidotxt.Text = "usuarioescondido";
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
            groupBox1.Text = "Notas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numeronotatxt);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(estadonotatxt);
            groupBox2.Controls.Add(btncargar);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(materiatxt);
            groupBox2.Controls.Add(alumnotxt);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(300, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 462);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(141, 231);
            label5.Name = "label5";
            label5.Size = new Size(113, 37);
            label5.TabIndex = 8;
            label5.Text = "Nota de";
            // 
            // numeronotatxt
            // 
            numeronotatxt.DropDownStyle = ComboBoxStyle.DropDownList;
            numeronotatxt.FormattingEnabled = true;
            numeronotatxt.Items.AddRange(new object[] { "parcial1", "recu1", "parcial2", "recu2", "notafinal" });
            numeronotatxt.Location = new Point(61, 271);
            numeronotatxt.Name = "numeronotatxt";
            numeronotatxt.Size = new Size(264, 23);
            numeronotatxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(144, 308);
            label4.Name = "label4";
            label4.Size = new Size(97, 37);
            label4.TabIndex = 6;
            label4.Text = "Estado";
            // 
            // estadonotatxt
            // 
            estadonotatxt.DropDownStyle = ComboBoxStyle.DropDownList;
            estadonotatxt.FormattingEnabled = true;
            estadonotatxt.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            estadonotatxt.Location = new Point(61, 348);
            estadonotatxt.Name = "estadonotatxt";
            estadonotatxt.Size = new Size(264, 23);
            estadonotatxt.TabIndex = 5;
            // 
            // btncargar
            // 
            btncargar.BackColor = Color.Black;
            btncargar.FlatStyle = FlatStyle.Flat;
            btncargar.Location = new Point(142, 407);
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
            label3.Location = new Point(142, 135);
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
            alumnotxt.Location = new Point(61, 175);
            alumnotxt.Name = "alumnotxt";
            alumnotxt.Size = new Size(264, 23);
            alumnotxt.TabIndex = 1;
            // 
            // notas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1060, 614);
            Controls.Add(groupBox1);
            Controls.Add(usuarioescondidotxt);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "notas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "notas";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label usuarioescondidotxt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private ComboBox numeronotatxt;
        private Label label4;
        private ComboBox estadonotatxt;
        private Button btncargar;
        private Label label3;
        private Label label2;
        private ComboBox materiatxt;
        private ComboBox alumnotxt;
    }
}