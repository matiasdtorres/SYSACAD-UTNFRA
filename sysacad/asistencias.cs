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
    public partial class asistencias : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        private MySqlConnection conexion2 = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        private MySqlConnection conexion3 = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public asistencias(string profeLogeado)
        {
            InitializeComponent();
            usuarioescondio(profeLogeado);
            CargarMaterias();

            // Suscribe el evento SelectedIndexChanged al ComboBox materiatxt
            materiatxt.SelectedIndexChanged += materiatxt_SelectedIndexChanged;
        }

        private void usuarioescondio(string profeLogeado)
        {
            usuarioescondidotxt.Text = profeLogeado;
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre completo del alumno seleccionado
            string nombreCompletoAlumno = CargarLegajoAlumnoSeleccionado(alumnotxt.SelectedItem.ToString());

            // Obtener el numero de asistencia seleccionado
            string numeroAsistencia = numeroasistenciatxt.SelectedItem.ToString();

            // Obtener el estado de asistencia seleccionado
            string estadoAsistencia = asistenciatxt.SelectedItem.ToString();

            // Obtener el nombre de la materia seleccionada
            string materiaSeleccionada = materiatxt.SelectedItem.ToString();

            // Agregar el estudiante a la materia seleccionada
            AgregarEstudianteAMateria(materiaSeleccionada, nombreCompletoAlumno, numeroAsistencia, estadoAsistencia);
        }

        private void materiatxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia la lista de alumnos antes de cargar nuevos alumnos
            alumnotxt.Items.Clear();

            CargarAlumnosPorMateria(materiatxt.SelectedItem.ToString());
        }

        private void CargarMaterias()
        {
            try
            {
                conexion.Open();

                string nombreCompleto = ObtenerNombreCompletoProfesor();

                if (!string.IsNullOrEmpty(nombreCompleto))
                {
                    string selectCursosQuery = "SELECT nombre FROM cursos WHERE profesor = @Profesor";

                    using (MySqlCommand comando = new MySqlCommand(selectCursosQuery, conexion))
                    {
                        comando.Parameters.AddWithValue("@Profesor", nombreCompleto);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    materiatxt.Items.Add(reader["nombre"]);

                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron materias para el profesor.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las materias: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
        }

        private string ObtenerNombreCompletoProfesor()
        {
            string nombreCompleto = "";

            try
            {
                conexion2.Open();

                string selectProfesorQuery = "SELECT nombre, apellido FROM profesores WHERE nombre = @ProfeLogeado";

                using (MySqlCommand comando = new MySqlCommand(selectProfesorQuery, conexion2))
                {
                    comando.Parameters.AddWithValue("@ProfeLogeado", usuarioescondidotxt.Text);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                nombreCompleto = $"{reader["nombre"]} {reader["apellido"]}";
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró al profesor con el nombre de usuario proporcionado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el nombre completo del profesor: {ex.Message}");
            }
            finally
            {
                conexion2.Close();
            }

            return nombreCompleto;
        }

        private void CargarAlumnosPorMateria(string materiaSeleccionada)
        {
            try
            {
                conexion3.Open();

                string selectAlumnosQuery = $@"
            SELECT nombre, apellido FROM estudiantes 
            WHERE materia1 = @MateriaSeleccionada OR
                  materia2 = @MateriaSeleccionada OR
                  materia3 = @MateriaSeleccionada OR
                  materia4 = @MateriaSeleccionada OR
                  materia5 = @MateriaSeleccionada OR
                  materia6 = @MateriaSeleccionada OR
                  materia7 = @MateriaSeleccionada OR
                  materia8 = @MateriaSeleccionada;";

                using (MySqlCommand comando = new MySqlCommand(selectAlumnosQuery, conexion3))
                {
                    comando.Parameters.AddWithValue("@MateriaSeleccionada", materiaSeleccionada);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                alumnotxt.Items.Add($"{reader["nombre"]} {reader["apellido"]}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron alumnos en la materia seleccionada");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los alumnos: {ex.Message}");
            }
            finally
            {
                conexion3.Close();
            }
        }

        private string CargarLegajoAlumnoSeleccionado(string nombreCompletoAlumno)
        {
            string legajo = "";

            try
            {
                conexion.Open();

                string selectLegajoQuery = "SELECT legajo FROM estudiantes WHERE nombre = @Nombre AND apellido = @Apellido";

                using (MySqlCommand comando = new MySqlCommand(selectLegajoQuery, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombreCompletoAlumno.Split(' ')[0]);
                    comando.Parameters.AddWithValue("@Apellido", nombreCompletoAlumno.Split(' ')[1]);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                legajo = reader["legajo"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontro el legajo del alumno seleccionado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el legajo del alumno: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }

            return legajo;
        }


        //actualizar la tabla de asistencia
        private void AgregarEstudianteAMateria(string nombreTabla, string legajoseleccionado, string numeroasistencia, string estadoasistencia)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=materias;Uid=root;pwd=;"))
                {
                    conexion.Open();

                    // Obtener el número de la asistencia actual (por ejemplo, 1 para asistencia1)
                    int numeroAsistenciaActual = int.Parse(numeroasistencia.Substring(numeroasistencia.Length - 1));

                    // Verificar si las asistencias anteriores han sido registradas
                    for (int i = 1; i < numeroAsistenciaActual; i++)
                    {
                        string nombreAsistenciaAnterior = $"asistencia{i}";

                        string queryVerificarAsistenciaAnterior = $@"
                        SELECT COUNT(*) FROM {nombreTabla.Replace(" ", "_")} 
                        WHERE legajo = '{legajoseleccionado}' AND {nombreAsistenciaAnterior} IS NOT NULL";

                        using (MySqlCommand verificarAsistenciaAnterior = new MySqlCommand(queryVerificarAsistenciaAnterior, conexion))
                        {
                            int countAsistenciaAnterior = Convert.ToInt32(verificarAsistenciaAnterior.ExecuteScalar());

                            if (countAsistenciaAnterior == 0)
                            {
                                MessageBox.Show($"Primero debe cargar la {nombreAsistenciaAnterior}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // Verificar si ya existe un valor en la asistencia especificada
                    string queryVerificarAsistencia = $@"
                    SELECT COUNT(*) FROM {nombreTabla.Replace(" ", "_")} 
                    WHERE legajo = '{legajoseleccionado}' AND {numeroasistencia} IS NOT NULL";

                    using (MySqlCommand verificarAsistencia = new MySqlCommand(queryVerificarAsistencia, conexion))
                    {
                        int count = Convert.ToInt32(verificarAsistencia.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show($"La {numeroasistencia} ya ha sido registrada anteriormente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // pongo asistencia
                    string queryInsertarAsistencia = $@"
                    UPDATE {nombreTabla.Replace(" ", "_")} SET {numeroasistencia} = '{estadoasistencia}' WHERE legajo = '{legajoseleccionado}'";

                    using (MySqlCommand insertarEstudiante = new MySqlCommand(queryInsertarAsistencia, conexion))
                    {
                        insertarEstudiante.ExecuteNonQuery();

                        MessageBox.Show($"Asistencia {numeroasistencia} cargada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al actualizar la asistencia: {ex.Message}", "Error de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
