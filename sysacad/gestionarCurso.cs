using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteca;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace sysacad
{
    public partial class gestionarCurso : Form
    {

        public gestionarCurso()
        {
            InitializeComponent();
            CargarProfesores();
            CargarMaterias();
        }

        private bool ValidarTurno(string dia, string turno, string codigoCursoEditado)
        {
            List<Curso> cursosDia = ObtenerCursosPorDiaExcluyendoCurso(dia, codigoCursoEditado);

            foreach (Curso curso in cursosDia)
            {
                if (curso.Turno == turno && curso.Codigo != codigoCursoEditado)
                {
                    MessageBox.Show($"Ya hay un curso registrado en el turno {turno} para el día seleccionado.");
                    return false;
                }
            }

            return true;
        }

        private List<Curso> ObtenerCursosPorDiaExcluyendoCurso(string dia, string codigoCursoEditado)
        {
            List<Curso> cursosDia = new List<Curso>();

            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "SELECT * FROM cursos WHERE dia = @dia AND codigo != @codigo";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@dia", dia);
                comando.Parameters.AddWithValue("@codigo", codigoCursoEditado);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Curso curso = new Curso(
                        reader["nombre"].ToString(),
                        reader["codigo"].ToString(),
                        reader["descripcion"].ToString(),
                        Convert.ToInt32(reader["cupoMaximo"]),
                        reader["profesor"].ToString(),
                        reader["aula"].ToString(),
                        reader["division"].ToString(),
                        reader["dia"].ToString(),
                        reader["turno"].ToString(),
                        reader["cuatrimestre"].ToString(),
                        reader["fechalimite"].ToString()
                    );

                    cursosDia.Add(curso);
                }
            }

            return cursosDia;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;

            DateTime fechaSeleccionada = fechalimitetxt.Value;

            if (string.IsNullOrEmpty(nombrecursotxt.Text) || string.IsNullOrEmpty(descripcioncursotxt.Text) || string.IsNullOrEmpty(cuposcursotxt.Text) || string.IsNullOrEmpty(profesorcursotxt.Text) || string.IsNullOrEmpty(aulacursotxt.Text) || string.IsNullOrEmpty(divcursotxt.Text) || string.IsNullOrEmpty(diacursotxt.Text) || string.IsNullOrEmpty(cuatricursotxt.Text) || string.IsNullOrEmpty(turnocursotxt.Text))
            {
                 MessageBox.Show("Debe completar todos los campos");
            }
            else if (fechaSeleccionada < fechaActual.AddDays(-1))
            {
                MessageBox.Show("La fecha seleccionada no puede ser de un dia anterior al actual");
            }
            else
            {
                string nombre = nombrecursotxt.Text;
                string codigo = "";
                string descripcion = descripcioncursotxt.Text;
                int cupoMaximo = Convert.ToInt32(cuposcursotxt.Text);
                string profesor = profesorcursotxt.Text;
                string aula = aulacursotxt.Text;
                string division = divcursotxt.Text;
                string dia = diacursotxt.Text;
                string turno = turnocursotxt.Text;
                string cuatrimestre = cuatricursotxt.Text;
                string fechaLimite = fechalimitetxt.Value.ToString("dd-MM-yyyy");

                try
                {
                    if (ValidarTurno(dia, turno, codigo))
                    {
                        Curso nuevoCurso = new Curso(nombre, codigo, descripcion, cupoMaximo, profesor, aula, division, dia, turno, cuatrimestre, fechaLimite);

                        // Crear la tabla antes de agregar el curso
                        nuevoCurso.CreateTable();

                        // Agregar el curso a la base de datos
                        int filasAfectadas = nuevoCurso.AgregarCurso();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Curso agregado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el curso");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btneditar_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;

            DateTime fechaSeleccionada = Convert.ToDateTime(fechalimiteeditartxt.Text);

            if (string.IsNullOrEmpty(nombreeditarcursotxt.Text) || string.IsNullOrEmpty(descripcioneditarcursotxt.Text)
                || string.IsNullOrEmpty(cuposeditarcursotxt.Text) || string.IsNullOrEmpty(profesoreditarcursotxt.Text) || string.IsNullOrEmpty(aulaeditarcursotxt.Text)
                || string.IsNullOrEmpty(diveditarcursotxt.Text) || string.IsNullOrEmpty(diaeditarcursotxt.Text) || string.IsNullOrEmpty(cuatrieditarcursotxt.Text)
                || string.IsNullOrEmpty(turnoeditarcursotxt.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else if (fechaSeleccionada < fechaActual.AddDays(-1))
            {
                MessageBox.Show("La fecha seleccionada no puede ser de un dia anterior al actual");
            }
            else
            {
                string nombre = nombreeditarcursotxt.Text;
                string descripcion = descripcioneditarcursotxt.Text;
                int cupoMaximo = Convert.ToInt32(cuposeditarcursotxt.Text);
                string profesor = profesoreditarcursotxt.Text;
                string aula = aulaeditarcursotxt.Text;
                string division = diveditarcursotxt.Text;
                string dia = diaeditarcursotxt.Text;
                string turno = turnoeditarcursotxt.Text;
                string cuatrimestre = cuatrieditarcursotxt.Text;
                string fechalimite = fechalimiteeditartxt.Value.ToString("dd-MM-yyyy");

                try
                {
                    string codigo = ObtenerCodigoCursoEditadoDesdeBD(nombre);
                    if (ValidarTurno(dia, turno, codigo))
                    {
                        Curso EditarCurso = new Curso(nombre, codigo, descripcion, cupoMaximo, profesor, aula, division, dia, turno, cuatrimestre, fechalimite);

                        int filasAfectadas = EditarCurso.EditarCurso();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Curso editado correctamente");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo editar el curso");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void CargarCursos(DataGridView cursos)
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "SELECT * FROM cursos";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                cursos.DataSource = tabla;
            }
        }

        private void gestionarCurso_Load(object sender, EventArgs e)
        {
            CargarCursos(cursos);
        }

        private void cursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar datos en los textbox que terminan con editarcursotxt
            nombreeditarcursotxt.Text = cursos.CurrentRow.Cells[1].Value.ToString();
            descripcioneditarcursotxt.Text = cursos.CurrentRow.Cells[2].Value.ToString();
            cuposeditarcursotxt.Text = cursos.CurrentRow.Cells[3].Value.ToString();
            profesoreditarcursotxt.Text = cursos.CurrentRow.Cells[4].Value.ToString();
            aulaeditarcursotxt.Text = cursos.CurrentRow.Cells[5].Value.ToString();
            diveditarcursotxt.Text = cursos.CurrentRow.Cells[6].Value.ToString();
            diaeditarcursotxt.Text = cursos.CurrentRow.Cells[7].Value.ToString();
            turnoeditarcursotxt.Text = cursos.CurrentRow.Cells[8].Value.ToString();
            cuatrieditarcursotxt.Text = cursos.CurrentRow.Cells[9].Value.ToString();
            fechalimiteeditartxt.Text = cursos.CurrentRow.Cells[10].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el campo de código está vacío
                if (string.IsNullOrEmpty(nombreeliminarcursotxt.Text))
                {
                    MessageBox.Show("Debe completar el campo código");
                    return;
                }

                // Obtener los valores de los campos
                string nombre = nombreeliminarcursotxt.Text; ;
                string descripcion = descripcioncursotxt.Text;
                int cupoMaximo = Convert.ToInt32(cuposcursotxt.Text);
                string profesor = profesorcursotxt.Text;
                string aula = aulacursotxt.Text;
                string division = divcursotxt.Text;
                string dia = diacursotxt.Text;
                string turno = turnocursotxt.Text;
                string cuatrimestre = cuatricursotxt.Text;
                string codigo = "";
                string fechalimite = fechalimitetxt.Value.ToString("dd-MM-yyyy");

                // Crear un objeto Curso
                Curso EliminarCurso = new Curso(nombre, codigo, descripcion, cupoMaximo, profesor, aula, division, dia, turno, cuatrimestre, fechalimite);

                // Validar el nombre de la tabla antes de eliminarla
                if (string.IsNullOrWhiteSpace(EliminarCurso.Nombre))
                {
                    MessageBox.Show("El nombre de la tabla no es válido");
                    return;
                }


                EliminarCurso.EliminarMateria();
                EliminarCurso.EliminarMateriaListaDeEspera();
                EliminarCurso.DropTable();

                // Eliminar el curso
                int filasAfectadas = EliminarCurso.EliminarCurso();

                // Verificar el resultado de la eliminación
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Curso eliminado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el curso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el curso: " + ex.Message);
            }
        }


        //traer los profesores de la base de datos y mostrarlo en el combobox
        public void CargarProfesores()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "SELECT nombre, apellido FROM profesores";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string nombreCompleto = $"{reader["nombre"]} {reader["apellido"]}";

                    profesorcursotxt.Items.Add(nombreCompleto);
                    profesoreditarcursotxt.Items.Add(nombreCompleto);
                }
            }
        }

        //traer el nombre de la materias y mostrarlo en el combobox
        public void CargarMaterias()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                conexion.Open();
                string query = "SELECT nombre FROM cursos";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    nombreeliminarcursotxt.Items.Add(reader["nombre"].ToString());
                }
            }
        }

        private string ObtenerCodigoCursoEditadoDesdeBD(string nombreCursoEditado)
        {
            string codigoCursoEditado = null;

            using (MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;"))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT codigo FROM cursos WHERE nombre = @nombre";
                    MySqlCommand command = new MySqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@nombre", nombreCursoEditado);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        codigoCursoEditado = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el código del curso editado: " + ex.Message);
                }
            }

            return codigoCursoEditado;
        }

    }
}
