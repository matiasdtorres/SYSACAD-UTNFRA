﻿namespace sysacad
{
    partial class asistencias
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
            label1.Location = new Point(373, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 2;
            label1.Text = "Cargar Asistencias";
            // 
            // usuarioescondidotxt
            // 
            usuarioescondidotxt.AutoSize = true;
            usuarioescondidotxt.ForeColor = Color.Black;
            usuarioescondidotxt.Location = new Point(452, 46);
            usuarioescondidotxt.Name = "usuarioescondidotxt";
            usuarioescondidotxt.Size = new Size(101, 15);
            usuarioescondidotxt.TabIndex = 5;
            usuarioescondidotxt.Text = "usuarioescondido";
            // 
            // asistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1060, 614);
            Controls.Add(usuarioescondidotxt);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "asistencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "asistencias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label usuarioescondidotxt;
    }
}