using biblioteca;
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
    public partial class datosProfesores : Form
    {

        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public datosProfesores(string profeLogeado)
        {
            InitializeComponent();
            usuarioescondio(profeLogeado);
            MostrarDatosProfesor(profeLogeado);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombretxt.Text) || string.IsNullOrEmpty(apellidotxt.Text) || string.IsNullOrEmpty(direcciontxt.Text) || string.IsNullOrEmpty(telefonotxt.Text) || string.IsNullOrEmpty(emailtxt.Text) || string.IsNullOrEmpty(usuarioescondidotxt.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (nombretxt.Text.Any(char.IsDigit) || apellidotxt.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("El nombre y el apellido no pueden contener numeros.");
                    return;
                }
                else if (!telefonotxt.Text.All(char.IsDigit))
                {
                    MessageBox.Show("El telefono solo puede contener numeros.");
                    return;
                }
                else if (!emailtxt.Text.Contains("@"))
                {
                    MessageBox.Show("El email debe contener un @.");
                    return;
                }
                else
                {

                    string direccion = direcciontxt.Text;
                    string telefono = telefonotxt.Text;
                    string email = emailtxt.Text;

                    try
                    {
                        // Establece la cadena de conexión a la base de datos MySQL
                        using (conexion)
                        {
                            conexion.Open();

                            // Consulta SQL para actualizar los datos del estudiante
                            string query = "UPDATE profesores SET direccion = @Direccion, telefono = @Telefono, email = @Email WHERE usuario = @Usuario";
                            MySqlCommand cmd = new MySqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@Direccion", direccion);
                            cmd.Parameters.AddWithValue("@Telefono", telefono);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Usuario", usuarioescondidotxt.Text);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Datos actualizados correctamente");

                                // Cambiar la contraseña si se proporciona una nueva contraseña
                                if (!string.IsNullOrEmpty(cambiarpasstxt.Text))
                                {
                                    string nuevaContraseña = cambiarpasstxt.Text;

                                    // Hash de la nueva contraseña
                                    string hash = Hash.GetHash(nuevaContraseña);

                                    // Consulta SQL para actualizar la contraseña del estudiante
                                    string query2 = "UPDATE profesores SET contraseña = @Contraseña WHERE usuario = @Usuario";
                                    MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
                                    cmd2.Parameters.AddWithValue("@Contraseña", hash);
                                    cmd2.Parameters.AddWithValue("@Usuario", usuarioescondidotxt.Text);

                                    int filasAfectadas2 = cmd2.ExecuteNonQuery();

                                    if (filasAfectadas2 > 0)
                                    {
                                        MessageBox.Show("Contraseña actualizada correctamente");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar la contraseña");
                                    }
                                }

                                conexion.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar los datos");
                                conexion.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar los datos del profesor: " + ex.Message);
                        conexion.Close();
                    }
                }
            }
        }

        private void usuarioescondio(string profeLogeado)
        {
            usuarioescondidotxt.Text = profeLogeado;
        }

        private void MostrarDatosProfesor(string profeLogeado)
        {
            try
            {

                using (conexion)
                {
                    conexion.Open();

                    string query = "SELECT * FROM profesores WHERE usuario = @usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@usuario", profeLogeado);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombretxt.Text = reader["nombre"].ToString();
                            apellidotxt.Text = reader["apellido"].ToString();
                            direcciontxt.Text = reader["direccion"].ToString();
                            emailtxt.Text = reader["email"].ToString();
                            telefonotxt.Text = reader["telefono"].ToString();
                            usuariotxt.Text = reader["usuario"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontro un profesor con ese usuario.");
                            conexion.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
