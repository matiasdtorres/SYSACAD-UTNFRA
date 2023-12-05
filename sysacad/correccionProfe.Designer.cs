namespace sysacad
{
    partial class correccionProfe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(correccionProfe));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            notatxt = new ComboBox();
            btncargar = new Button();
            label3 = new Label();
            label2 = new Label();
            profetxt = new ComboBox();
            alumnotxt = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(27, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(994, 490);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Notas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(notatxt);
            groupBox2.Controls.Add(btncargar);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(profetxt);
            groupBox2.Controls.Add(alumnotxt);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(318, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 462);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cargar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(159, 231);
            label5.Name = "label5";
            label5.Size = new Size(76, 37);
            label5.TabIndex = 8;
            label5.Text = "Nota";
            // 
            // notatxt
            // 
            notatxt.DropDownStyle = ComboBoxStyle.DropDownList;
            notatxt.FormattingEnabled = true;
            notatxt.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "messi" });
            notatxt.Location = new Point(61, 271);
            notatxt.Name = "notatxt";
            notatxt.Size = new Size(264, 23);
            notatxt.TabIndex = 7;
            // 
            // btncargar
            // 
            btncargar.BackColor = Color.Black;
            btncargar.FlatStyle = FlatStyle.Flat;
            btncargar.Location = new Point(123, 407);
            btncargar.Name = "btncargar";
            btncargar.Size = new Size(140, 36);
            btncargar.TabIndex = 4;
            btncargar.Text = "Cargar / Sobreescribir";
            btncargar.UseVisualStyleBackColor = false;
            btncargar.Click += btncargar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(96, 135);
            label3.Name = "label3";
            label3.Size = new Size(215, 37);
            label3.TabIndex = 3;
            label3.Text = "Nombre Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(108, 32);
            label2.Name = "label2";
            label2.Size = new Size(184, 37);
            label2.TabIndex = 2;
            label2.Text = "Nombre Profe";
            // 
            // profetxt
            // 
            profetxt.DropDownStyle = ComboBoxStyle.DropDownList;
            profetxt.FormattingEnabled = true;
            profetxt.Items.AddRange(new object[] { "Mario Rampi", "Mauro Luciano", "Felipe Bustos" });
            profetxt.Location = new Point(61, 72);
            profetxt.Name = "profetxt";
            profetxt.Size = new Size(264, 23);
            profetxt.TabIndex = 0;
            // 
            // alumnotxt
            // 
            alumnotxt.DropDownStyle = ComboBoxStyle.DropDownList;
            alumnotxt.FormattingEnabled = true;
            alumnotxt.Items.AddRange(new object[] { "Towers Matías" });
            alumnotxt.Location = new Point(61, 175);
            alumnotxt.Name = "alumnotxt";
            alumnotxt.Size = new Size(264, 23);
            alumnotxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(423, 23);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 8;
            label1.Text = "Profe Correccion";
            // 
            // correccionProfe
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
            Name = "correccionProfe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "correccionProfe";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private ComboBox notatxt;
        private Button btncargar;
        private Label label3;
        private Label label2;
        private ComboBox profetxt;
        private ComboBox alumnotxt;
        private Label label1;
    }
}