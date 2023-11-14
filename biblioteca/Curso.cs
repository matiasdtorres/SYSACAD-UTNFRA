using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Curso
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Horario { get; set; }
        public int CupoMaximo { get; set; }
        public string Profesor { get; set; }

        public Curso(string nombre, int codigo, string descripcion, int horario, int cupoMaximo, string profesor)
        {
            Nombre = nombre;
            Codigo = codigo;
            Descripcion = descripcion;
            Horario = horario;
            CupoMaximo = cupoMaximo;
            Profesor = profesor;
        }
    }
}
