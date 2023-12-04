using biblioteca;
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
        private ManejadorEstudiantes manejadorEstudiantes;

        public agregarEstudiante()
        {
            InitializeComponent();
            manejadorEstudiantes = new ManejadorEstudiantes();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombretxt.Text) || string.IsNullOrEmpty(apellidotxt.Text) || string.IsNullOrEmpty(direcciontxt.Text) || string.IsNullOrEmpty(telefonotxt.Text) || string.IsNullOrEmpty(emailtxt.Text) || string.IsNullOrEmpty(legajotxt.Text) || string.IsNullOrEmpty(contraseñaTemporaltxt.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else if (nombretxt.Text.Any(char.IsDigit) || apellidotxt.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener numeros");
            }
            else if (telefonotxt.Text.Any(char.IsLetter))
            {
                MessageBox.Show("El telefono no puede contener letras");
            }
            else if (telefonotxt.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener exactamente 10 caracteres");
            }
            else if (legajotxt.Text.Any(char.IsLetter))
            {
                MessageBox.Show("El legajo no puede contener letras");
            }
            else if (emailtxt.Text.Contains("@") == false || emailtxt.Text.Contains(".com") == false)
            {
                MessageBox.Show("El email debe contener un @ y un .com");
            }
            else
            {
                string nombre = nombretxt.Text;
                string apellido = apellidotxt.Text;
                string direccion = direcciontxt.Text;
                string telefono = telefonotxt.Text;
                string email = emailtxt.Text;
                string contraseñaTemporal = contraseñaTemporaltxt.Text;
                int legajo = Convert.ToInt32(legajotxt.Text);

                try
                {
                    // Hashear la contraseña temporal antes de almacenarla en la base de datos
                    string contraseña = Hash.GetHash(contraseñaTemporal);

                    Estudiante nuevoEstudiante = new Estudiante(legajo, nombre, apellido, direccion, telefono, email, contraseña);

                    int filasAfectadas = nuevoEstudiante.AgregarRol();

                    if (filasAfectadas > 0)
                    {
                        int filasAfectadasPagos = nuevoEstudiante.EstudiantePagos();
                        int filasAfectadasDatosPagos = nuevoEstudiante.EstudianteDatosPagos();
                        MessageBox.Show("Estudiante agregado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el estudiante");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar estudiante: " + ex.Message);
                }
            }
        }

        private void btncrearcontraseña_Click(object sender, EventArgs e)
        {
            try
            {
                // Generar una contraseña temporal aleatoria utilizando la clase de utilidad
                string contraseñaTemporal = GeneradorContraseñaTemporal.GenerarContraseña();

                // Mostrar la contraseña temporal en el TextBox
                contraseñaTemporaltxt.Text = contraseñaTemporal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar contraseña temporal: " + ex.Message);
            }
        }

        private void btncrearlegajo_Click(object sender, EventArgs e)
        {
            int ultimoLegajo;

            if (manejadorEstudiantes.ObtenerUltimoLegajo(out ultimoLegajo))
            {
                legajotxt.Text = (ultimoLegajo + 1).ToString("D5");
            }
            else
            {
                MessageBox.Show("Error al obtener el último legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
