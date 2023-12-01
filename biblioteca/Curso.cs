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
        public string Fechalimite { get; set; }

        public Curso(string nombre, string codigo, string descripcion, int cupoMaximo, string profesor, string aula, string division, string dia, string turno, string cuatrimestre, string fechalimite)
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
            Fechalimite = fechalimite;
        }

        //Metodo para Agregar un curso a la base de datos
        public int AgregarCurso()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "INSERT INTO cursos (nombre, codigo, descripcion, cupoMaximo, profesor, aula, division, dia, turno, cuatrimestre, fechalimite) VALUES (@Nombre, @Codigo, @Descripcion, @CupoMaximo, @Profesor, @Aula, @Division, @Dia, @Turno, @Cuatrimestre, @FechaLimite)";
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
                comando.Parameters.AddWithValue("@FechaLimite", Fechalimite);

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
                string query = "UPDATE cursos SET nombre = @Nombre, codigo = @Codigo, descripcion = @Descripcion, cupoMaximo = @CupoMaximo, profesor = @Profesor, aula = @Aula, division = @Division, dia = @Dia, turno = @Turno, cuatrimestre = @Cuatrimestre, fechalimite = @FechaLimite WHERE codigo = @Codigo";
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
                comando.Parameters.AddWithValue("@FechaLimite", Fechalimite);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }

        //Metodo para eliminar Curso de la base de datos por nombre
        public int EliminarCurso()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "DELETE FROM cursos WHERE nombre = @Nombre";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Nombre", Nombre);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }

        // metodo para crear una tabla por cada curso que se cree (para guardar las notas y asistencias de los alumnos)
        public void CreateTable()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=materias;Uid=root;pwd=;"))
            {
                conexion.Open();

                string querycreartabla = $@"
                CREATE TABLE {Nombre.Replace(" ", "_")}  -- Reemplaza los espacios en blanco con guiones bajos
                (
                    ID int AUTO_INCREMENT primary key,
                    legajo VARCHAR(50),
                    asistencia1 VARCHAR(50),
                    asistencia2 VARCHAR(50),
                    asistencia3 VARCHAR(50),
                    asistencia4 VARCHAR(50),
                    asistencia5 VARCHAR(50),
                    parcial1 VARCHAR(50),
                    recu1 VARCHAR(50),
                    parcial2 VARCHAR(50),
                    recu2 VARCHAR(50),
                    notafinal VARCHAR(50),
                    validacion VARCHAR(50)
                )";

                using (MySqlCommand creartabla = new MySqlCommand(querycreartabla, conexion))
                {
                    creartabla.ExecuteNonQuery();
                }
            }
        }

        //metodo para eliminar la tabla del curso seleccionado (para guardar las notas y asistencias de los alumnos)
        public void DropTable()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=materias;Uid=root;pwd=;"))
            {
                conexion.Open();

                string queryeliminartabla = $@"
                DROP TABLE {Nombre.Replace(" ", "_")}";  // Reemplaza los espacios en blanco con guiones bajos

                using (MySqlCommand eliminartabla = new MySqlCommand(queryeliminartabla, conexion))
                {
                    eliminartabla.ExecuteNonQuery();
                }
            }
        }

        //metodo para eliminar de la tabla estudiantes
        public void EliminarMateria()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();

                string queryeliminarmateria = $@"
                UPDATE estudiantes SET materia1 = NULL WHERE materia1 = @Nombre;
                UPDATE estudiantes SET materia2 = NULL WHERE materia2 = @Nombre;
                UPDATE estudiantes SET materia3 = NULL WHERE materia3 = @Nombre;
                UPDATE estudiantes SET materia4 = NULL WHERE materia4 = @Nombre;
                UPDATE estudiantes SET materia5 = NULL WHERE materia5 = @Nombre;
                UPDATE estudiantes SET materia6 = NULL WHERE materia1 = @Nombre;
                UPDATE estudiantes SET materia7 = NULL WHERE materia2 = @Nombre;
                UPDATE estudiantes SET materia8 = NULL WHERE materia3 = @Nombre;";

                using (MySqlCommand eliminarmateria = new MySqlCommand(queryeliminarmateria, conexion))
                {
                    eliminarmateria.Parameters.AddWithValue("@Nombre", Nombre);
                    eliminarmateria.ExecuteNonQuery();
                }
            }
        }

        //metodo para eliminar la materia de la tabla de listadeespera
        public int EliminarMateriaListaDeEspera()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "DELETE FROM listadeespera WHERE nombremateria = @Nombremateria";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Nombremateria", Nombre);

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas;
            }
        }
    }
}
