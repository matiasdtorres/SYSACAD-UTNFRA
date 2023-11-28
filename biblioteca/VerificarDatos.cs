using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class VerificarDatos
    {
        private const string ConnectionString = "server=localhost;port=3306;database=sysacad;Uid=root;pwd=;";


        public static bool VerificoAdmin(string usuario, string contraseña)
        {
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                conexion.Open();
                string query = "SELECT hash FROM admin WHERE usuario = @Usuario";

                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuario);

                    object result = comando.ExecuteScalar();

                    if (result != null)
                    {
                        string hash = result.ToString();
                        return Hash.ValidatePassword(contraseña, hash);
                    }
                }
            }

            return false;
        }

        //ahora para Estudiante
        public static bool VerificoEstudiante(string legajo, string contraseña)
        {
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                conexion.Open();
                string query = "SELECT contraseña FROM estudiantes WHERE legajo = @Legajo";

                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Legajo", legajo);

                    object result = comando.ExecuteScalar();

                    if (result != null)
                    {
                        string hash = result.ToString();
                        return Hash.ValidatePassword(contraseña, hash);
                    }
                }
            }

            return false;
        }

        //ahora para Profesor
        public static bool VerificoProfesor(string usuario, string contraseña)
        {
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                conexion.Open();
                string query = "SELECT contraseña FROM profesores WHERE usuario = @Usuario";

                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuario);

                    object result = comando.ExecuteScalar();

                    if (result != null)
                    {
                        string hash = result.ToString();
                        return Hash.ValidatePassword(contraseña, hash);
                    }
                }
            }

            return false;
        }
    }
}
