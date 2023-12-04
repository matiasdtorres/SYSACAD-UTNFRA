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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace sysacad
{
    public partial class perfilesDeProfes : Form
    {
        public perfilesDeProfes()
        {
            InitializeComponent();
            traernombreprofesores();
            traercursos();
        }

        private void btncrearcontraseña_Click(object sender, EventArgs e)
        {
            try
            {
                // Generar una contraseña temporal aleatoria utilizando la clase de utilidad
                string contraseñaTemporal = GeneradorContraseñaTemporal.GenerarContraseña();

                contraseñaTemporaltxt.Text = contraseñaTemporal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar contraseña temporal: " + ex.Message);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombretxt.Text) || string.IsNullOrEmpty(apellidotxt.Text) || string.IsNullOrEmpty(direcciontxt.Text) || string.IsNullOrEmpty(telefonotxt.Text) || string.IsNullOrEmpty(emailtxt.Text) || string.IsNullOrEmpty(usuariotxt.Text) || string.IsNullOrEmpty(contraseñaTemporaltxt.Text) || string.IsNullOrEmpty(especializaciontxt.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else if (nombretxt.Text.Any(char.IsDigit) || apellidotxt.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener numeros");
            }
            else if (telefonotxt.Text.Any(char.IsLetter))
            {
                MessageBox.Show("El telefono no puede contener letras");
            }
            else if (telefonotxt.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener exactamente 10 caracteres");
            }
            else if (emailtxt.Text.Contains("@") == false || emailtxt.Text.Contains(".com") == false)
            {
                MessageBox.Show("El email debe contener un @ y un .com");
            }
            else
            {
                string usuario = usuariotxt.Text;
                string nombre = nombretxt.Text;
                string apellido = apellidotxt.Text;
                string direccion = direcciontxt.Text;
                string telefono = telefonotxt.Text;
                string email = emailtxt.Text;
                string contraseñaTemporal = contraseñaTemporaltxt.Text;
                string especializacion = especializaciontxt.Text;

                try
                {
                    // Hashear la contraseña temporal antes de almacenarla en la base de datos
                    string contraseña = Hash.GetHash(contraseñaTemporal);

                    Profesores nuevoProfesor = new Profesores(usuario, nombre, apellido, direccion, telefono, email, contraseña, especializacion);

                    int filasAfectadas = nuevoProfesor.AgregarProfesor();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Profesor agregado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el profesor");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar estudiante: " + ex.Message);
                }
            }
        }

        public void CargarCursos(DataGridView panelprofes)
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "SELECT * FROM profesores";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                panelprofes.DataSource = tabla;
            }
        }

        private void perfilesDeProfes_Load(object sender, EventArgs e)
        {
            CargarCursos(panelprofes);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usuarioeditartxt.Text) || string.IsNullOrEmpty(nombreeditartxt.Text) || string.IsNullOrEmpty(apellidoeditartxt.Text) || string.IsNullOrEmpty(direccioneditartxt.Text) || string.IsNullOrEmpty(telefonoeditartxt.Text) || string.IsNullOrEmpty(emaileditartxt.Text) || string.IsNullOrEmpty(especializacioneditartxt.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else if (nombreeditartxt.Text.Any(char.IsDigit) || apellidoeditartxt.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener numeros");
            }
            else if (telefonoeditartxt.Text.Any(char.IsLetter))
            {
                MessageBox.Show("El telefono no puede contener letras");
            }
            else if (telefonoeditartxt.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener exactamente 10 caracteres");
            }
            else if (emaileditartxt.Text.Contains("@") == false || emaileditartxt.Text.Contains(".com") == false)
            {
                MessageBox.Show("El email debe contener un @ y un .com");
            }
            else
            {
                string usuario = usuarioeditartxt.Text;
                string nombre = nombreeditartxt.Text;
                string apellido = apellidoeditartxt.Text;
                string direccion = direccioneditartxt.Text;
                string telefono = telefonoeditartxt.Text;
                string email = emaileditartxt.Text;
                string especializacion = especializacioneditartxt.Text;
                string contraseña = Hash.GetHash(contraseñaTemporaltxt.Text);

                try
                {
                    Profesores profesorEditado = new Profesores(usuario, nombre, apellido, direccion, telefono, email, especializacion, contraseña);

                    int filasAfectadas = profesorEditado.EditarProfesor();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Profesor editado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar el profesor");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar profesor: " + ex.Message);
                }
            }
        }

        private void panelprofes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar datos en los textbox que terminan con editartxt
            usuarioeditartxt.Text = panelprofes.CurrentRow.Cells[1].Value.ToString();
            nombreeditartxt.Text = panelprofes.CurrentRow.Cells[2].Value.ToString();
            apellidoeditartxt.Text = panelprofes.CurrentRow.Cells[3].Value.ToString();
            direccioneditartxt.Text = panelprofes.CurrentRow.Cells[4].Value.ToString();
            telefonoeditartxt.Text = panelprofes.CurrentRow.Cells[5].Value.ToString();
            emaileditartxt.Text = panelprofes.CurrentRow.Cells[6].Value.ToString();
            especializacioneditartxt.Text = panelprofes.CurrentRow.Cells[7].Value.ToString();
        }

        private void traernombreprofesores()
        {
            //traigo de la tabla profesores el usuario y lo muestro en el combobox
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "SELECT nombre, apellido FROM profesores";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string nombreCompleto = reader.GetString("nombre") + " " + reader.GetString("apellido");

                    elegirprofeeliminartxt.Items.Add(nombreCompleto);
                    elegirprofeparacursotxt.Items.Add(nombreCompleto);
                }
            }
        }

        private void btneliminarprofe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(elegirprofeeliminartxt.Text))
            {
                MessageBox.Show("Debe elegir un profesor");
            }
            else
            {
                string usuario = elegirprofeeliminartxt.Text;
                string nombre = "";
                string apellido = "";
                string direccion = "";
                string telefono = "";
                string email = "";
                string especializacion = "";
                string contraseña = "";

                try
                {
                    Profesores profesorEliminado = new Profesores(usuario, nombre, apellido, direccion, telefono, email, especializacion, contraseña);

                    int filasAfectadas = profesorEliminado.EliminarProfesor();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Profesor eliminado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el profesor");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar profesor: " + ex.Message);
                }
            }
        }

        private void traercursos()
        {
            //traigo los cursos de la tabla cursos y los muestro en el combobox
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "SELECT nombre FROM cursos";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    asignarcursotxt.Items.Add(reader.GetString("nombre"));
                }
            }
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            // Asigno el curso elegido al profesor elegido
            if (string.IsNullOrEmpty(elegirprofeparacursotxt.Text) || string.IsNullOrEmpty(asignarcursotxt.Text))
            {
                MessageBox.Show("Debe elegir un profesor y un curso");
            }
            else
            {
                string profesorCurso = elegirprofeparacursotxt.Text;
                string nombreCurso = asignarcursotxt.Text;

                using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
                {
                    conexion.Open();

                    // Verificar si ya hay otro profesor asignado al curso
                    string queryVerificar = "SELECT profesor FROM cursos WHERE nombre = @Nombre";
                    MySqlCommand comandoVerificar = new MySqlCommand(queryVerificar, conexion);
                    comandoVerificar.Parameters.AddWithValue("@Nombre", nombreCurso);

                    object profesorExistente = comandoVerificar.ExecuteScalar();

                    if (profesorExistente != null && !string.IsNullOrEmpty(profesorExistente.ToString()))
                    {
                        // Ya hay otro profesor asignado, pedir confirmación
                        DialogResult resultado = MessageBox.Show("Ya hay otro profesor asignado a este curso. ¿Cambiamos el profesor?", "Confirmar cambio", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.No)
                        {
                            return; // El usuario no confirmó, salir de la función
                        }
                    }

                    // Actualizar el profesor del curso
                    string queryActualizar = "UPDATE cursos SET profesor = @Profesor WHERE nombre = @Nombre";
                    MySqlCommand comandoActualizar = new MySqlCommand(queryActualizar, conexion);

                    comandoActualizar.Parameters.AddWithValue("@Nombre", nombreCurso);
                    comandoActualizar.Parameters.AddWithValue("@Profesor", profesorCurso);

                    comandoActualizar.ExecuteNonQuery();

                    MessageBox.Show("Curso asignado correctamente");

                    this.Close();
                }
            }
        }

    }
}
