namespace sysacad
{
    partial class dashboardEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardEstudiante));
            panel1 = new Panel();
            label3 = new Label();
            bienvenido = new Label();
            label1 = new Label();
            label2 = new Label();
            btnlogout = new Button();
            btncerrar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnmisdatos = new Button();
            btnincribircurso = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(bienvenido);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btncerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 46);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(209, 2);
            label3.Name = "label3";
            label3.Size = new Size(26, 37);
            label3.TabIndex = 9;
            label3.Text = "|";
            // 
            // bienvenido
            // 
            bienvenido.AutoSize = true;
            bienvenido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bienvenido.ForeColor = Color.White;
            bienvenido.Location = new Point(341, 14);
            bienvenido.Name = "bienvenido";
            bienvenido.Size = new Size(81, 21);
            bienvenido.TabIndex = 8;
            bienvenido.Text = "USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 5);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 2;
            label1.Text = "SYSACAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(231, 14);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 7;
            label2.Text = "BIENVENIDO";
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.White;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Location = new Point(1116, 12);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(75, 23);
            btnlogout.TabIndex = 5;
            btnlogout.Text = "logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.White;
            btncerrar.FlatAppearance.BorderSize = 0;
            btncerrar.FlatStyle = FlatStyle.Popup;
            btncerrar.Location = new Point(1197, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(75, 23);
            btncerrar.TabIndex = 4;
            btncerrar.Text = "X";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(btnmisdatos);
            flowLayoutPanel1.Controls.Add(btnincribircurso);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 619);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnmisdatos
            // 
            btnmisdatos.BackColor = Color.White;
            btnmisdatos.FlatAppearance.BorderSize = 0;
            btnmisdatos.FlatStyle = FlatStyle.Flat;
            btnmisdatos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnmisdatos.Location = new Point(3, 3);
            btnmisdatos.Name = "btnmisdatos";
            btnmisdatos.Size = new Size(215, 33);
            btnmisdatos.TabIndex = 6;
            btnmisdatos.Text = "Mis datos";
            btnmisdatos.UseVisualStyleBackColor = false;
            btnmisdatos.Click += btnmisdatos_Click;
            // 
            // btnincribircurso
            // 
            btnincribircurso.BackColor = Color.White;
            btnincribircurso.FlatAppearance.BorderSize = 0;
            btnincribircurso.FlatStyle = FlatStyle.Flat;
            btnincribircurso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnincribircurso.Location = new Point(3, 42);
            btnincribircurso.Name = "btnincribircurso";
            btnincribircurso.Size = new Size(215, 33);
            btnincribircurso.TabIndex = 5;
            btnincribircurso.Text = "Incripcion a curso";
            btnincribircurso.UseVisualStyleBackColor = false;
            btnincribircurso.Click += btnincribircurso_Click;
            // 
            // dashboardEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 665);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "dashboardEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardEstudiante";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btncerrar;
        private Button btnlogout;
        private Button btnincribircurso;
        private Label label2;
        private Label bienvenido;
        private Label label3;
        private Button btnmisdatos;
    }
}