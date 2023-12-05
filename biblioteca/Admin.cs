using MySql.Data.MySqlClient;
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
        public Admin(string usuario, string contraseña) : base("", contraseña)
        {
            Usuario = usuario;
        }

        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public override void CambiarContraseña(string nuevaContraseña)
        {
            // Hash de la nueva contraseña
            Contraseña = Hash.GetHash(nuevaContraseña);
        }
    }
}
