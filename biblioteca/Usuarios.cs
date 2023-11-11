using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    // Clase abstracta que será heredada por las clases Admin, Estudiante y Profesor
    public abstract class Usuarios
    {
        //Atributos comunes a todas las clases
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        //Constructor de la clase Usuarios
        public Usuarios(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;

            // Hash de la contraseña
            Contraseña = Hash.GetHash(contraseña);
        }
    }
}
