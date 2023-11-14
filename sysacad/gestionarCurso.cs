using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteca;
using MySql.Data.MySqlClient;

namespace sysacad
{
    public partial class gestionarCurso : Form
    {
        public gestionarCurso()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombrecursotxt.Text) || string.IsNullOrEmpty(codigocursotxt.Text) || string.IsNullOrEmpty(descripcioncursotxt.Text) || string.IsNullOrEmpty(horariocursotxt.Text) || string.IsNullOrEmpty(cuposcursotxt.Text) || string.IsNullOrEmpty(profesorcursotxt.Text) || string.IsNullOrEmpty(aulacursotxt.Text) || string.IsNullOrEmpty(divcursotxt.Text) || string.IsNullOrEmpty(diacursotxt.Text) || string.IsNullOrEmpty(cuatricursotxt.Text) || string.IsNullOrEmpty(turnocursotxt.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string nombre = nombrecursotxt.Text;
                int codigo = Convert.ToInt32(codigocursotxt.Text);
                string descripcion = descripcioncursotxt.Text;
                string horario = horariocursotxt.Text;
                int cupoMaximo = Convert.ToInt32(cuposcursotxt.Text);
                string profesor = profesorcursotxt.Text;
                string aula = aulacursotxt.Text;
                string division = divcursotxt.Text;
                string dia = diacursotxt.Text;
                string turno = turnocursotxt.Text;
                string cuatrimestre = cuatricursotxt.Text;

                try
                {
                    Curso nuevoCurso = new Curso(nombre, codigo, descripcion, horario, cupoMaximo, profesor, aula, division, dia, turno, cuatrimestre);

                    int filasAfectadas = nuevoCurso.AgregarCurso();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Curso agregado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el curso");
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
            if (string.IsNullOrEmpty(nombreeditarcursotxt.Text) || string.IsNullOrEmpty(codigoeditarcursotxt.Text) || string.IsNullOrEmpty(descripcioneditarcursotxt.Text) || string.IsNullOrEmpty(horarioeditarcursotxt.Text) || string.IsNullOrEmpty(cuposeditarcursotxt.Text) || string.IsNullOrEmpty(profesoreditarcursotxt.Text) || string.IsNullOrEmpty(aulaeditarcursotxt.Text) || string.IsNullOrEmpty(diveditarcursotxt.Text) || string.IsNullOrEmpty(diaeditarcursotxt.Text) || string.IsNullOrEmpty(cuatrieditarcursotxt.Text) || string.IsNullOrEmpty(turnoeditarcursotxt.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string nombre = nombreeditarcursotxt.Text;
                int codigo = Convert.ToInt32(codigoeditarcursotxt.Text);
                string descripcion = descripcioneditarcursotxt.Text;
                string horario = horarioeditarcursotxt.Text;
                int cupoMaximo = Convert.ToInt32(cuposeditarcursotxt.Text);
                string profesor = profesoreditarcursotxt.Text;
                string aula = aulaeditarcursotxt.Text;
                string division = diveditarcursotxt.Text;
                string dia = diaeditarcursotxt.Text;
                string turno = turnoeditarcursotxt.Text;
                string cuatrimestre = cuatrieditarcursotxt.Text;

                try
                {
                    Curso nuevoCurso = new Curso(nombre, codigo, descripcion, horario, cupoMaximo, profesor, aula, division, dia, turno, cuatrimestre);

                    int filasAfectadas = nuevoCurso.EditarCurso();

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
            codigoeditarcursotxt.Text = cursos.CurrentRow.Cells[0].Value.ToString();
            descripcioneditarcursotxt.Text = cursos.CurrentRow.Cells[2].Value.ToString();
            horarioeditarcursotxt.Text = cursos.CurrentRow.Cells[3].Value.ToString();
            cuposeditarcursotxt.Text = cursos.CurrentRow.Cells[4].Value.ToString();
            profesoreditarcursotxt.Text = cursos.CurrentRow.Cells[5].Value.ToString();
            aulaeditarcursotxt.Text = cursos.CurrentRow.Cells[6].Value.ToString();
            diveditarcursotxt.Text = cursos.CurrentRow.Cells[7].Value.ToString();
            diaeditarcursotxt.Text = cursos.CurrentRow.Cells[8].Value.ToString();
            turnoeditarcursotxt.Text = cursos.CurrentRow.Cells[9].Value.ToString();
            cuatrieditarcursotxt.Text = cursos.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
