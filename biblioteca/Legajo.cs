using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class ManejadorEstudiantes
    {

        public bool ObtenerUltimoLegajo(out int ultimoLegajo)
        {
            ultimoLegajo = 10000;

            try
            {
                using (SqlConnection conexion = new SqlConnection("server=DESKTOP-29H8DBT; database=sysacad ;integrated Security=True; TrustServerCertificate=true"))
                {
                    conexion.Open();

                    string consulta = "SELECT MAX(legajo) FROM Estudiantes";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        object resultado = comando.ExecuteScalar();
                        if (resultado != null && resultado != DBNull.Value)
                        {
                            ultimoLegajo = Convert.ToInt32(resultado);
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                // Puedes omitir la gestión de excepciones aquí y manejarlas en el formulario
                return false;
            }
        }
    }
}
