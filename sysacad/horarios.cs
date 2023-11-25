using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysacad
{
    public partial class horarios : Form
    {

        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public horarios(string legajoLogeado)
        {
            InitializeComponent();
            legajoescondio(legajoLogeado);
            MostrarHorarios(legajoLogeado);
        }

        private void legajoescondio(string legajoLogeado)
        {
            legajoescondido.Text = legajoLogeado;
        }

        private void MostrarHorarios(string legajoLogeado)
        {

            //limpar todos los labels
            lunesmañananombre.Text = "";
            lunesmañanaaula.Text = "";
            lunestardenombre.Text = "";
            lunestardeaula.Text = "";
            lunesnochenombre.Text = "";
            lunesnocheaula.Text = "";
            martesmañananombre.Text = "";
            martesmañanaaula.Text = "";
            martestardenombre.Text = "";
            martestardeaula.Text = "";
            martesnochenombre.Text = "";
            martesnocheaula.Text = "";
            miercolesmañananombre.Text = "";
            miercolesmañanaaula.Text = "";
            miercolestardenombre.Text = "";
            miercolestardeaula.Text = "";
            miercolesnochenombre.Text = "";
            miercolesnocheaula.Text = "";
            juevesmañananombre.Text = "";
            juevesmañanaaula.Text = "";
            juevestardenombre.Text = "";
            juevestardeaula.Text = "";
            juevesnochenombre.Text = "";
            juevesnocheaula.Text = "";
            viernesmañananombre.Text = "";
            viernesmañanaaula.Text = "";
            viernestardenombre.Text = "";
            viernestardeaula.Text = "";
            viernesnochenombre.Text = "";
            viernesnocheaula.Text = "";




            try
            {
                conexion.Open();

                // Consultas para obtener la información de las materias inscritas por el alumno
                string[] queriesEstudiante = {
                "SELECT materia1 FROM estudiantes WHERE legajo = @legajo",
                "SELECT materia2 FROM estudiantes WHERE legajo = @legajo",
                "SELECT materia3 FROM estudiantes WHERE legajo = @legajo",
                "SELECT materia4 FROM estudiantes WHERE legajo = @legajo"
                };

                List<string> materiasInscritas = new List<string>();

                foreach (var queryEstudiante in queriesEstudiante)
                {
                    using (MySqlCommand comandoEstudiante = new MySqlCommand(queryEstudiante, conexion))
                    {
                        comandoEstudiante.Parameters.AddWithValue("@legajo", legajoLogeado);

                        object result = comandoEstudiante.ExecuteScalar();
                        if (result != null)
                        {
                            materiasInscritas.Add(result.ToString());
                        }
                    }
                }

                // Consulta para obtener la información de las materias desde la tabla cursos
                string queryCursos = "SELECT * FROM cursos WHERE nombre = @materia";

                foreach (var materiaInscrita in materiasInscritas)
                {
                    using (MySqlCommand comandoCursos = new MySqlCommand(queryCursos, conexion))
                    {
                        comandoCursos.Parameters.AddWithValue("@materia", materiaInscrita);

                        using (MySqlDataReader readerCursos = comandoCursos.ExecuteReader())
                        {
                            while (readerCursos.Read())
                            {
                                string nombre = readerCursos["nombre"].ToString();
                                string aula = readerCursos["aula"].ToString();
                                string turno = readerCursos["turno"].ToString();
                                string dia = readerCursos["dia"].ToString();

                                // Llamada al método para asignar valores a los labels correspondientes
                                AsignarValoresALabels(turno, dia, nombre, aula);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de cursos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }


        private void AsignarValoresALabels(string turno, string dia, string nombre, string aula)
        {
            switch (turno)
            {
                case "Mañana":
                    AsignarValoresALabelsMañana(dia, nombre, aula);
                    break;
                case "Tarde":
                    AsignarValoresALabelsTarde(dia, nombre, aula);
                    break;
                case "Noche":
                    AsignarValoresALabelsNoche(dia, nombre, aula);
                    break;
            }
        }

        private void AsignarValoresALabelsMañana(string dia, string nombre, string aula)
        {
            switch (dia)
            {
                case "Lunes":
                    lunesmañananombre.Text = nombre;
                    lunesmañanaaula.Text = aula;
                    break;
                case "Martes":
                    martesmañananombre.Text = nombre;
                    martesmañanaaula.Text = aula;
                    break;
                case "Miércoles":
                    miercolesmañananombre.Text = nombre;
                    miercolesmañanaaula.Text = aula;
                    break;
                case "Jueves":
                    juevesmañananombre.Text = nombre;
                    juevesmañanaaula.Text = aula;
                    break;
                case "Viernes":
                    viernesmañananombre.Text = nombre;
                    viernesmañanaaula.Text = aula;
                    break;
            }
        }

        private void AsignarValoresALabelsTarde(string dia, string nombre, string aula)
        {
            switch (dia)
            {
                case "Lunes":
                    lunestardenombre.Text = nombre;
                    lunesmañanaaula.Text = aula;
                    break;
                case "Martes":
                    martestardenombre.Text = nombre;
                    martestardeaula.Text = aula;
                    break;
                case "Miércoles":
                    miercolestardenombre.Text = nombre;
                    miercolestardeaula.Text = aula;
                    break;
                case "Jueves":
                    juevestardenombre.Text = nombre;
                    juevestardeaula.Text = aula;
                    break;
                case "Viernes":
                    viernestardenombre.Text = nombre;
                    viernestardeaula.Text = aula;
                    break;
            }
        }

        private void AsignarValoresALabelsNoche(string dia, string nombre, string aula)
        {
            switch (dia)
            {
                case "Lunes":
                    lunesnochenombre.Text = nombre;
                    lunesnocheaula.Text = aula;
                    break;
                case "Martes":
                    martesnochenombre.Text = nombre;
                    martesnocheaula.Text = aula;
                    break;
                case "Miércoles":
                    miercolesnochenombre.Text = nombre;
                    miercolesnocheaula.Text = aula;
                    break;
                case "Jueves":
                    juevesnochenombre.Text = nombre;
                    juevesnocheaula.Text = aula;
                    break;
                case "Viernes":
                    viernesnochenombre.Text = nombre;
                    viernesnocheaula.Text = aula;
                    break;
            }
        }

    }
}
