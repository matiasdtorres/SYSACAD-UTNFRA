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
    public partial class notificaciones : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public notificaciones(string legajoLogeado)
        {
            InitializeComponent();
            legajoescondido(legajoLogeado);
            chequearSiPago1ercuatri();
        }

        private void legajoescondido(string legajoLogeado)
        {
            legajoescondidotxt.Text = legajoLogeado;
        }

        //chequeo si el estudiante pago las cuotas y los muestro en cada label
        private void chequearSiPago1ercuatri()
        {
            bool todasLasCuotasPagadas = true;

            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pagos WHERE legajo = @legajo", conexion);
            cmd.Parameters.AddWithValue("@legajo", legajoescondidotxt.Text);
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                if (leer["mes1"].ToString() == "PAGADO")
                {
                    cuota1txt.Text = "Cuota 1: PAGA";
                }
                else
                {
                    cuota1txt.Text = "Cuota 1: IMPAGA";
                    todasLasCuotasPagadas = false;
                }

                if (leer["mes2"].ToString() == "PAGADO")
                {
                    cuota2txt.Text = "Cuota 2: PAGA";
                }
                else
                {
                    cuota2txt.Text = "Cuota 2: IMPAGA";
                    todasLasCuotasPagadas = false;
                }

                if (leer["mes3"].ToString() == "PAGADO")
                {
                    cuota3txt.Text = "Cuota 3: PAGA";
                }
                else
                {
                    cuota3txt.Text = "Cuota 3: IMPAGA";
                    todasLasCuotasPagadas = false;
                }

                if (leer["mes4"].ToString() == "PAGADO")
                {
                    cuota4txt.Text = "Cuota 4: PAGA";
                }
                else
                {
                    cuota4txt.Text = "Cuota 4: IMPAGA";
                    todasLasCuotasPagadas = false;
                }

                if (todasLasCuotasPagadas)
                {
                    cuotascompletas.Visible = true;
                    cuotascompletas.Text = "no hay notificaciones";
                    cuota1txt.Visible = false;
                    cuota2txt.Visible = false;
                    cuota3txt.Visible = false;
                    cuota4txt.Visible = false;
                }
                else
                {
                    cuotascompletas.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar las cuotas");
            }

            conexion.Close();
        }

    }
}
