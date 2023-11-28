using MySql.Data.MySqlClient;
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
    public partial class notas : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public notas(string profelogeado)
        {
            InitializeComponent();
            usuarioescondio(profelogeado);
        }

        private void usuarioescondio(string profelogeado)
        {
            usuarioescondidotxt.Text = profelogeado;
        }
    }
}
