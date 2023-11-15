using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sysacad
{
    public partial class dashboardEstudiante : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        login logout;
        incripcionCurso inscribirme;
        public dashboardEstudiante(string legajoLogeado)
        {
            InitializeComponent();
            MostrarNombreEstudiante(legajoLogeado);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                logout = new login();
                logout.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarNombreEstudiante(string legajoLogeado)
        {
            string query = "SELECT nombre FROM estudiantes WHERE legajo = '" + legajoLogeado + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                bienvenido.Text = reader["nombre"].ToString();
            }
            conexion.Close();
        }

        private void btnincribircurso_Click(object sender, EventArgs e)
        {
            if (inscribirme == null)
            {
                inscribirme = new incripcionCurso(bienvenido.Text);
                inscribirme.FormClosed += Incribirme_FormClosed;
                inscribirme.MdiParent = this;
                inscribirme.Show();
            }
            else
            {
                inscribirme.Activate();
            }
        }

        private void Incribirme_FormClosed(object sender, FormClosedEventArgs e)
        {
            inscribirme = null;
        }
    }
}
