using MySql.Data.MySqlClient;
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
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
                {
                    conexion.Open();

                    string consulta = "SELECT MAX(legajo) FROM Estudiantes";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
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
