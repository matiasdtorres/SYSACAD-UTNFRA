using MySql.Data.MySqlClient;

namespace consolaCrearDB_ListaEspera
{
    internal class Program
    {
        static void Main()
        {
            string connectionString = "server=localhost;port=3306;database=sysacad;Uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                if (TableExists(connection, "listaEspera"))
                {
                    Console.WriteLine("La tabla 'listaEspera' ya existe.");
                }
                else
                {
                    CreateTable(connection, "listaEspera");
                    Console.WriteLine("Tabla 'listaEspera' creada con éxito.");
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
                materia VARCHAR(50),
                fecha VARCHAR(50),
                hora VARCHAR(50)
            )";

            using (MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection))
            {
                createTableCommand.ExecuteNonQuery();
            }
        }
    }
}