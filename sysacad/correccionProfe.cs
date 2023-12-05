using biblioteca;
using Newtonsoft.Json;
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
    public partial class correccionProfe : Form
    {
        private List<profeCorreccion> listaAlumnos = new List<profeCorreccion>();
        public correccionProfe()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            try
            {
                profeCorreccion alumno = new profeCorreccion();

                alumno.profe = profetxt.Text;
                alumno.alumno = alumnotxt.Text;
                alumno.nota = notatxt.Text;

                listaAlumnos.Add(alumno);

                string json = JsonConvert.SerializeObject(listaAlumnos.ToArray(), Formatting.Indented);

                string rutaDocumento = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string rutaArchivo = Path.Combine(rutaDocumento, "correccion.json");
                System.IO.File.WriteAllText(rutaArchivo, json);

                MessageBox.Show("Datos guardados correctamente en " + rutaArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
