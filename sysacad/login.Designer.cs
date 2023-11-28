namespace sysacad
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            usuarioylegajotxt = new TextBox();
            passwordtxt = new TextBox();
            button1 = new Button();
            btncerrar = new Button();
            btnadmin = new Button();
            btnestudiante = new Button();
            btnprofesor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 295);
            label1.Name = "label1";
            label1.Size = new Size(198, 30);
            label1.TabIndex = 1;
            label1.Text = "N° legajo / usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 325);
            label2.Name = "label2";
            label2.Size = new Size(123, 30);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // usuarioylegajotxt
            // 
            usuarioylegajotxt.BackColor = Color.White;
            usuarioylegajotxt.Location = new Point(236, 302);
            usuarioylegajotxt.Name = "usuarioylegajotxt";
            usuarioylegajotxt.Size = new Size(171, 23);
            usuarioylegajotxt.TabIndex = 3;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.White;
            passwordtxt.Location = new Point(236, 332);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(171, 23);
            passwordtxt.TabIndex = 4;
            passwordtxt.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(174, 366);
            button1.Name = "button1";
            button1.Size = new Size(123, 32);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.White;
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.ForeColor = Color.Black;
            btncerrar.Location = new Point(388, 8);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(75, 23);
            btncerrar.TabIndex = 6;
            btncerrar.Text = "X";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnadmin
            // 
            btnadmin.Location = new Point(348, 416);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(123, 32);
            btnadmin.TabIndex = 7;
            btnadmin.Text = "Admin";
            btnadmin.UseVisualStyleBackColor = true;
            btnadmin.Click += btnadmin_Click;
            // 
            // btnestudiante
            // 
            btnestudiante.Location = new Point(0, 416);
            btnestudiante.Name = "btnestudiante";
            btnestudiante.Size = new Size(123, 32);
            btnestudiante.TabIndex = 8;
            btnestudiante.Text = "estudiante";
            btnestudiante.UseVisualStyleBackColor = true;
            btnestudiante.Click += btnestudiante_Click;
            // 
            // btnprofesor
            // 
            btnprofesor.Location = new Point(174, 416);
            btnprofesor.Name = "btnprofesor";
            btnprofesor.Size = new Size(123, 32);
            btnprofesor.TabIndex = 9;
            btnprofesor.Text = "Profesor";
            btnprofesor.UseVisualStyleBackColor = true;
            btnprofesor.Click += btnprofesor_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(471, 469);
            Controls.Add(btnprofesor);
            Controls.Add(btnestudiante);
            Controls.Add(btnadmin);
            Controls.Add(btncerrar);
            Controls.Add(button1);
            Controls.Add(passwordtxt);
            Controls.Add(usuarioylegajotxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sysacad - Torres Matías";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox usuarioylegajotxt;
        private TextBox passwordtxt;
        private Button button1;
        private Button btncerrar;
        private Button btnadmin;
        private Button btnestudiante;
        private Button btnprofesor;
    }
}