using biblioteca;
using System;
using MySql.Data.MySqlClient;

namespace ConsolaTests
{
    public class Program
    {
        static void Main()
        {
            string connectionString = "server=localhost;port=3306;database=sysacad;Uid=root;pwd=;";
            string usuario = "matias";
            string contraseña = "123";

            // Hashear la contraseña utilizando la función en Hash.cs
            string contraseñaHasheada = Hash.GetHash(contraseña);

            // Insertar el administrador en la base de datos
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Verificar si la tabla existe
                string checkTableQuery = "CREATE TABLE IF NOT EXISTS admin (ID INT AUTO_INCREMENT PRIMARY KEY, Usuario NVARCHAR(50) UNIQUE NOT NULL, Hash NVARCHAR(64) NOT NULL)";
                using (MySqlCommand checkTableCommand = new MySqlCommand(checkTableQuery, connection))
                {
                    checkTableCommand.ExecuteNonQuery();
                }

                // Insertar el administrador en la base de datos
                string insertQuery = "INSERT INTO admin (Usuario, Hash) VALUES (@Usuario, @Contraseña)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseñaHasheada);

                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Administrador insertado correctamente.");
        }
    }
}
