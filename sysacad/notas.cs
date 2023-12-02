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
    public partial class notas : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        private MySqlConnection conexion2 = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        private MySqlConnection conexion3 = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public notas(string profeLogeado)
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

            // Obtener el número de nota seleccionado
            string numeronota = numeronotatxt.SelectedItem.ToString();

            // Obtener el estado de nota seleccionado
            string estadonota = estadonotatxt.SelectedItem.ToString();

            // Obtener el nombre de la materia seleccionada
            string materiaSeleccionada = materiatxt.SelectedItem.ToString();

            // Agregar la nota al estudiante en la materia seleccionada
            AgregarNotaFinal(materiaSeleccionada, nombreCompletoAlumno, numeronota, estadonota);
        }


        // Función para verificar si existe una nota para un estudiante y un tipo de nota específico

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
                                // Obtener el legajo
                                legajo = reader["legajo"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el legajo del alumno seleccionado.");
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


        private void AgregarNotaFinal(string nombreTabla, string legajoseleccionado, string numeronota, string notaFinal)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=materias;Uid=root;pwd=;"))
                {
                    conexion.Open();

                    using (MySqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            // Verificar si las notas parciales han sido registradas
                            if (numeronota == "notafinal" && (!ExisteNota(nombreTabla, legajoseleccionado, "parcial1") || !ExisteNota(nombreTabla, legajoseleccionado, "parcial2")))
                            {
                                MessageBox.Show("No se puede ingresar la nota final si no hay notas en parcial1 y parcial2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Verificar si hay notas del parcial1 para permitir la nota del recu1
                            if (numeronota == "recu1" && !ExisteNota(nombreTabla, legajoseleccionado, "parcial1"))
                            {
                                MessageBox.Show("No se puede ingresar el recu1 si no hay notas en parcial1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Verificar si las notas parciales han sido registradas
                            if (numeronota == "recu2" && (!ExisteNota(nombreTabla, legajoseleccionado, "parcial1") || !ExisteNota(nombreTabla, legajoseleccionado, "recu1") || !ExisteNota(nombreTabla, legajoseleccionado, "parcial2")))
                            {
                                MessageBox.Show("No se puede ingresar del recu2 si no hay notas en parcial1 (o recu1) y parcial2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (numeronota == "parcial2" && !ExisteNota(nombreTabla, legajoseleccionado, "parcial1") && !ExisteNota(nombreTabla, legajoseleccionado, "recu1"))
                            {
                                MessageBox.Show("Debe cargar la nota del parcial1 o recu1 antes de cargar la nota del parcial2.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Verificar si la nota final ya ha sido registrada anteriormente
                            if (ExisteNota(nombreTabla, legajoseleccionado, numeronota))
                            {
                                MessageBox.Show($"La {numeronota} ya ha sido registrada anteriormente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Insertar la nota final
                            string queryInsertarNotaFinal = $@"
                            UPDATE {nombreTabla.Replace(" ", "_")} SET {numeronota} = @notaFinal WHERE legajo = @legajoseleccionado";

                            using (MySqlCommand insertarNotaFinal = new MySqlCommand(queryInsertarNotaFinal, conexion, transaccion))
                            {
                                insertarNotaFinal.Parameters.AddWithValue("@notaFinal", notaFinal);
                                insertarNotaFinal.Parameters.AddWithValue("@legajoseleccionado", legajoseleccionado);

                                insertarNotaFinal.ExecuteNonQuery();

                                MessageBox.Show($"Nota {numeronota} cargada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                transaccion.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw; // Lanzar la excepción para que se maneje en el bloque catch externo
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al actualizar la nota: {ex.Message}", "Error de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteNota(string nombreTabla, string legajoseleccionado, string nombreNota)
        {
            string queryVerificarNota = $@"SELECT COUNT(*) FROM {nombreTabla.Replace(" ", "_")} WHERE legajo = @legajoseleccionado AND {nombreNota} IS NOT NULL";

            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=materias;Uid=root;pwd=;"))
            {
                conexion.Open();

                using (MySqlCommand verificarNota = new MySqlCommand(queryVerificarNota, conexion))
                {
                    verificarNota.Parameters.AddWithValue("@legajoseleccionado", legajoseleccionado);

                    int count = Convert.ToInt32(verificarNota.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}
