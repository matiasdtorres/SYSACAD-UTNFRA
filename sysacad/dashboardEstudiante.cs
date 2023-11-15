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
        login logout;
        incripcionCurso inscribirme;
        public dashboardEstudiante(string legajoLogeado)
        {
            InitializeComponent();
            MostrarNumeroEstudiante(legajoLogeado);
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

        private void MostrarNumeroEstudiante(string legajoLogeado)
        {
            mostrarlegajo.Text = legajoLogeado.ToString();
        }

        private void IncribirseACurso(string legajoLogeado)
        {
            try
            {
                //string query = "INSERT INTO `inscripciones`(`id`, `id_curso`, `id_estudiante`) VALUES (NULL, '" + id_curso + "', '" + legajo + "')";
                //MySqlCommand comando = new MySqlCommand(query, conexion);
                //conexion.Open();
                //comando.ExecuteNonQuery();
                //conexion.Close();
                //MessageBox.Show("Inscripcion realizada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnincribircurso_Click(object sender, EventArgs e)
        {
            try
            {
                inscribirme = new incripcionCurso(mostrarlegajo.Text);
                inscribirme.FormClosed += Incribirme_FormClosed;
                inscribirme.MdiParent = this;
                inscribirme.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Incribirme_FormClosed(object sender, FormClosedEventArgs e)
        {
            inscribirme = null;
        }
    }
}
