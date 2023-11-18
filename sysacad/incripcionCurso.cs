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
    public partial class incripcionCurso : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public incripcionCurso(string legajoLogeado)
        {
            InitializeComponent();
            MostrarLegajoEstudiante(legajoLogeado);
            MostrarCursos();
        }

        private void MostrarLegajoEstudiante(string legajoLogeado)
        {
            string query = "SELECT legajo FROM estudiantes WHERE legajo = @Legajo";
            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Legajo", legajoLogeado);
                conexion.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    legajo.Text = reader["legajo"].ToString();
                }
                conexion.Close();
            }
        }

        //Mostrar todos los cursos en los labels
        private void MostrarCursos()
        {
            try
            {
                conexion.Open();
                string query = "SELECT * FROM cursos WHERE Cuatrimestre = '1'";
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    MySqlDataReader reader = comando.ExecuteReader();

                    int courseIndex = 0;
                    while (reader.Read() && courseIndex < 4)
                    {
                        Label nombreLabel = null;
                        Label codigoLabel = null;
                        Label descripcionLabel = null;
                        Label cupoLabel = null;

                        switch (courseIndex)
                        {
                            case 0:
                                nombreLabel = nombremateria1;
                                codigoLabel = codigomateria1;
                                descripcionLabel = descripcionmateria1;
                                cupoLabel = cuposmateria1;
                                break;
                            case 1:
                                nombreLabel = nombremateria2;
                                codigoLabel = codigomateria2;
                                descripcionLabel = descripcionmateria2;
                                cupoLabel = cuposmateria2;
                                break;
                            case 2:
                                nombreLabel = nombremateria3;
                                codigoLabel = codigomateria3;
                                descripcionLabel = descripcionmateria3;
                                cupoLabel = cuposmateria3;
                                break;
                            case 3:
                                nombreLabel = nombremateria4;
                                codigoLabel = codigomateria4;
                                descripcionLabel = descripcionmateria4;
                                cupoLabel = cuposmateria4;
                                break;
                        }

                        if (nombreLabel != null)
                        {
                            nombreLabel.Text = reader["nombre"].ToString();
                            codigoLabel.Text = reader["codigo"].ToString();
                            descripcionLabel.Text = reader["descripcion"].ToString();
                            cupoLabel.Text = reader["cupoMaximo"].ToString();
                        }

                        courseIndex++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de cursos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que el estudiante no esté inscrito en el curso
            string queryValidation = "SELECT materia1 FROM estudiantes WHERE legajo = @Legajo";
            using (MySqlCommand comandoValidation = new MySqlCommand(queryValidation, conexion))
            {
                comandoValidation.Parameters.AddWithValue("@Legajo", legajo.Text);
                conexion.Open();
                object result = comandoValidation.ExecuteScalar();

                if (result != null && result != DBNull.Value && result.ToString() == nombremateria1.Text)
                {
                    MessageBox.Show($"Ya estás inscrito en el curso de {nombremateria1.Text}");
                    conexion.Close();
                    return; // Salir del método si el estudiante ya está inscrito
                }

                conexion.Close();
            }

            // Actualizar la tabla estudiantes y cursos
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia1 = @Materia1 WHERE legajo = @Legajo";
            string queryUpdateCursos = "UPDATE cursos SET cupoMaximo = cupoMaximo - 1 WHERE nombre = @Nombre";

            using (MySqlCommand comandoUpdateEstudiantes = new MySqlCommand(queryUpdateEstudiantes, conexion))
            using (MySqlCommand comandoUpdateCursos = new MySqlCommand(queryUpdateCursos, conexion))
            {
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Materia1", nombremateria1.Text);
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Legajo", legajo.Text);

                comandoUpdateCursos.Parameters.AddWithValue("@Nombre", nombremateria1.Text);

                try
                {
                    conexion.Open();
                    comandoUpdateEstudiantes.ExecuteNonQuery();
                    comandoUpdateCursos.ExecuteNonQuery();
                    MessageBox.Show($"Te inscribiste en el curso de {nombremateria1.Text}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validar que el estudiante no esté inscrito en el curso
            string queryValidation = "SELECT materia2 FROM estudiantes WHERE legajo = @Legajo";
            using (MySqlCommand comandoValidation = new MySqlCommand(queryValidation, conexion))
            {
                comandoValidation.Parameters.AddWithValue("@Legajo", legajo.Text);
                conexion.Open();
                object result = comandoValidation.ExecuteScalar();
                if (result != null && result != DBNull.Value && result.ToString() == nombremateria2.Text)
                {
                    MessageBox.Show($"Ya estás inscrito en el curso de {nombremateria2.Text}");
                    conexion.Close();
                    return; // Salir del método si el estudiante ya está inscrito
                }
                conexion.Close();
            }

            // Actualizar la tabla estudiantes y cursos
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia2 = @Materia2 WHERE legajo = @Legajo";
            string queryUpdateCursos = "UPDATE cursos SET cupoMaximo = cupoMaximo - 1 WHERE nombre = @Nombre";

            using (MySqlCommand comandoUpdateEstudiantes = new MySqlCommand(queryUpdateEstudiantes, conexion))
            using (MySqlCommand comandoUpdateCursos = new MySqlCommand(queryUpdateCursos, conexion))
            {
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Materia2", nombremateria2.Text);
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Legajo", legajo.Text);

                comandoUpdateCursos.Parameters.AddWithValue("@Nombre", nombremateria2.Text);

                try
                {
                    conexion.Open();
                    comandoUpdateEstudiantes.ExecuteNonQuery();
                    comandoUpdateCursos.ExecuteNonQuery();
                    MessageBox.Show($"Te inscribiste en el curso de {nombremateria2.Text}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validar que el estudiante no esté inscrito en el curso
            string queryValidation = "SELECT materia3 FROM estudiantes WHERE legajo = @Legajo";
            using (MySqlCommand comandoValidation = new MySqlCommand(queryValidation, conexion))
            {
                comandoValidation.Parameters.AddWithValue("@Legajo", legajo.Text);
                conexion.Open();
                object result = comandoValidation.ExecuteScalar();
                if (result != null && result != DBNull.Value && result.ToString() == nombremateria3.Text)
                {
                    MessageBox.Show($"Ya estás inscrito en el curso de {nombremateria3.Text}");
                    conexion.Close();
                    return; // Salir del método si el estudiante ya está inscrito
                }
                conexion.Close();
            }

            // Actualizar la tabla estudiantes y cursos
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia3 = @Materia3 WHERE legajo = @Legajo";
            string queryUpdateCursos = "UPDATE cursos SET cupoMaximo = cupoMaximo - 1 WHERE nombre = @Nombre";

            using (MySqlCommand comandoUpdateEstudiantes = new MySqlCommand(queryUpdateEstudiantes, conexion))
            using (MySqlCommand comandoUpdateCursos = new MySqlCommand(queryUpdateCursos, conexion))
            {
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Materia3", nombremateria3.Text);
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Legajo", legajo.Text);

                comandoUpdateCursos.Parameters.AddWithValue("@Nombre", nombremateria3.Text);

                try
                {
                    conexion.Open();
                    comandoUpdateEstudiantes.ExecuteNonQuery();
                    comandoUpdateCursos.ExecuteNonQuery();
                    MessageBox.Show($"Te inscribiste en el curso de {nombremateria3.Text}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Validar que el estudiante no esté inscrito en el curso
            string queryValidation = "SELECT materia4 FROM estudiantes WHERE legajo = @Legajo";
            using (MySqlCommand comandoValidation = new MySqlCommand(queryValidation, conexion))
            {
                comandoValidation.Parameters.AddWithValue("@Legajo", legajo.Text);
                conexion.Open();
                object result = comandoValidation.ExecuteScalar();
                if (result != null && result != DBNull.Value && result.ToString() == nombremateria4.Text)
                {
                    MessageBox.Show($"Ya estás inscrito en el curso de {nombremateria4.Text}");
                    conexion.Close();
                    return; // Salir del método si el estudiante ya está inscrito
                }
                conexion.Close();
            }

            // Actualizar la tabla estudiantes y cursos
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia4 = @Materia4 WHERE legajo = @Legajo";
            string queryUpdateCursos = "UPDATE cursos SET cupoMaximo = cupoMaximo - 1 WHERE nombre = @Nombre";

            using (MySqlCommand comandoUpdateEstudiantes = new MySqlCommand(queryUpdateEstudiantes, conexion))
            using (MySqlCommand comandoUpdateCursos = new MySqlCommand(queryUpdateCursos, conexion))
            {
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Materia4", nombremateria4.Text);
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Legajo", legajo.Text);

                comandoUpdateCursos.Parameters.AddWithValue("@Nombre", nombremateria4.Text);

                try
                {
                    conexion.Open();
                    comandoUpdateEstudiantes.ExecuteNonQuery();
                    comandoUpdateCursos.ExecuteNonQuery();
                    MessageBox.Show($"Te inscribiste en el curso de {nombremateria4.Text}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
