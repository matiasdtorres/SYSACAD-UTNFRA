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
        public incripcionCurso(string legajoLogeado)
        {
            InitializeComponent();
            MostrarNumeroEstudiante(legajoLogeado);
        }

        private void MostrarNumeroEstudiante(string legajoLogeado)
        {
            nombrebienvenida.Text = legajoLogeado.ToString();
        }
    }
}
