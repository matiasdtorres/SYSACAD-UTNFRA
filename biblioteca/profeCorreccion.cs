using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class profeCorreccion
    {
        public string profe { get; set; }
        public string alumno { get; set; }
        public string nota { get; set; }

        public profeCorreccion()
        {
            this.profe = "";
            this.alumno = "";
            this.nota = "";
        }
    }
}
