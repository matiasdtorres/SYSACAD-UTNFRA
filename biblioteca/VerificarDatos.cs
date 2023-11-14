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

                    //chequea si la contraseña de contraseñaTemporaltxt es igual a la contraseña de la base de datos (todo es sin hash)
                    //MySqlDataReader reader = comando.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    if (reader["contraseña"].ToString() == contraseña)
                    //    {
                    //        return true;
                    //    }
                    //}
                }
            }

            return false;
        }
    }
}
