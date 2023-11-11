using biblioteca;
using Microsoft.Win32;
using System.Data.SqlClient;
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

        SqlConnection conexion = new SqlConnection("server=DESKTOP-29H8DBT; database=sysacad ;integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            string password = passwordtxt.Text;

            //try
            //{
            //    conexion.Open();
            //    string query = "SELECT * FROM admin WHERE usuario = @Usuario";
            //    SqlCommand comando = new SqlCommand(query, conexion);

            //    comando.Parameters.AddWithValue("@Usuario", usuarioylegajotxt.Text);
            //    SqlDataReader leer = comando.ExecuteReader();

            //    if (leer.Read())
            //    {
            //        string hash = leer["hash"].ToString();

            //        if (Hash.ValidatePassword(password, hash))
            //        {
            //            dashboard = new dashboardAdmin();
            //            dashboard.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Contraseña incorrecta");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario o legajo incorrecto");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conexion.Close();
            //}

            try
            {
                //Verificar si es admin
                if (VerificarDatos.VerificoAdmin(usuarioylegajotxt.Text, password))
                {
                    dashboardAdministrador = new dashboardAdmin();
                    dashboardAdministrador.Show();
                    this.Hide();
                }
                else
                {
                    //Verificar si es estudiante
                    if (VerificarDatos.VerificoEstudiante(usuarioylegajotxt.Text, password))
                    {
                        dashboardAlumno = new dashboardEstudiante();
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

    }

    //leer autenticarCredenciales
}