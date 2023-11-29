namespace sysacad
{
    partial class listasDeEspera
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
            materiatxt = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            legajotxt = new TextBox();
            btnagregar = new Button();
            groupBox2 = new GroupBox();
            materiaeliminartxt = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            legajoeliminartxt = new TextBox();
            btneliminar = new Button();
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
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 37);
            label1.TabIndex = 4;
            label1.Text = "Gestionar Listas de Espera";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materiatxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(legajotxt);
            groupBox1.Controls.Add(btnagregar);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(66, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 240);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Estudiante";
            // 
            // materiatxt
            // 
            materiatxt.DropDownStyle = ComboBoxStyle.DropDownList;
            materiatxt.FormattingEnabled = true;
            materiatxt.Location = new Point(72, 128);
            materiatxt.Name = "materiatxt";
            materiatxt.Size = new Size(201, 23);
            materiatxt.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 110);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 10;
            label3.Text = "Materia con lista de espera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 40);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 9;
            label2.Text = "Legajo del estudiante";
            // 
            // legajotxt
            // 
            legajotxt.Location = new Point(72, 58);
            legajotxt.Name = "legajotxt";
            legajotxt.Size = new Size(201, 23);
            legajotxt.TabIndex = 7;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Black;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Location = new Point(132, 208);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 26);
            btnagregar.TabIndex = 7;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materiaeliminartxt);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(legajoeliminartxt);
            groupBox2.Controls.Add(btneliminar);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(644, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 240);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar Estudiante";
            // 
            // materiaeliminartxt
            // 
            materiaeliminartxt.DropDownStyle = ComboBoxStyle.DropDownList;
            materiaeliminartxt.FormattingEnabled = true;
            materiaeliminartxt.Location = new Point(72, 128);
            materiaeliminartxt.Name = "materiaeliminartxt";
            materiaeliminartxt.Size = new Size(201, 23);
            materiaeliminartxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 110);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 10;
            label4.Text = "Materia con lista de espera";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 40);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 9;
            label5.Text = "Legajo del estudiante";
            // 
            // legajoeliminartxt
            // 
            legajoeliminartxt.Location = new Point(72, 58);
            legajoeliminartxt.Name = "legajoeliminartxt";
            legajoeliminartxt.Size = new Size(201, 23);
            legajoeliminartxt.TabIndex = 7;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Black;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Location = new Point(132, 208);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 26);
            btneliminar.TabIndex = 7;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // listasDeEspera
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
            Name = "listasDeEspera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "listasDeEspera";
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
        private Button btnagregar;
        private ComboBox materiatxt;
        private Label label3;
        private Label label2;
        private TextBox legajotxt;
        private GroupBox groupBox2;
        private ComboBox materiaeliminartxt;
        private Label label4;
        private Label label5;
        private TextBox legajoeliminartxt;
        private Button btneliminar;
    }
}