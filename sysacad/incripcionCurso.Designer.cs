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
            nombrebienvenida = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // nombrebienvenida
            // 
            nombrebienvenida.AutoSize = true;
            nombrebienvenida.Location = new Point(480, 55);
            nombrebienvenida.Name = "nombrebienvenida";
            nombrebienvenida.Size = new Size(38, 15);
            nombrebienvenida.TabIndex = 0;
            nombrebienvenida.Text = "label1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(364, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 37);
            label1.TabIndex = 2;
            label1.Text = "Inscribirme a curso";
            // 
            // incripcionCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1060, 614);
            Controls.Add(label1);
            Controls.Add(nombrebienvenida);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "incripcionCurso";
            Text = "incripcionCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombrebienvenida;
        private Label label1;
    }
}