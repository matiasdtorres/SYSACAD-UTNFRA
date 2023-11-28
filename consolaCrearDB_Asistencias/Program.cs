using MySql.Data.MySqlClient;

namespace consolaCrearDB_Asistencias
{
    internal class Program
    {
        static void Main()
        {
            string connectionString = "server=localhost;port=3306;database=sysacad;Uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                if (TableExists(connection, "estudiantes"))
                {
                    Console.WriteLine("La tabla 'estudiantes' ya existe.");
                }
                else
                {
                    CreateTable(connection, "estudiantes");
                    Console.WriteLine("Tabla 'estudiantes' creada con éxito.");
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
                legajo int primary key,
                nombre VARCHAR(50),
                apellido VARCHAR(50),
                direccion VARCHAR(50),
                telefono VARCHAR(50),
                email VARCHAR(50),
                contraseña NVARCHAR(128),
                materia1 VARCHAR(50),
                materia2 VARCHAR(50),
                materia3 VARCHAR(50),
                materia4 VARCHAR(50),
                materia5 VARCHAR(50),
                materia6 VARCHAR(50),
                materia7 VARCHAR(50),
                materia8 VARCHAR(50)
            )";

            using (MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection))
            {
                createTableCommand.ExecuteNonQuery();
            }
        }
    }
}