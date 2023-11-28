namespace sysacad
{
    partial class dashboardProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardProfesor));
            panel1 = new Panel();
            label3 = new Label();
            bienvenidonombre = new Label();
            label1 = new Label();
            label2 = new Label();
            btnlogout = new Button();
            btncerrar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnmisdatos = new Button();
            btnasistencias = new Button();
            btnnotas = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(bienvenidonombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btncerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 46);
            panel1.TabIndex = 2;
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
            // bienvenidonombre
            // 
            bienvenidonombre.AutoSize = true;
            bienvenidonombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bienvenidonombre.ForeColor = Color.White;
            bienvenidonombre.Location = new Point(394, 14);
            bienvenidonombre.Name = "bienvenidonombre";
            bienvenidonombre.Size = new Size(81, 21);
            bienvenidonombre.TabIndex = 8;
            bienvenidonombre.Text = "USUARIO";
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
            label2.Size = new Size(166, 21);
            label2.TabIndex = 7;
            label2.Text = "BIENVENIDO PROFE:";
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.White;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.ForeColor = Color.Black;
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
            btncerrar.ForeColor = Color.Black;
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
            flowLayoutPanel1.Controls.Add(btnasistencias);
            flowLayoutPanel1.Controls.Add(btnnotas);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 619);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnmisdatos
            // 
            btnmisdatos.BackColor = Color.White;
            btnmisdatos.FlatAppearance.BorderSize = 0;
            btnmisdatos.FlatStyle = FlatStyle.Flat;
            btnmisdatos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnmisdatos.ForeColor = Color.Black;
            btnmisdatos.Location = new Point(3, 3);
            btnmisdatos.Name = "btnmisdatos";
            btnmisdatos.Size = new Size(215, 33);
            btnmisdatos.TabIndex = 6;
            btnmisdatos.Text = "Mis datos";
            btnmisdatos.UseVisualStyleBackColor = false;
            // 
            // btnasistencias
            // 
            btnasistencias.BackColor = Color.White;
            btnasistencias.FlatAppearance.BorderSize = 0;
            btnasistencias.FlatStyle = FlatStyle.Flat;
            btnasistencias.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnasistencias.ForeColor = Color.Black;
            btnasistencias.Location = new Point(3, 42);
            btnasistencias.Name = "btnasistencias";
            btnasistencias.Size = new Size(215, 33);
            btnasistencias.TabIndex = 7;
            btnasistencias.Text = "Cargar Asistencias";
            btnasistencias.UseVisualStyleBackColor = false;
            btnasistencias.Click += btnasistencias_Click;
            // 
            // btnnotas
            // 
            btnnotas.BackColor = Color.White;
            btnnotas.FlatAppearance.BorderSize = 0;
            btnnotas.FlatStyle = FlatStyle.Flat;
            btnnotas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnnotas.ForeColor = Color.Black;
            btnnotas.Location = new Point(3, 81);
            btnnotas.Name = "btnnotas";
            btnnotas.Size = new Size(215, 33);
            btnnotas.TabIndex = 8;
            btnnotas.Text = "Cargar Notas";
            btnnotas.UseVisualStyleBackColor = false;
            btnnotas.Click += btnnotas_Click;
            // 
            // dashboardProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 665);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "dashboardProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardProfesor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label bienvenidonombre;
        private Label label1;
        private Label label2;
        private Button btnlogout;
        private Button btncerrar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnmisdatos;
        private Button btnasistencias;
        private Button btnnotas;
    }
}