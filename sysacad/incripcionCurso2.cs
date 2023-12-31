﻿using MySql.Data.MySqlClient;
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
    public partial class incripcionCurso2 : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public incripcionCurso2(string legajoLogeado)
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
                nombremateria1.Text = null;
                diamateria1.Text = null;
                turnomateria1.Text = null;
                cuposmateria1.Text = null;

                nombremateria2.Text = null;
                diamateria2.Text = null;
                turnomateria2.Text = null;
                cuposmateria2.Text = null;

                nombremateria3.Text = null;
                diamateria3.Text = null;
                turnomateria3.Text = null;
                cuposmateria3.Text = null;

                nombremateria4.Text = null;
                diamateria4.Text = null;
                turnomateria4.Text = null;
                cuposmateria4.Text = null;

                conexion.Open();
                string query = "SELECT * FROM cursos WHERE Cuatrimestre = '2'";
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    MySqlDataReader reader = comando.ExecuteReader();

                    int courseIndex = 0;
                    while (reader.Read() && courseIndex < 4)
                    {
                        Label nombreLabel = null;
                        Label diaLabel = null;
                        Label turnoLabel = null;
                        Label cupoLabel = null;

                        switch (courseIndex)
                        {
                            case 0:
                                nombreLabel = nombremateria1;
                                diaLabel = diamateria1;
                                turnoLabel = turnomateria1;
                                cupoLabel = cuposmateria1;
                                break;
                            case 1:
                                nombreLabel = nombremateria2;
                                diaLabel = diamateria2;
                                turnoLabel = turnomateria2;
                                cupoLabel = cuposmateria2;
                                break;
                            case 2:
                                nombreLabel = nombremateria3;
                                diaLabel = diamateria3;
                                turnoLabel = turnomateria3;
                                cupoLabel = cuposmateria3;
                                break;
                            case 3:
                                nombreLabel = nombremateria4;
                                diaLabel = diamateria4;
                                turnoLabel = turnomateria4;
                                cupoLabel = cuposmateria4;
                                break;
                        }

                        if (nombreLabel != null)
                        {
                            nombreLabel.Text = reader["nombre"].ToString();
                            diaLabel.Text = reader["dia"].ToString();
                            turnoLabel.Text = reader["turno"].ToString();
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
            string queryValidation = "SELECT materia5 FROM estudiantes WHERE legajo = @Legajo";
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
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia5 = @Materia1 WHERE legajo = @Legajo";
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
            string queryValidation = "SELECT materia6 FROM estudiantes WHERE legajo = @Legajo";
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
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia6 = @Materia2 WHERE legajo = @Legajo";
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
            string queryValidation = "SELECT materia7 FROM estudiantes WHERE legajo = @Legajo";
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
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia7 = @Materia3 WHERE legajo = @Legajo";
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
            string queryValidation = "SELECT materia8 FROM estudiantes WHERE legajo = @Legajo";
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
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia8 = @Materia4 WHERE legajo = @Legajo";
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

        //valido que el estudiante no se inscriba a dos cursos en el mismo horario
        //private void validarHorario()
        //{
        //    //chequeo el horarioMin y HorarioMax de todas las materias
        //    string query = "SELECT horarioMin, horarioMax FROM cursos";
        //    using (MySqlCommand comando = new MySqlCommand(query, conexion))
        //    {
        //        conexion.Open();
        //        MySqlDataReader reader = comando.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            //si el horarioMin de la materia es mayor al horarioMax de la materia anterior
        //            //o si el horarioMax de la materia es menor al horarioMin de la materia anterior
        //            //entonces no hay conflicto de horarios
        //            if (horarioMin.Text > horarioMax.Text || horarioMax.Text < horarioMin.Text)
        //            {
        //                MessageBox.Show("No hay conflicto de horarios");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Hay conflicto de horarios");
        //            }
        //        }
        //        conexion.Close();
        //    }


        //}

    }
}
