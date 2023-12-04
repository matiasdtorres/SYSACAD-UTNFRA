namespace sysacad
{
    partial class payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payments));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            numerotarjeta = new TextBox();
            groupBox2 = new GroupBox();
            tipotarjeta = new ComboBox();
            groupBox3 = new GroupBox();
            nombretarjeta = new TextBox();
            groupBox4 = new GroupBox();
            codigotarjeta = new TextBox();
            groupBox5 = new GroupBox();
            pictureBox3 = new PictureBox();
            btnagregar = new Button();
            legajoescondido = new Label();
            vencimientotarjeta = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(389, 387);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(158, -35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 193);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numerotarjeta);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(158, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(237, 45);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Numero de la Tarjeta";
            // 
            // numerotarjeta
            // 
            numerotarjeta.Location = new Point(6, 16);
            numerotarjeta.Name = "numerotarjeta";
            numerotarjeta.Size = new Size(225, 23);
            numerotarjeta.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tipotarjeta);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(158, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(237, 45);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Tarjeta";
            // 
            // tipotarjeta
            // 
            tipotarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            tipotarjeta.FormattingEnabled = true;
            tipotarjeta.Items.AddRange(new object[] { "Credito", "Debito" });
            tipotarjeta.Location = new Point(6, 16);
            tipotarjeta.Name = "tipotarjeta";
            tipotarjeta.Size = new Size(225, 23);
            tipotarjeta.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nombretarjeta);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(158, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(237, 45);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nombre del Titular";
            // 
            // nombretarjeta
            // 
            nombretarjeta.Location = new Point(6, 16);
            nombretarjeta.Name = "nombretarjeta";
            nombretarjeta.Size = new Size(225, 23);
            nombretarjeta.TabIndex = 9;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(codigotarjeta);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(158, 275);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(237, 45);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Codigo Seguridad";
            // 
            // codigotarjeta
            // 
            codigotarjeta.Location = new Point(6, 16);
            codigotarjeta.Name = "codigotarjeta";
            codigotarjeta.Size = new Size(225, 23);
            codigotarjeta.TabIndex = 10;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(vencimientotarjeta);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(158, 326);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(237, 45);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Vencimiento";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-10, 387);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(169, 170);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Black;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregar.Location = new Point(188, 427);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(176, 58);
            btnagregar.TabIndex = 7;
            btnagregar.Text = "Listo";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // legajoescondido
            // 
            legajoescondido.AutoSize = true;
            legajoescondido.ForeColor = Color.Black;
            legajoescondido.Location = new Point(63, 19);
            legajoescondido.Name = "legajoescondido";
            legajoescondido.Size = new Size(38, 15);
            legajoescondido.TabIndex = 8;
            legajoescondido.Text = "label1";
            // 
            // vencimientotarjeta
            // 
            vencimientotarjeta.Location = new Point(6, 16);
            vencimientotarjeta.Name = "vencimientotarjeta";
            vencimientotarjeta.Size = new Size(225, 23);
            vencimientotarjeta.TabIndex = 9;
            // 
            // payments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(537, 524);
            Controls.Add(legajoescondido);
            Controls.Add(btnagregar);
            Controls.Add(pictureBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Name = "payments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Metodo de Pago";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox tipotarjeta;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private PictureBox pictureBox3;
        private Button btnagregar;
        private TextBox numerotarjeta;
        private TextBox nombretarjeta;
        private TextBox codigotarjeta;
        private Label legajoescondido;
        private DateTimePicker vencimientotarjeta;
    }
}