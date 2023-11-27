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
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
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
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 37);
            label1.TabIndex = 4;
            label1.Text = "Gestionar Listas de Espera";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(66, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 240);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Estudiante";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(604, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 240);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar Estudiante";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(132, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 7;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(132, 208);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 8;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
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
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
    }
}