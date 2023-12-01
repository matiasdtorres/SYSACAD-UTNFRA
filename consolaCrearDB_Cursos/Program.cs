using MySql.Data.MySqlClient;

namespace consolaCrearDB_Cursos
{
    public class Program
    {
        static void Main()
        {
            string connectionString = "server=localhost;port=3306;database=sysacad;Uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                if (TableExists(connection, "cursos"))
                {
                    Console.WriteLine("La tabla 'cursos' ya existe.");
                }
                else
                {
                    CreateTable(connection, "cursos");
                    Console.WriteLine("Tabla 'cursos' creada con éxito.");
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
                codigo int AUTO_INCREMENT primary key,
                nombre VARCHAR(50),
                descripcion VARCHAR(50),
                cupoMaximo int,
                profesor VARCHAR(50),
                aula VARCHAR(50),
                division VARCHAR(50),
                dia VARCHAR(50),
                turno VARCHAR(50),
                cuatrimestre VARCHAR(50),
                fechalimite VARCHAR(50)
            )";

            using (MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection))
            {
                createTableCommand.ExecuteNonQuery();
            }
        }
    }
}