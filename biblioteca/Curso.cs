using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Curso
    {
        //Atributos de la clase Curso
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Horario { get; set; }
        public int CupoMaximo { get; set; }
        public string Profesor { get; set; }
        public string Aula { get; set; }
        public string Division { get; set; }
        public string Dia { get; set; }
        public string Cuatrimestre { get; set; }

        public Curso(string nombre, int codigo, string descripcion, int horario, int cupoMaximo, string profesor, string aula, string division, string dia, string cuatrimestre)
        {
            Nombre = nombre;
            Codigo = codigo;
            Descripcion = descripcion;
            Horario = horario;
            CupoMaximo = cupoMaximo;
            Profesor = profesor;
            Aula = aula;
            Division = division;
            Dia = dia;
            Cuatrimestre = cuatrimestre;
        }
    }
}
