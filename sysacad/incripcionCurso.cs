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
    public partial class incripcionCurso : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        public incripcionCurso(string legajoLogeado)
        {
            InitializeComponent();
            MostrarLegajoEstudiante(legajoLogeado);
        }

        private void MostrarLegajoEstudiante(string legajoLogeado)
        {
            //muestro el email del legajoLogeado consultando en la base de datos
            conexion.Open();
            string query = "SELECT legajo FROM estudiantes WHERE legajo = @Legajo";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Legajo", legajoLogeado);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                legajotxt.Text = reader["legajo"].ToString();
            }
            conexion.Close();
        }
    }
}
