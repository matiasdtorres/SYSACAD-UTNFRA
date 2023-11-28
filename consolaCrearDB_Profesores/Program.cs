using MySql.Data.MySqlClient;

namespace consolaCrearDB_Profesores
{
    internal class Program
    {
        static void Main()
        {
            string connectionString = "server=localhost;port=3306;database=sysacad;Uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                if (TableExists(connection, "profesores"))
                {
                    Console.WriteLine("La tabla 'profesores' ya existe.");
                }
                else
                {
                    CreateTable(connection, "profesores");
                    Console.WriteLine("Tabla 'profesores' creada con éxito.");
                }

                connection.Close();
            }
        }

        static bool TableExists(MySqlConnection connection, string tableName)
        {
            string checkTableQuery = $@"
            SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";

            using (MySqlCommand checkTableCommand = new MySqlCommand(checkTableQuery, connection))
            {
                using (MySqlDataReader reader = checkTableCommand.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        static void CreateTable(MySqlConnection connection, string tableName)
        {
            string createTableQuery = $@"
            CREATE TABLE {tableName}
            (
                ID INT AUTO_INCREMENT primary key,
                usuario VARCHAR(50),
                nombre VARCHAR(50),
                apellido VARCHAR(50),
                telefono VARCHAR(50),
                direccion VARCHAR(50),
                email VARCHAR(50),
                especializacion VARCHAR(50),
                contraseña NVARCHAR(128)
            )";

            using (MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection))
            {
                createTableCommand.ExecuteNonQuery();
            }
        }
    }
}