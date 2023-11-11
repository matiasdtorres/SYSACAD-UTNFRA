using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    //Clase estudiante que hereda de la clase Usuarios
    public class Estudiante : Usuarios
    {
        //Atributos propios de la clase Estudiante
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Legajo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        //Constructor de la clase Estudiante
        public Estudiante(string nombre, string apellido, string legajo, string direccion, string telefono, string email, string contraseña) : base(nombre, contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Legajo = legajo;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }

        //Metodo para que el estudiante cambie su contraseña
        public void CambiarContraseña(string nuevaContraseña)
        {
            // Hash de la nueva contraseña
            Contraseña = Hash.GetHash(nuevaContraseña);
        }
    }
}
