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
                else
                {
                    //Verificar si es estudiante
                    if (VerificarDatos.VerificoEstudiante(usuarioylegajotxt.Text, passwordtxt.Text))
                    {
                        string legajoLogeado = usuarioylegajotxt.Text; //GRACIAS A ESTO PEUDO TRABAJAR CON 'SESIONES' puedo hacer consultas mas adelante con el legajoLogeado
                        dashboardAlumno = new dashboardEstudiante(legajoLogeado);
                        dashboardAlumno.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o legajo incorrecto");
                    }
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
    }

    //leer autenticarCredenciales
}