using MySql.Data.MySqlClient;

namespace consolaCrearDB_DatosPagos
{
    internal class Program
    {
        static void Main()
        {
            string connectionString = "server=localhost;port=3306;database=sysacad;Uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                if (TableExists(connection, "datos_pagos"))
                {
                    Console.WriteLine("La tabla 'datos_pagos' ya existe.");
                }
                else
                {
                    CreateTable(connection, "datos_pagos");
                    Console.WriteLine("Tabla 'datos_pagos' creada con éxito.");
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
                tipo VARCHAR(50),
                numero int,
                nombre VARCHAR(50),
                codigo int,
                vencimiento VARCHAR(50)
            )";

            using (MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection))
            {
                createTableCommand.ExecuteNonQuery();
            }
        }
    }
}