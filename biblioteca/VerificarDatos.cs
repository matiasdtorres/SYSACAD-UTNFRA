using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class VerificarDatos
    {
        public static bool VerificoAdmin(string usuario, string contraseña)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-29H8DBT; database=sysacad ;integrated Security=True; TrustServerCertificate=true");

            using (conexion)
            {
                conexion.Open();
                string query = "SELECT * FROM admin WHERE usuario = @Usuario";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Usuario", usuario);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    string hash = leer["hash"].ToString();

                    if (Hash.ValidatePassword(contraseña, hash))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
        }

        public static bool VerificoEstudiante(string legajo, string contraseña)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-29H8DBT; database=sysacad ;integrated Security=True; TrustServerCertificate=true");

            using (conexion)
            {
                conexion.Open();
                string query = "SELECT * FROM estudiantes WHERE legajo = @Legajo";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Legajo", legajo);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    string hash = leer["hash"].ToString();

                    if (Hash.ValidatePassword(contraseña, hash))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
