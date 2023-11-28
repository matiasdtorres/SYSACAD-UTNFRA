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


            lunesmañananombre.Text = "VACIO";
            lunesmañanaprofe.Text = "VACIO";
            lunestardenombre.Text = "VACIO";
            lunestardeprofe.Text = "VACIO";
            lunesnochenombre.Text = "VACIO";
            lunesnocheprofe.Text = "VACIO";
            martesmañananombre.Text = "VACIO";
            martesmañanaprofe.Text = "VACIO";
            martestardenombre.Text = "VACIO";
            martestardeprofe.Text = "VACIO";
            martesnochenombre.Text = "VACIO";
            martesnocheprofe.Text = "VACIO";
            miercolesmañananombre.Text = "VACIO";
            miercolesmañanaprofe.Text = "VACIO";
            miercolestardenombre.Text = "VACIO";
            miercolestardeprofe.Text = "VACIO";
            miercolesnochenombre.Text = "VACIO";
            miercolesnocheprofe.Text = "VACIO";
            juevesmañananombre.Text = "VACIO";
            juevesmañanaprofe.Text = "VACIO";
            juevestardenombre.Text = "VACIO";
            juevestardeprofe.Text = "VACIO";
            juevesnochenombre.Text = "VACIO";
            juevesnocheprofe.Text = "VACIO";
            viernesmañananombre.Text = "VACIO";
            viernesmañanaprofe.Text = "VACIO";
            viernestardenombre.Text = "VACIO";
            viernestardeprofe.Text = "VACIO";
            viernesnochenombre.Text = "VACIO";
            viernesnocheprofe.Text = "VACIO";




            try
            {
                conexion.Open();

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
                                string profe = readerCursos["profesor"].ToString();
                                string turno = readerCursos["turno"].ToString();
                                string dia = readerCursos["dia"].ToString();

                                // Llamada al método para asignar valores a los labels correspondientes
                                AsignarValoresALabels(turno, dia, nombre, profe);
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


        private void AsignarValoresALabels(string turno, string dia, string nombre, string profe)
        {
            switch (turno)
            {
                case "Mañana":
                    AsignarValoresALabelsMañana(dia, nombre, profe);
                    break;
                case "Tarde":
                    AsignarValoresALabelsTarde(dia, nombre, profe);
                    break;
                case "Noche":
                    AsignarValoresALabelsNoche(dia, nombre, profe);
                    break;
            }
        }

        private void AsignarValoresALabelsMañana(string dia, string nombre, string profe)
        {
            switch (dia)
            {
                case "Lunes":
                    lunesmañananombre.Text = nombre;
                    lunesmañanaprofe.Text = profe;
                    break;
                case "Martes":
                    martesmañananombre.Text = nombre;
                    martesmañanaprofe.Text = profe;
                    break;
                case "Miércoles":
                    miercolesmañananombre.Text = nombre;
                    miercolesmañanaprofe.Text = profe;
                    break;
                case "Jueves":
                    juevesmañananombre.Text = nombre;
                    juevesmañanaprofe.Text = profe;
                    break;
                case "Viernes":
                    viernesmañananombre.Text = nombre;
                    viernesmañanaprofe.Text = profe;
                    break;
            }
        }

        private void AsignarValoresALabelsTarde(string dia, string nombre, string profe)
        {
            switch (dia)
            {
                case "Lunes":
                    lunestardenombre.Text = nombre;
                    lunesmañanaprofe.Text = profe;
                    break;
                case "Martes":
                    martestardenombre.Text = nombre;
                    martestardeprofe.Text = profe;
                    break;
                case "Miércoles":
                    miercolestardenombre.Text = nombre;
                    miercolestardeprofe.Text = profe;
                    break;
                case "Jueves":
                    juevestardenombre.Text = nombre;
                    juevestardeprofe.Text = profe;
                    break;
                case "Viernes":
                    viernestardenombre.Text = nombre;
                    viernestardeprofe.Text = profe;
                    break;
            }
        }

        private void AsignarValoresALabelsNoche(string dia, string nombre, string profe)
        {
            switch (dia)
            {
                case "Lunes":
                    lunesnochenombre.Text = nombre;
                    lunesnocheprofe.Text = profe;
                    break;
                case "Martes":
                    martesnochenombre.Text = nombre;
                    martesnocheprofe.Text = profe;
                    break;
                case "Miércoles":
                    miercolesnochenombre.Text = nombre;
                    miercolesnocheprofe.Text = profe;
                    break;
                case "Jueves":
                    juevesnochenombre.Text = nombre;
                    juevesnocheprofe.Text = profe;
                    break;
                case "Viernes":
                    viernesnochenombre.Text = nombre;
                    viernesnocheprofe.Text = profe;
                    break;
            }
        }

    }
}
