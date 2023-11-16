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

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que el estudiante no esté inscrito en el curso
            string queryValidation = "SELECT materia1 FROM estudiantes WHERE legajo = @Legajo";
            using (MySqlCommand comandoValidation = new MySqlCommand(queryValidation, conexion))
            {
                comandoValidation.Parameters.AddWithValue("@Legajo", legajo.Text);
                conexion.Open();
                object result = comandoValidation.ExecuteScalar();
                if (result != null && result != DBNull.Value && result.ToString() == "Matematica")
                {
                    MessageBox.Show("Ya estás inscrito en este curso");
                    conexion.Close();
                    return; // Salir del método si el estudiante ya está inscrito
                }
                conexion.Close();
            }

            // Actualizar la tabla estudiantes y cursos
            string queryUpdateEstudiantes = "UPDATE estudiantes SET materia1 = @Matematica WHERE legajo = @Legajo";
            string queryUpdateCursos = "UPDATE cursos SET cupoMaximo = cupoMaximo - 1 WHERE nombre = @Nombre";

            using (MySqlCommand comandoUpdateEstudiantes = new MySqlCommand(queryUpdateEstudiantes, conexion))
            using (MySqlCommand comandoUpdateCursos = new MySqlCommand(queryUpdateCursos, conexion))
            {
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Matematica", "Matematica");
                comandoUpdateEstudiantes.Parameters.AddWithValue("@Legajo", legajo.Text);

                comandoUpdateCursos.Parameters.AddWithValue("@Nombre", "Matematica");

                try
                {
                    conexion.Open();
                    comandoUpdateEstudiantes.ExecuteNonQuery();
                    comandoUpdateCursos.ExecuteNonQuery();
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
