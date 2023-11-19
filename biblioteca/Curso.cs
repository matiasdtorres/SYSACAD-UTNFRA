using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Curso
    {
        //Atributos de la clase Curso
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int CupoMaximo { get; set; }
        public string Profesor { get; set; }
        public string Aula { get; set; }
        public string Division { get; set; }
        public string Dia { get; set; }
        public string Turno { get; set; }
        public string Cuatrimestre { get; set; }

        public Curso(string nombre, string codigo, string descripcion, int cupoMaximo, string profesor, string aula, string division, string dia, string turno, string cuatrimestre)
        {
            Nombre = nombre;
            Codigo = codigo;
            Descripcion = descripcion;
            CupoMaximo = cupoMaximo;
            Profesor = profesor;
            Aula = aula;
            Division = division;
            Dia = dia;
            Cuatrimestre = cuatrimestre;
            Turno = turno;
        }

        //Metodo para Agregar un curso a la base de datos
        public int AgregarCurso()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "INSERT INTO cursos (nombre, codigo, descripcion, cupoMaximo, profesor, aula, division, dia, turno, cuatrimestre) VALUES (@Nombre, @Codigo, @Descripcion, @CupoMaximo, @Profesor, @Aula, @Division, @Dia, @Turno, @Cuatrimestre)";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Codigo", Codigo);
                comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                comando.Parameters.AddWithValue("@CupoMaximo", CupoMaximo);
                comando.Parameters.AddWithValue("@Profesor", Profesor);
                comando.Parameters.AddWithValue("@Aula", Aula);
                comando.Parameters.AddWithValue("@Division", Division);
                comando.Parameters.AddWithValue("@Dia", Dia);
                comando.Parameters.AddWithValue("@Turno", Turno);
                comando.Parameters.AddWithValue("@Cuatrimestre", Cuatrimestre);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }

        //Metodo para Editar un curso de la base de datos
        public int EditarCurso()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "UPDATE cursos SET nombre = @Nombre, codigo = @Codigo, descripcion = @Descripcion, cupoMaximo = @CupoMaximo, profesor = @Profesor, aula = @Aula, division = @Division, dia = @Dia, turno = @Turno, cuatrimestre = @Cuatrimestre WHERE codigo = @Codigo";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Codigo", Codigo);
                comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                comando.Parameters.AddWithValue("@CupoMaximo", CupoMaximo);
                comando.Parameters.AddWithValue("@Profesor", Profesor);
                comando.Parameters.AddWithValue("@Aula", Aula);
                comando.Parameters.AddWithValue("@Division", Division);
                comando.Parameters.AddWithValue("@Dia", Dia);
                comando.Parameters.AddWithValue("@Turno", Turno);
                comando.Parameters.AddWithValue("@Cuatrimestre", Cuatrimestre);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }

        //Metodo para eliminar Curso de la base de datos por codigo
        public int EliminarCurso()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "DELETE FROM cursos WHERE codigo = @Codigo";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Codigo", Codigo);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }
    }
}
