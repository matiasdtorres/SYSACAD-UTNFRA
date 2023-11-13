using System.Data.SqlClient;

namespace consolaCrearDB_Estudiantes
{
    public class Program
    {
        static void Main()
        {
            string connectionString = "Data Source=DESKTOP-29H8DBT;Initial Catalog=sysacad;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
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

        static bool TableExists(SqlConnection connection, string tableName)
        {
            string checkTableQuery = $@"
            SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";

            using (SqlCommand checkTableCommand = new SqlCommand(checkTableQuery, connection))
            {
                using (SqlDataReader reader = checkTableCommand.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        static void CreateTable(SqlConnection connection, string tableName)
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
                hash NVARCHAR(128)
            )";

            using (SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection))
            {
                createTableCommand.ExecuteNonQuery();
            }
        }
    }
}