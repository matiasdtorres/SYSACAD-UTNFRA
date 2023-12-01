namespace sysacad
{
    partial class dashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardAdmin));
            panel1 = new Panel();
            btnlogout = new Button();
            btncerrar = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnagregarestudiante = new Button();
            btngestionarcursos = new Button();
            btngenerarreportes = new Button();
            btngestionarrequisitosacademicos = new Button();
            btnlistasdeespera = new Button();
            btnperfilesdeprofes = new Button();
            btnvalidar = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btncerrar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 46);
            panel1.TabIndex = 0;
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
            btncerrar.ForeColor = Color.Black;
            btncerrar.Location = new Point(1197, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(75, 23);
            btncerrar.TabIndex = 4;
            btncerrar.Text = "X";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 3;
            label1.Text = "SYSACAD | UTN FRA";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(btnagregarestudiante);
            flowLayoutPanel1.Controls.Add(btngestionarcursos);
            flowLayoutPanel1.Controls.Add(btngenerarreportes);
            flowLayoutPanel1.Controls.Add(btngestionarrequisitosacademicos);
            flowLayoutPanel1.Controls.Add(btnlistasdeespera);
            flowLayoutPanel1.Controls.Add(btnperfilesdeprofes);
            flowLayoutPanel1.Controls.Add(btnvalidar);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 619);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnagregarestudiante
            // 
            btnagregarestudiante.BackColor = Color.White;
            btnagregarestudiante.FlatAppearance.BorderSize = 0;
            btnagregarestudiante.FlatStyle = FlatStyle.Flat;
            btnagregarestudiante.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregarestudiante.ForeColor = Color.Black;
            btnagregarestudiante.Location = new Point(3, 3);
            btnagregarestudiante.Name = "btnagregarestudiante";
            btnagregarestudiante.Size = new Size(215, 33);
            btnagregarestudiante.TabIndex = 0;
            btnagregarestudiante.Text = "Agregar Estudiante";
            btnagregarestudiante.UseVisualStyleBackColor = false;
            btnagregarestudiante.Click += btnagregarestudiante_Click;
            // 
            // btngestionarcursos
            // 
            btngestionarcursos.BackColor = Color.White;
            btngestionarcursos.FlatAppearance.BorderSize = 0;
            btngestionarcursos.FlatStyle = FlatStyle.Flat;
            btngestionarcursos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btngestionarcursos.ForeColor = Color.Black;
            btngestionarcursos.Location = new Point(3, 42);
            btngestionarcursos.Name = "btngestionarcursos";
            btngestionarcursos.Size = new Size(215, 33);
            btngestionarcursos.TabIndex = 1;
            btngestionarcursos.Text = "Gestionar Cursos";
            btngestionarcursos.UseVisualStyleBackColor = false;
            btngestionarcursos.Click += btngestionarcursos_Click;
            // 
            // btngenerarreportes
            // 
            btngenerarreportes.BackColor = Color.White;
            btngenerarreportes.FlatAppearance.BorderSize = 0;
            btngenerarreportes.FlatStyle = FlatStyle.Flat;
            btngenerarreportes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btngenerarreportes.ForeColor = Color.Black;
            btngenerarreportes.Location = new Point(3, 81);
            btngenerarreportes.Name = "btngenerarreportes";
            btngenerarreportes.Size = new Size(215, 33);
            btngenerarreportes.TabIndex = 2;
            btngenerarreportes.Text = "Generar Reportes";
            btngenerarreportes.UseVisualStyleBackColor = false;
            btngenerarreportes.Click += btngenerarreportes_Click;
            // 
            // btngestionarrequisitosacademicos
            // 
            btngestionarrequisitosacademicos.BackColor = Color.White;
            btngestionarrequisitosacademicos.FlatAppearance.BorderSize = 0;
            btngestionarrequisitosacademicos.FlatStyle = FlatStyle.Flat;
            btngestionarrequisitosacademicos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btngestionarrequisitosacademicos.ForeColor = Color.Black;
            btngestionarrequisitosacademicos.Location = new Point(3, 120);
            btngestionarrequisitosacademicos.Name = "btngestionarrequisitosacademicos";
            btngestionarrequisitosacademicos.Size = new Size(215, 33);
            btngestionarrequisitosacademicos.TabIndex = 3;
            btngestionarrequisitosacademicos.Text = "Requisitos Academicos";
            btngestionarrequisitosacademicos.UseVisualStyleBackColor = false;
            btngestionarrequisitosacademicos.Click += btngestionarrequisitosacademicos_Click;
            // 
            // btnlistasdeespera
            // 
            btnlistasdeespera.BackColor = Color.White;
            btnlistasdeespera.FlatAppearance.BorderSize = 0;
            btnlistasdeespera.FlatStyle = FlatStyle.Flat;
            btnlistasdeespera.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnlistasdeespera.ForeColor = Color.Black;
            btnlistasdeespera.Location = new Point(3, 159);
            btnlistasdeespera.Name = "btnlistasdeespera";
            btnlistasdeespera.Size = new Size(215, 33);
            btnlistasdeespera.TabIndex = 4;
            btnlistasdeespera.Text = "Listas de Espera";
            btnlistasdeespera.UseVisualStyleBackColor = false;
            btnlistasdeespera.Click += btnlistasdeespera_Click;
            // 
            // btnperfilesdeprofes
            // 
            btnperfilesdeprofes.BackColor = Color.White;
            btnperfilesdeprofes.FlatAppearance.BorderSize = 0;
            btnperfilesdeprofes.FlatStyle = FlatStyle.Flat;
            btnperfilesdeprofes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnperfilesdeprofes.ForeColor = Color.Black;
            btnperfilesdeprofes.Location = new Point(3, 198);
            btnperfilesdeprofes.Name = "btnperfilesdeprofes";
            btnperfilesdeprofes.Size = new Size(215, 33);
            btnperfilesdeprofes.TabIndex = 5;
            btnperfilesdeprofes.Text = "Perfiles de Profes";
            btnperfilesdeprofes.UseVisualStyleBackColor = false;
            btnperfilesdeprofes.Click += btnperfilesdeprofes_Click;
            // 
            // btnvalidar
            // 
            btnvalidar.BackColor = Color.White;
            btnvalidar.FlatAppearance.BorderSize = 0;
            btnvalidar.FlatStyle = FlatStyle.Flat;
            btnvalidar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnvalidar.ForeColor = Color.Black;
            btnvalidar.Location = new Point(3, 237);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(215, 33);
            btnvalidar.TabIndex = 6;
            btnvalidar.Text = "Validar";
            btnvalidar.UseVisualStyleBackColor = false;
            btnvalidar.Click += btnvalidar_Click;
            // 
            // dashboardAdmin
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
            Name = "dashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardAdmin";
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
        private Button btnagregarestudiante;
        private Button btngestionarcursos;
        private Button btngenerarreportes;
        private Button btnlogout;
        private Button btngestionarrequisitosacademicos;
        private Button btnlistasdeespera;
        private Button btnperfilesdeprofes;
        private Button btnvalidar;
    }
}