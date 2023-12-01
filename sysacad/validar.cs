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
    public partial class validar : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        private MySqlConnection conexion2 = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        private MySqlConnection conexion3 = new MySqlConnection("server=localhost;port=3306;database=materias;Uid=root;pwd=;");
        private MySqlConnection conexion4 = new MySqlConnection("server=localhost;port=3306;database=materias;Uid=root;pwd=;");

        public validar()
        {
            InitializeComponent();
            cursos();

            materiatxt.SelectedIndexChanged += materiatxt_SelectedIndexChanged;
            alumnotxt.SelectedIndexChanged += alumnotxt_SelectedIndexChanged;

        }

        private void btncargar_Click(object sender, EventArgs e)
        {

            if (materiatxt.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una curso");
                return;
            }

            if (alumnotxt.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un alumno");
                return;
            }

            if (validartxt.Text == "")
            {
                MessageBox.Show("Ingrese un valor de validacion");
                return;
            }

            string alumnoSeleccionado = CargarLegajoAlumnoSeleccionado(alumnotxt.SelectedItem.ToString());
            ValidarSiExisteValidacion(alumnoSeleccionado, materiatxt.SelectedItem.ToString());
        }

        private void ValidarSiExisteValidacion(string alumnoSeleccionado, string nombreTabla)
        {
            try
            {
                if (ValidarAsistencias(alumnoSeleccionado, nombreTabla))
                {
                    conexion4.Open();

                    string selectValidacionQuery = $@"SELECT validacion FROM {nombreTabla.Replace(" ", "_")} WHERE legajo = @AlumnoSeleccionado;";

                    using (MySqlCommand comando = new MySqlCommand(selectValidacionQuery, conexion4))
                    {
                        comando.Parameters.AddWithValue("@AlumnoSeleccionado", alumnoSeleccionado);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (reader["validacion"].ToString() != "")
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Ya existe una validacion cargada para este alumno, desea sobreescribirla?", "Validacion existente", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            AgregarValidacion(alumnoSeleccionado, nombreTabla);
                                            MessageBox.Show("Validacion cargada correctamente");
                                        }
                                    }
                                    else
                                    {
                                        AgregarValidacion(alumnoSeleccionado, nombreTabla);
                                        MessageBox.Show("Validacion cargada correctamente");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontro la validacion del alumno seleccionado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la validacion: {ex.Message}");
            }
            finally
            {
                conexion4.Close();
            }
        }

        private bool ValidarAsistencias(string alumnoSeleccionado, string nombreTabla)
        {
            try
            {
                conexion3.Open();

                string selectAsistenciasQuery = $@"SELECT asistencia1, asistencia2, asistencia3, asistencia4, asistencia5 FROM {nombreTabla.Replace(" ", "_")} WHERE legajo = @AlumnoSeleccionado;";

                using (MySqlCommand comando = new MySqlCommand(selectAsistenciasQuery, conexion3))
                {
                    comando.Parameters.AddWithValue("@AlumnoSeleccionado", alumnoSeleccionado);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["asistencia1"].ToString() == "" || reader["asistencia2"].ToString() == "" || reader["asistencia3"].ToString() == "" || reader["asistencia4"].ToString() == "" || reader["asistencia5"].ToString() == "")
                                {
                                    MessageBox.Show("No se puede cargar la validación porque faltan asistencias por cargar");
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la validación del alumno seleccionado.");
                            return false;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la validación: {ex.Message}");
                return false;
            }
            finally
            {
                conexion3.Close();
            }
        }

        private void cursos()
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos", conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                materiatxt.Items.Add(dr[1].ToString());
            }
            conexion.Close();
        }

        private void materiatxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumnotxt.Items.Clear();

            CargarAlumnosPorMateria(materiatxt.SelectedItem.ToString());
            CargarProfesorPorMateria(materiatxt.SelectedItem.ToString());
        }

        private void alumnotxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            asistenciastxt.Clear();

            string legajoAlumnoSeleccionado = CargarLegajoAlumnoSeleccionado(alumnotxt.SelectedItem.ToString());
            CargarAsistenciasPorAlumno(legajoAlumnoSeleccionado, materiatxt.SelectedItem.ToString());
        }

        private void CargarAlumnosPorMateria(string materiaSeleccionada)
        {
            try
            {
                conexion2.Open();

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

                using (MySqlCommand comando = new MySqlCommand(selectAlumnosQuery, conexion2))
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
                conexion2.Close();
            }
        }

        private void CargarProfesorPorMateria(string materiaSeleccionada)
        {
            try
            {
                conexion2.Open();

                string selectProfesorQuery = $@"
                  SELECT profesor FROM cursos
                  WHERE nombre = @MateriaSeleccionada;";

                using (MySqlCommand comando = new MySqlCommand(selectProfesorQuery, conexion2))
                {
                    comando.Parameters.AddWithValue("@MateriaSeleccionada", materiaSeleccionada);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                profetxt.Text = reader["profesor"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron profesores en la materia seleccionada");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los profesores: {ex.Message}");
            }
            finally
            {
                conexion2.Close();
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

        private void CargarAsistenciasPorAlumno(string alumnoSeleccionado, string nombreTabla)
        {
            try
            {
                conexion3.Open();

                string selectAsistenciasQuery = $@"
                  SELECT asistencia1, asistencia2, asistencia3, asistencia4, asistencia5 FROM {nombreTabla.Replace(" ", "_")}
                  WHERE legajo = @AlumnoSeleccionado;";

                using (MySqlCommand comando = new MySqlCommand(selectAsistenciasQuery, conexion3))
                {
                    comando.Parameters.AddWithValue("@AlumnoSeleccionado", alumnoSeleccionado);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                asistenciastxt.Text = $"clase 1: {reader["asistencia1"]}   |||   clase 2: {reader["asistencia2"]}   |||   clase 3: {reader["asistencia3"]}   |||   clase 4: {reader["asistencia4"]}   |||   clase 5: {reader["asistencia5"]}";
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron asistencias en el alumno seleccionado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las asistencias: {ex.Message}");
            }
            finally
            {
                conexion3.Close();
            }
        }

        private void AgregarValidacion(string alumnoSeleccionado, string nombreTabla)
        {
            try
            {
                conexion3.Open();

                string updateValidacionQuery = $@"
                  UPDATE {nombreTabla.Replace(" ", "_")}
                  SET validacion = @Validacion
                  WHERE legajo = @AlumnoSeleccionado;";

                using (MySqlCommand comando = new MySqlCommand(updateValidacionQuery, conexion3))
                {
                    comando.Parameters.AddWithValue("@Validacion", validartxt.Text);
                    comando.Parameters.AddWithValue("@AlumnoSeleccionado", alumnoSeleccionado);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la validacion: {ex.Message}");
            }
            finally
            {
                conexion3.Close();
            }
        }
    }
}
