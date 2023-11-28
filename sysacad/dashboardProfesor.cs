using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysacad
{
    public partial class dashboardProfesor : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        login logout;
        notas cargarNotas;
        asistencias cargarAsistencias;


        public dashboardProfesor(string profeLogeado)
        {
            InitializeComponent();
            MostrarNombreEstudiante(profeLogeado);
        }

        private void MostrarNombreEstudiante(string profeLogeado)
        {
            string query = "SELECT nombre FROM profesores WHERE usuario = '" + profeLogeado + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                bienvenidonombre.Text = reader["nombre"].ToString();
            }
            conexion.Close();
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

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnasistencias_Click(object sender, EventArgs e)
        {
            if (cargarAsistencias == null)
            {
                cargarAsistencias = new asistencias(bienvenidonombre.Text);
                cargarAsistencias.FormClosed += asistencias_FormClosed;
                cargarAsistencias.MdiParent = this;
                cargarAsistencias.Show();
            }
            else
            {
                cargarAsistencias.Activate();
            }
        }

        private void asistencias_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarAsistencias = null;
        }

        private void btnnotas_Click(object sender, EventArgs e)
        {
            if (cargarNotas == null)
            {
                cargarNotas = new notas(bienvenidonombre.Text);
                cargarNotas.FormClosed += notas_FormClosed;
                cargarNotas.MdiParent = this;
                cargarNotas.Show();
            }
            else
            {
                cargarNotas.Activate();
            }
        }

        private void notas_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarNotas = null;
        }
    }
}
