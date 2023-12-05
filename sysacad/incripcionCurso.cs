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
        MySqlConnection conexion2 = new MySqlConnection("server=localhost;port=3306;database=materias;Uid=root;pwd=;");

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

        private bool VerificarCorrelativa(string materiaObjetivo)
        {
            if (materiaObjetivo.EndsWith("1"))
            {
                return true;
            }

            string consultaCorrelativa = "SELECT * FROM cursos WHERE postmateria = @MateriaObjetivo";

            using (MySqlCommand comandoCorrelativa = new MySqlCommand(consultaCorrelativa, conexion))
            {
                comandoCorrelativa.Parameters.AddWithValue("@MateriaObjetivo", materiaObjetivo);

                try
                {
                    conexion.Open();
                    int countCorrelativa = Convert.ToInt32(comandoCorrelativa.ExecuteScalar());
                    return countCorrelativa > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar correlativa: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }


        //private bool VerificarNotasIguales(string nombreMateria, string legajoLogeado)
        //{
        //    string queryNotaFinal = $"SELECT notafinal FROM {nombreMateria.Replace(" ", "_")} WHERE legajo = {legajoLogeado}";
        //    string queryPrenota = $"SELECT prenota FROM cursos WHERE nombre = '{nombreMateria}'";

        //    try
        //    {
        //            conexion2.Open();

        //            using (MySqlCommand commandNotaFinal = new MySqlCommand(queryNotaFinal, conexion2))
        //            {
        //                object notaFinal = commandNotaFinal.ExecuteScalar();
        //                    conexion.Open();

        //                    using (MySqlCommand commandPrenota = new MySqlCommand(queryPrenota, conexion))
        //                    {
        //                        object prenota = commandPrenota.ExecuteScalar();

        //                        if (notaFinal != null && notaFinal.ToString().Equals("PROMOCIONADA"))
        //                        {
        //                            return true;
        //                        }
        //                        else
        //                        {
        //                            return false;
        //                        }
        //                    }
        //            }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //        return false;
        //    }
        //}




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
                    return;
                }

                conexion.Close();
            }


            // Obtener el cupoMaximo actual del curso
            string queryCupoMaximo = "SELECT cupoMaximo FROM cursos WHERE nombre = @Nombre";
            int cupoMaximo = 0;

            using (MySqlCommand comandoCupoMaximo = new MySqlCommand(queryCupoMaximo, conexion))
            {
                comandoCupoMaximo.Parameters.AddWithValue("@Nombre", nombremateria1.Text);
                conexion.Open();
                object cupoMaximoResult = comandoCupoMaximo.ExecuteScalar();
                if (cupoMaximoResult != null && cupoMaximoResult != DBNull.Value)
                {
                    cupoMaximo = Convert.ToInt32(cupoMaximoResult);
                }
                conexion.Close();
            }

            if (!VerificarCorrelativa(nombremateria1.Text))
            {
                MessageBox.Show($"No puedes inscribirte a {nombremateria1.Text} porque no cursaste la correlativa.");
                return;
            }

            if (!VerificarFechaLimite(nombremateria1.Text))
            {
                return;
            }


            // Verificar si hay cupo disponible o preguntar si quiere entrar en la lista de espera
            if (cupoMaximo <= 0)
            {
                DialogResult dialogResult = MessageBox.Show("El curso esta completo. ¿Quieres entrar en la lista de espera?", "Cupo completo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    // Verificar si el estudiante ya está en la lista de espera
                    string queryVerificarListaEspera = "SELECT COUNT(*) FROM listadeespera WHERE legajo = @Legajo AND nombremateria = @NombreMateria";
                    int countExistencia = 0;

                    using (MySqlCommand comandoVerificarListaEspera = new MySqlCommand(queryVerificarListaEspera, conexion))
                    {
                        comandoVerificarListaEspera.Parameters.AddWithValue("@Legajo", legajo.Text);
                        comandoVerificarListaEspera.Parameters.AddWithValue("@NombreMateria", nombremateria1.Text);

                        try
                        {
                            conexion.Open();
                            countExistencia = Convert.ToInt32(comandoVerificarListaEspera.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al verificar la lista de espera: " + ex.Message);
                        }
                        finally
                        {
                            conexion.Close();
                        }
                    }

                    if (countExistencia > 0)
                    {
                        MessageBox.Show($"Ya estas en la lista de espera para el curso de {nombremateria1.Text}");
                        return;
                    }
                    else
                    {
                        // Agregar al estudiante a la lista de espera
                        string queryListaEspera = "INSERT INTO listadeespera (legajo, nombremateria) VALUES (@Legajo, @NombreMateria)";
                        using (MySqlCommand comandoListaEspera = new MySqlCommand(queryListaEspera, conexion))
                        {
                            comandoListaEspera.Parameters.AddWithValue("@Legajo", legajo.Text);
                            comandoListaEspera.Parameters.AddWithValue("@NombreMateria", nombremateria1.Text);

                            try
                            {
                                conexion.Open();
                                comandoListaEspera.ExecuteNonQuery();
                                MessageBox.Show($"Te has añadido a la lista de espera para el curso de {nombremateria1.Text}");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al agregar a la lista de espera: " + ex.Message);
                            }
                            finally
                            {
                                conexion.Close();
                            }
                            return;
                        }
                    }
                }
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
                    //agregar estudiante a la base de datos

                    AgregarEstudianteAMateria(nombremateria1.Text, legajo.Text);
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

            if (!VerificarCorrelativa(nombremateria2.Text))
            {
                MessageBox.Show($"No puedes inscribirte a {nombremateria2.Text} porque no cursaste la correlativa.");
                return;
            }

            if (!VerificarFechaLimite(nombremateria2.Text))
            {
                return;
            }

            // Obtener el cupoMaximo actual del curso
            string queryCupoMaximo = "SELECT cupoMaximo FROM cursos WHERE nombre = @Nombre";
            int cupoMaximo = 0;

            using (MySqlCommand comandoCupoMaximo = new MySqlCommand(queryCupoMaximo, conexion))
            {
                comandoCupoMaximo.Parameters.AddWithValue("@Nombre", nombremateria2.Text);
                conexion.Open();
                object cupoMaximoResult = comandoCupoMaximo.ExecuteScalar();
                if (cupoMaximoResult != null && cupoMaximoResult != DBNull.Value)
                {
                    cupoMaximo = Convert.ToInt32(cupoMaximoResult);
                }
                conexion.Close();
            }

            // Verificar si hay cupo disponible o preguntar si quiere entrar en la lista de espera
            if (cupoMaximo <= 0)
            {
                DialogResult dialogResult = MessageBox.Show("El curso esta completo. ¿Quieres entrar en la lista de espera?", "Cupo completo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return; // Salir del método si no quiere entrar en la lista de espera
                }
                else
                {
                    // Verificar si el estudiante ya está en la lista de espera
                    string queryVerificarListaEspera = "SELECT COUNT(*) FROM listadeespera WHERE legajo = @Legajo AND nombremateria = @NombreMateria";
                    int countExistencia = 0;

                    using (MySqlCommand comandoVerificarListaEspera = new MySqlCommand(queryVerificarListaEspera, conexion))
                    {
                        comandoVerificarListaEspera.Parameters.AddWithValue("@Legajo", legajo.Text);
                        comandoVerificarListaEspera.Parameters.AddWithValue("@NombreMateria", nombremateria2.Text);

                        try
                        {
                            conexion.Open();
                            countExistencia = Convert.ToInt32(comandoVerificarListaEspera.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al verificar la lista de espera: " + ex.Message);
                        }
                        finally
                        {
                            conexion.Close();
                        }
                    }

                    if (countExistencia > 0)
                    {
                        MessageBox.Show($"Ya estas en la lista de espera para el curso de {nombremateria2.Text}");
                        return; // Salir del método si el estudiante ya está en la lista de espera
                    }
                    else
                    {
                        // Agregar al estudiante a la lista de espera
                        string queryListaEspera = "INSERT INTO listadeespera (legajo, nombremateria) VALUES (@Legajo, @NombreMateria)";
                        using (MySqlCommand comandoListaEspera = new MySqlCommand(queryListaEspera, conexion))
                        {
                            comandoListaEspera.Parameters.AddWithValue("@Legajo", legajo.Text);
                            comandoListaEspera.Parameters.AddWithValue("@NombreMateria", nombremateria2.Text);

                            try
                            {
                                conexion.Open();
                                comandoListaEspera.ExecuteNonQuery();
                                MessageBox.Show($"Te has añadido a la lista de espera para el curso de {nombremateria2.Text}");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al agregar a la lista de espera: " + ex.Message);
                            }
                            finally
                            {
                                conexion.Close();
                            }
                            return; // Salir del método después de agregar a la lista de espera
                        }
                    }
                }
            }

            // Actualizar la tabla estudiantes y cursos
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia2 = @Materia1 WHERE legajo = @Legajo";
            string queryUpdateCursos = "UPDATE cursos SET cupoMaximo = cupoMaximo - 1 WHERE nombre = @Nombre";

            using (MySqlCommand comandoUpdateEstudiantes = new MySqlCommand(queryUpdateEstudiantes, conexion))
            using (MySqlCommand comandoUpdateCursos = new MySqlCommand(queryUpdateCursos, conexion))
            {
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Materia1", nombremateria2.Text);
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Legajo", legajo.Text);

                comandoUpdateCursos.Parameters.AddWithValue("@Nombre", nombremateria2.Text);

                try
                {
                    conexion.Open();
                    comandoUpdateEstudiantes.ExecuteNonQuery();
                    comandoUpdateCursos.ExecuteNonQuery();
                    //agregar estudiante a la base de datos

                    AgregarEstudianteAMateria(nombremateria2.Text, legajo.Text);
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

            if (!VerificarCorrelativa(nombremateria3.Text))
            {
                MessageBox.Show($"No puedes inscribirte a {nombremateria3.Text} porque no cursaste la correlativa.");
                return;
            }

            if (!VerificarFechaLimite(nombremateria3.Text))
            {
                return;
            }


            // Obtener el cupoMaximo actual del curso
            string queryCupoMaximo = "SELECT cupoMaximo FROM cursos WHERE nombre = @Nombre";
            int cupoMaximo = 0;

            using (MySqlCommand comandoCupoMaximo = new MySqlCommand(queryCupoMaximo, conexion))
            {
                comandoCupoMaximo.Parameters.AddWithValue("@Nombre", nombremateria3.Text);
                conexion.Open();
                object cupoMaximoResult = comandoCupoMaximo.ExecuteScalar();
                if (cupoMaximoResult != null && cupoMaximoResult != DBNull.Value)
                {
                    cupoMaximo = Convert.ToInt32(cupoMaximoResult);
                }
                conexion.Close();
            }

            // Verificar si hay cupo disponible o preguntar si quiere entrar en la lista de espera
            if (cupoMaximo <= 0)
            {
                DialogResult dialogResult = MessageBox.Show("El curso está completo. ¿Quieres entrar en la lista de espera?", "Cupo completo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return; // Salir del método si no quiere entrar en la lista de espera
                }
                else
                {
                    // Verificar si el estudiante ya está en la lista de espera
                    string queryVerificarListaEspera = "SELECT COUNT(*) FROM listadeespera WHERE legajo = @Legajo AND nombremateria = @NombreMateria";
                    int countExistencia = 0;

                    using (MySqlCommand comandoVerificarListaEspera = new MySqlCommand(queryVerificarListaEspera, conexion))
                    {
                        comandoVerificarListaEspera.Parameters.AddWithValue("@Legajo", legajo.Text);
                        comandoVerificarListaEspera.Parameters.AddWithValue("@NombreMateria", nombremateria3.Text);

                        try
                        {
                            conexion.Open();
                            countExistencia = Convert.ToInt32(comandoVerificarListaEspera.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al verificar la lista de espera: " + ex.Message);
                        }
                        finally
                        {
                            conexion.Close();
                        }
                    }

                    if (countExistencia > 0)
                    {
                        MessageBox.Show($"Ya estás en la lista de espera para el curso de {nombremateria3.Text}");
                        return; // Salir del método si el estudiante ya está en la lista de espera
                    }
                    else
                    {
                        // Agregar al estudiante a la lista de espera
                        string queryListaEspera = "INSERT INTO listadeespera (legajo, nombremateria) VALUES (@Legajo, @NombreMateria)";
                        using (MySqlCommand comandoListaEspera = new MySqlCommand(queryListaEspera, conexion))
                        {
                            comandoListaEspera.Parameters.AddWithValue("@Legajo", legajo.Text);
                            comandoListaEspera.Parameters.AddWithValue("@NombreMateria", nombremateria3.Text);

                            try
                            {
                                conexion.Open();
                                comandoListaEspera.ExecuteNonQuery();
                                MessageBox.Show($"Te has añadido a la lista de espera para el curso de {nombremateria3.Text}");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al agregar a la lista de espera: " + ex.Message);
                            }
                            finally
                            {
                                conexion.Close();
                            }
                            return; // Salir del método después de agregar a la lista de espera
                        }
                    }
                }
            }

            // Actualizar la tabla estudiantes y cursos
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia3 = @Materia1 WHERE legajo = @Legajo";
            string queryUpdateCursos = "UPDATE cursos SET cupoMaximo = cupoMaximo - 1 WHERE nombre = @Nombre";

            using (MySqlCommand comandoUpdateEstudiantes = new MySqlCommand(queryUpdateEstudiantes, conexion))
            using (MySqlCommand comandoUpdateCursos = new MySqlCommand(queryUpdateCursos, conexion))
            {
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Materia1", nombremateria3.Text);
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Legajo", legajo.Text);

                comandoUpdateCursos.Parameters.AddWithValue("@Nombre", nombremateria3.Text);

                try
                {
                    conexion.Open();
                    comandoUpdateEstudiantes.ExecuteNonQuery();
                    comandoUpdateCursos.ExecuteNonQuery();
                    //agregar estudiante a la base de datos

                    AgregarEstudianteAMateria(nombremateria3.Text, legajo.Text);
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
                    MessageBox.Show($"Ya estas inscrito en el curso de {nombremateria4.Text}");
                    conexion.Close();
                    return; // Salir del método si el estudiante ya está inscrito
                }

                conexion.Close();
            }

            if (!VerificarCorrelativa(nombremateria4.Text))
            {
                MessageBox.Show($"No puedes inscribirte a {nombremateria4.Text} porque no cursaste la correlativa.");
                return;
            }

            if (!VerificarFechaLimite(nombremateria4.Text))
            {
                return;
            }


            // Obtener el cupoMaximo actual del curso
            string queryCupoMaximo = "SELECT cupoMaximo FROM cursos WHERE nombre = @Nombre";
            int cupoMaximo = 0;

            using (MySqlCommand comandoCupoMaximo = new MySqlCommand(queryCupoMaximo, conexion))
            {
                comandoCupoMaximo.Parameters.AddWithValue("@Nombre", nombremateria4.Text);
                conexion.Open();
                object cupoMaximoResult = comandoCupoMaximo.ExecuteScalar();
                if (cupoMaximoResult != null && cupoMaximoResult != DBNull.Value)
                {
                    cupoMaximo = Convert.ToInt32(cupoMaximoResult);
                }
                conexion.Close();
            }

            // Verificar si hay cupo disponible o preguntar si quiere entrar en la lista de espera
            if (cupoMaximo <= 0)
            {
                DialogResult dialogResult = MessageBox.Show("El curso esta completo. ¿Quieres entrar en la lista de espera?", "Cupo completo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return; // Salir del método si no quiere entrar en la lista de espera
                }
                else
                {
                    // Verificar si el estudiante ya está en la lista de espera
                    string queryVerificarListaEspera = "SELECT COUNT(*) FROM listadeespera WHERE legajo = @Legajo AND nombremateria = @NombreMateria";
                    int countExistencia = 0;

                    using (MySqlCommand comandoVerificarListaEspera = new MySqlCommand(queryVerificarListaEspera, conexion))
                    {
                        comandoVerificarListaEspera.Parameters.AddWithValue("@Legajo", legajo.Text);
                        comandoVerificarListaEspera.Parameters.AddWithValue("@NombreMateria", nombremateria4.Text);

                        try
                        {
                            conexion.Open();
                            countExistencia = Convert.ToInt32(comandoVerificarListaEspera.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al verificar la lista de espera: " + ex.Message);
                        }
                        finally
                        {
                            conexion.Close();
                        }
                    }

                    if (countExistencia > 0)
                    {
                        MessageBox.Show($"Ya estas en la lista de espera para el curso de {nombremateria4.Text}");
                        return; // Salir del método si el estudiante ya está en la lista de espera
                    }
                    else
                    {
                        // Agregar al estudiante a la lista de espera
                        string queryListaEspera = "INSERT INTO listadeespera (legajo, nombremateria) VALUES (@Legajo, @NombreMateria)";
                        using (MySqlCommand comandoListaEspera = new MySqlCommand(queryListaEspera, conexion))
                        {
                            comandoListaEspera.Parameters.AddWithValue("@Legajo", legajo.Text);
                            comandoListaEspera.Parameters.AddWithValue("@NombreMateria", nombremateria4.Text);

                            try
                            {
                                conexion.Open();
                                comandoListaEspera.ExecuteNonQuery();
                                MessageBox.Show($"Te has añadido a la lista de espera para el curso de {nombremateria4.Text}");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al agregar a la lista de espera: " + ex.Message);
                            }
                            finally
                            {
                                conexion.Close();
                            }
                            return; // Salir del método después de agregar a la lista de espera
                        }
                    }
                }
            }

            // Actualizar la tabla estudiantes y cursos
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia4 = @Materia1 WHERE legajo = @Legajo";
            string queryUpdateCursos = "UPDATE cursos SET cupoMaximo = cupoMaximo - 1 WHERE nombre = @Nombre";

            using (MySqlCommand comandoUpdateEstudiantes = new MySqlCommand(queryUpdateEstudiantes, conexion))
            using (MySqlCommand comandoUpdateCursos = new MySqlCommand(queryUpdateCursos, conexion))
            {
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Materia1", nombremateria4.Text);
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Legajo", legajo.Text);

                comandoUpdateCursos.Parameters.AddWithValue("@Nombre", nombremateria4.Text);

                try
                {
                    conexion.Open();
                    comandoUpdateEstudiantes.ExecuteNonQuery();
                    comandoUpdateCursos.ExecuteNonQuery();
                    //agregar estudiante a la base de datos

                    AgregarEstudianteAMateria(nombremateria4.Text, legajo.Text);
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

        //Metodo para agregar un estudiante a una tabla de Materias
        private void AgregarEstudianteAMateria(string nombreTabla, string legajoLogeado)
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=materias;Uid=root;pwd=;"))
            {
                conexion.Open();

                string queryInsertarEstudiante = $@"
                INSERT INTO {nombreTabla.Replace(" ", "_")} (legajo) 
                VALUES ('{legajoLogeado}')";

                using (MySqlCommand insertarEstudiante = new MySqlCommand(queryInsertarEstudiante, conexion))
                {
                    insertarEstudiante.ExecuteNonQuery();
                }
            }
        }

        private bool VerificarFechaLimite(string nombreCurso)
        {
            string queryFechaLimite = "SELECT fechalimite FROM cursos WHERE nombre = @Nombre";
            DateTime fechaLimite;

            using (MySqlCommand comandoFechaLimite = new MySqlCommand(queryFechaLimite, conexion))
            {
                comandoFechaLimite.Parameters.AddWithValue("@Nombre", nombreCurso);

                try
                {
                    conexion.Open();
                    object fechaLimiteResult = comandoFechaLimite.ExecuteScalar();

                    if (fechaLimiteResult != null && fechaLimiteResult != DBNull.Value)
                    {
                        fechaLimite = Convert.ToDateTime(fechaLimiteResult);

                        if (DateTime.Now > fechaLimite)
                        {
                            MessageBox.Show($"La fecha limite para inscribirse en {nombreCurso} ya paso.");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar la fecha límite: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.Close();
                }
            }

            return true;
        }

    }
}
