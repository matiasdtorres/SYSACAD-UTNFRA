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
        datosEstudiante datosAlumno;
        horarios consultarHorarios;
        pagos realizarPagos;

        public dashboardEstudiante(string legajoLogeado)
        {
            InitializeComponent();
            MostrarNombreEstudiante(legajoLogeado);
            MostrarLegajoEstudiante(legajoLogeado);
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

        private void MostrarLegajoEstudiante(string legajoLogeado)
        {
            string query = "SELECT legajo FROM estudiantes WHERE legajo = '" + legajoLogeado + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                bienvenidolegajo.Text = reader["legajo"].ToString();
            }
            conexion.Close();
        }

        private void MostrarNombreEstudiante(string legajoLogeado)
        {
            string query = "SELECT nombre FROM estudiantes WHERE legajo = '" + legajoLogeado + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                bienvenidonombre.Text = reader["nombre"].ToString();
            }
            conexion.Close();
        }

        private void btnincribircurso_Click(object sender, EventArgs e)
        {
            if (inscribirme == null)
            {
                inscribirme = new incripcionCurso(bienvenidolegajo.Text);
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

        private void btnmisdatos_Click(object sender, EventArgs e)
        {
            if (datosAlumno == null)
            {
                datosAlumno = new datosEstudiante(bienvenidolegajo.Text);
                datosAlumno.FormClosed += DatosAlumno_FormClosed;
                datosAlumno.MdiParent = this;
                datosAlumno.Show();
            }
            else
            {
                datosAlumno.Activate();
            }
        }

        private void DatosAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            datosAlumno = null;
        }

        private void btnconsultarhorarios_Click(object sender, EventArgs e)
        {
            if (consultarHorarios == null)
            {
                consultarHorarios = new horarios(bienvenidolegajo.Text);
                consultarHorarios.FormClosed += ConsultarHorarios_FormClosed;
                consultarHorarios.MdiParent = this;
                consultarHorarios.Show();
            }
            else
            {
                consultarHorarios.Activate();
            }
        }

        private void ConsultarHorarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            consultarHorarios = null;
        }

        private void btnrealizarpagos_Click(object sender, EventArgs e)
        {
            if (realizarPagos == null)
            {
                realizarPagos = new pagos(bienvenidolegajo.Text);
                realizarPagos.FormClosed += RealizarPagos_FormClosed;
                realizarPagos.MdiParent = this;
                realizarPagos.Show();
            }
            else
            {
                realizarPagos.Activate();
            }
        }

        private void RealizarPagos_FormClosed(object sender, FormClosedEventArgs e)
        {
            realizarPagos = null;
        }
    }
}
