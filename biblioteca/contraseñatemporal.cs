using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class GeneradorContraseñaTemporal
    {
        public static string GenerarContraseña(int longitud = 4)
        {
            const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] contraseña = new char[longitud];
            Random random = new Random();

            for (int i = 0; i < longitud; i++)
            {
                contraseña[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            return new string(contraseña);
        }
    }
}
