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
    public partial class listasDeEspera : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public listasDeEspera()
        {
            InitializeComponent();
            materias();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(legajotxt.Text) || string.IsNullOrWhiteSpace(materiatxt.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            string legajo = legajotxt.Text;
            string materia = materiatxt.Text;

            if (!ExisteEnBaseDeDatos("SELECT * FROM estudiantes WHERE legajo = @legajo", new Dictionary<string, object> { { "@legajo", legajo } }))
            {
                MessageBox.Show("El legajo no existe");
                return;
            }

            Dictionary<string, object> parametrosCurso = new Dictionary<string, object> { { "@materia", materia } };
            if (!ExisteEnBaseDeDatos("SELECT * FROM cursos WHERE nombre = @materia AND cupoMaximo = 0", parametrosCurso))
            {
                MessageBox.Show("La materia tiene cupos disponible");
                return;
            }

            if (ExisteEnBaseDeDatos("SELECT * FROM listadeespera WHERE legajo = @legajo AND nombremateria = @nombremateria",
                                    new Dictionary<string, object> { { "@legajo", legajo }, { "@nombremateria", materia } }))
            {
                MessageBox.Show("El estudiante ya esta en lista de espera para esta materia");
            }
            else
            {
                using (MySqlCommand comando = new MySqlCommand("INSERT INTO listadeespera (legajo, nombremateria) VALUES (@legajo, @nombremateria)", conexion))
                {
                    comando.Parameters.AddWithValue("@legajo", legajo);
                    comando.Parameters.AddWithValue("@nombremateria", materia);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Estudiante agregado a la lista de espera");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar a la lista de espera: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
        }


        //esta metodo magico verifica si existe en la base de datos. ni yo se como funciona esto. pero lo hace
        private bool ExisteEnBaseDeDatos(string query, Dictionary<string, object> parametros)
        {
            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {
                foreach (var parametro in parametros)
                {
                    comando.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                try
                {
                    conexion.Open();
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la consulta: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }


        //traigo todas las materias de la base de datos
        private void materias()
        {
            string query = "SELECT * FROM cursos";

            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {
                try
                {
                    conexion.Open();
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            materiatxt.Items.Add(reader["nombre"].ToString());
                            materiaeliminartxt.Items.Add(reader["nombre"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las materias: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(legajoeliminartxt.Text) || string.IsNullOrWhiteSpace(materiaeliminartxt.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            string legajo = legajoeliminartxt.Text;
            string materia = materiaeliminartxt.Text;

            if (!ExisteEnBaseDeDatos("SELECT * FROM estudiantes WHERE legajo = @legajo", new Dictionary<string, object> { { "@legajo", legajo } }))
            {
                MessageBox.Show("El legajo no existe");
                return;
            }

            if (!ExisteEnBaseDeDatos("SELECT * FROM listadeespera WHERE legajo = @legajo AND nombremateria = @nombremateria",
                                                   new Dictionary<string, object> { { "@legajo", legajo }, { "@nombremateria", materia } }))
            {
                MessageBox.Show("El estudiante no esta en lista de espera para esta materia");
            }
            else
            {
                using (MySqlCommand comando = new MySqlCommand("DELETE FROM listadeespera WHERE legajo = @legajo AND nombremateria = @nombremateria", conexion))
                {
                    comando.Parameters.AddWithValue("@legajo", legajo);
                    comando.Parameters.AddWithValue("@nombremateria", materia);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Estudiante eliminado de la lista de espera");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar de la lista de espera: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
        }
    }
}
