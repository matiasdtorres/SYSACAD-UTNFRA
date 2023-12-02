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
    public partial class requisitosAcademicos : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public requisitosAcademicos()
        {
            InitializeComponent();
            cargarMaterias();
            cargarMaterias2();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if (cursotxt.Text == "" || correlativatxt.Text == "")
            {
                MessageBox.Show("Debe seleccionar una materia y una correlativa");
            }
            else
            {
                if (cursotxt.Text == correlativatxt.Text)
                {
                    MessageBox.Show("No puede seleccionar la misma materia");
                }
                else
                {
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand("update cursos set postmateria = '" + correlativatxt.Text + "' where nombre = '" + cursotxt.Text + "'", conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Requisito cargado correctamente");
                    cursotxt.Text = "";
                    correlativatxt.Text = "";
                }
            }
        }

        //metodo para cargar las materias de la tabla cursos
        private void cargarMaterias()
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM cursos", conexion);
            MySqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cursotxt.Items.Add(registro["nombre"].ToString());
            }
            conexion.Close();
        }

        //metodo para cargar materias que no sea la misma que en cursotxt
        private void cargarMaterias2()
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM cursos WHERE nombre != '" + cursotxt.Text + "'", conexion);
            MySqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                correlativatxt.Items.Add(registro["nombre"].ToString());
            }
            conexion.Close();
        }
    }
}
