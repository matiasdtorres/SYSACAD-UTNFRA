using biblioteca;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Security.Policy;
using Hash = biblioteca.Hash;

namespace sysacad
{
    public partial class login : Form
    {

        dashboardAdmin dashboardAdministrador;
        dashboardEstudiante dashboardAlumno;
        dashboardProfesor dashboardProfesor;

        public login()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //Verificar si es admin
                if (VerificarDatos.VerificoAdmin(usuarioylegajotxt.Text, passwordtxt.Text))
                {
                    dashboardAdministrador = new dashboardAdmin();
                    dashboardAdministrador.Show();
                    this.Hide();
                }
                else if (VerificarDatos.VerificoEstudiante(usuarioylegajotxt.Text, passwordtxt.Text))
                {
                    string legajoLogeado = usuarioylegajotxt.Text;
                    dashboardAlumno = new dashboardEstudiante(legajoLogeado);
                    dashboardAlumno.Show();
                    this.Hide();
                }
                else if (VerificarDatos.VerificoProfesor(usuarioylegajotxt.Text, passwordtxt.Text))
                {
                    string profeLogeado = usuarioylegajotxt.Text;
                    dashboardProfesor = new dashboardProfesor(profeLogeado);
                    dashboardProfesor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseņa incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            usuarioylegajotxt.Text = "matias";
            passwordtxt.Text = "123";
        }

        private void btnestudiante_Click(object sender, EventArgs e)
        {
            usuarioylegajotxt.Text = "1";
            passwordtxt.Text = "123";
        }

        private void btnprofesor_Click(object sender, EventArgs e)
        {
            usuarioylegajotxt.Text = "profe";
            passwordtxt.Text = "123";
        }
    }
}