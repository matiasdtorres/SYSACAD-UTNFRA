using biblioteca;
using System.Data.SqlClient;

namespace ConsolaTests
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var hash = Hash.GetHash("1234");

    //        if (Hash.ValidatePassword("1234", hash))
    //        {
    //            Console.WriteLine("Password correcto");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Password incorrecto");
    //        }

    //        Console.WriteLine(hash);
    //    }
    //}
    class Program
    {
        static void Main()
        {
            string connectionString = "Data Source=DESKTOP-29H8DBT;Initial Catalog=sysacad;Integrated Security=True"; // Reemplaza con tu cadena de conexión
            string usuario = "matias";
            string contraseña = "123";

            // Hashear la contraseña utilizando la función en Hash.cs
            string contraseñaHasheada = Hash.GetHash(contraseña);

            // Insertar el administrador en la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Verificar si la tabla existe
                string checkTableQuery = "IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'admin') BEGIN CREATE TABLE admin (ID INT PRIMARY KEY IDENTITY(1,1), Usuario NVARCHAR(50) UNIQUE NOT NULL, Hash NVARCHAR(64) NOT NULL) END";
                using (SqlCommand checkTableCommand = new SqlCommand(checkTableQuery, connection))
                {
                    checkTableCommand.ExecuteNonQuery();
                }

                // Insertar el administrador en la base de datos
                string insertQuery = "INSERT INTO admin (Usuario, Hash) VALUES (@Usuario, @Contraseña)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
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