using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Profesores : Usuarios
    {
        //Atributos propios de la clase Profesores
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Especializacion { get; set; }

        //Constructor de la clase Profesores
        public Profesores(string usuario, string nombre, string apellido, string telefono, string direccion, string email, string contraseña, string especializacion) : base(usuario, contraseña)
        {
            Usuario = usuario;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            Especializacion = especializacion;
        }

        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        //Metodo para que el profesor cambie su contraseña
        public void CambiarContraseña(string nuevaContraseña)
        {
            // Hash de la nueva contraseña
            Contraseña = Hash.GetHash(nuevaContraseña);
        }

        //Metodo para agregar un profesor a la base de datos
        public int AgregarProfesor()
        {
            using (conexion)
            {
                conexion.Open();
                string query = "INSERT INTO profesores (usuario, nombre, apellido, telefono, direccion, email, especializacion, contraseña) VALUES (@Usuario, @Nombre, @Apellido, @Telefono, @Direccion, @Email, @Especializacion, @Contraseña)";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Usuario", Usuario);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Especializacion", Especializacion);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }

        //Metodo para Editar un profesor de la base de datos
        public int EditarProfesor()
        {
            using (conexion)
            {
                conexion.Open();
                string query = "UPDATE profesores SET usuario = @Usuario, nombre = @Nombre, apellido = @Apellido, telefono = @Telefono, direccion = @Direccion, email = @Email, especializacion = @Especializacion, contraseña = @Contraseña WHERE usuario = @Usuario";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Usuario", Usuario);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Especializacion", Especializacion);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }

        //Metodo para eliminar Profesor de la base de datos por usuario
        public int EliminarProfesor()
        {
            using (conexion)
            {
                conexion.Open();
                string query = "DELETE FROM profesores WHERE usuario = @Usuario";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Usuario", Usuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }

        //Metodo para que el profesor inserte asistencia de un legajo
        internal int InsertarAsistencia(string legajo, string fecha, string columnaAsistencia)
        {
            using (conexion)
            {
                conexion.Open();

                if (!EsColumnaAsistenciaValida(columnaAsistencia))
                {
                    return 0;
                }

                // Utiliza parámetros para evitar la inyección de SQL
                string query = $"UPDATE asistencia SET {columnaAsistencia} = @Fecha WHERE legajo = @Legajo";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@Legajo", legajo);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }

        // Método para validar que la columnaAsistencia sea segura
        private bool EsColumnaAsistenciaValida(string columnaAsistencia)
        {

            List<string> columnasPermitidas = new List<string> { "asistencia1", "asistencia2", "asistencia3", "asistencia4", "asistencia5" };
            return columnasPermitidas.Contains(columnaAsistencia);
        }
    }
}
