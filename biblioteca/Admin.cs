using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Admin : Usuarios
    {
        //Atributos propios de la clase Admin
        public string Usuario { get; set; }

        //Constructor de la clase Admin
        public Admin(string usuario, string contraseña) : base("", contraseña) //El nombre del admin no es necesario
        {
            Usuario = usuario;
        }

        //Metodo para que el admin cambie su contraseña
        public void CambiarContraseña(string nuevaContraseña)
        {
            // Hash de la nueva contraseña
            Contraseña = Hash.GetHash(nuevaContraseña);
        }
    }
}
