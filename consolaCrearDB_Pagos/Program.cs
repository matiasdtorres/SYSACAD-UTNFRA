using MySql.Data.MySqlClient;

namespace consolaCrearDB_Pagos
{
    internal class Program
    {
        static void Main()
        {
            string connectionString = "server=localhost;port=3306;database=sysacad;Uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                if (TableExists(connection, "pagos"))
                {
                    Console.WriteLine("La tabla 'pagos' ya existe.");
                }
                else
                {
                    CreateTable(connection, "pagos");
                    Console.WriteLine("Tabla 'pagos' creada con éxito.");
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
                matricula VARCHAR(50),
                mes1 VARCHAR(50),
                mes2 VARCHAR(50),
                mes3 VARCHAR(50),
                mes4 VARCHAR(50),
                mes5 VARCHAR(50),
                mes6 VARCHAR(50),
                mes7 VARCHAR(50),
                mes8 VARCHAR(50)
            )";

            using (MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection))
            {
                createTableCommand.ExecuteNonQuery();
            }
        }
    }
}