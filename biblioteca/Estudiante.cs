using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace biblioteca
{
    //Clase estudiante que hereda de la clase Usuarios
    public class Estudiante : Usuarios
    {
        //Atributos propios de la clase Estudiante
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        //Constructor de la clase Estudiante
        public Estudiante(int legajo, string nombre, string apellido, string direccion, string telefono, string email, string contraseña) : base(nombre, contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Legajo = legajo;
        }

        //Metodo para que el estudiante cambie su contraseña
        public void CambiarContraseña(string nuevaContraseña)
        {
            // Hash de la nueva contraseña
            Contraseña = Hash.GetHash(nuevaContraseña);
        }

        //Metodo para agregar un estudiante a la base de datos
        public int AgregarEstudiante()
        {
            using (conexion)
            {
                conexion.Open();
                string query = "INSERT INTO estudiantes (legajo, nombre, apellido, direccion, telefono, email, contraseña) VALUES (@Legajo, @Nombre, @Apellido, @Direccion, @Telefono, @Email, @Contraseña)";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Legajo", Legajo);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }
    }
}
