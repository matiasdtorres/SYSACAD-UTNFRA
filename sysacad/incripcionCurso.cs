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
        public incripcionCurso(string legajo)
        {
            InitializeComponent();
            MostrarNumeroEstudiante(legajo);
        }

        private void MostrarNumeroEstudiante(string legajo)
        {
            nombrebienvenida.Text = legajo.ToString();
        }
    }
}
