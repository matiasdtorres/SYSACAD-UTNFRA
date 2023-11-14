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
            if (string.IsNullOrEmpty(nombrecursotxt.Text) || string.IsNullOrEmpty(codigocursotxt.Text) || string.IsNullOrEmpty(descripcioncursotxt.Text) || string.IsNullOrEmpty(horariocursotxt.Text) || string.IsNullOrEmpty(cuposcursotxt.Text) || string.IsNullOrEmpty(profesorcursotxt.Text) || string.IsNullOrEmpty(aulacursotxt.Text) || string.IsNullOrEmpty(divcursotxt.Text) || string.IsNullOrEmpty(diacursotxt.Text) || string.IsNullOrEmpty(cuatricursotxt.Text))
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
                string cuatrimestre = cuatricursotxt.Text;

                try
                {
                    Curso nuevoCurso = new Curso(nombre, codigo, descripcion, horario, cupoMaximo, profesor, aula, division, dia, cuatrimestre);

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
    }
}
