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
    public partial class agregarEstudiante : Form
    {
        public agregarEstudiante()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (nombretxt.Text == "" || apellidotxt.Text == "" || direcciontxt.Text == "" || emailtxt.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string nombre = nombretxt.Text;
                string apellido = apellidotxt.Text;
                string direccion = direcciontxt.Text;
                string email = emailtxt.Text;
                MessageBox.Show("Estudiante registrado con exito");
            }
        }
    }
}
