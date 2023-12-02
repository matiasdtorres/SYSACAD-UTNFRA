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
        MySqlConnection conexion2 = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        MySqlConnection conexion3 = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        MySqlConnection conexion4 = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");
        System.Windows.Forms.Timer refreshTimer = new System.Windows.Forms.Timer();


        public notificaciones(string legajoLogeado)
        {
            InitializeComponent();
            legajoescondido(legajoLogeado);
            chequearSiPago1ercuatri();
            chequearFechasLimite();
            chequearFechasLimite2();


            refreshTimer.Interval = 2000; // 2 segundos en milisegundos
            refreshTimer.Tick += (sender, e) =>
            {
                chequearFechasLimite();
                chequearFechasLimite2();
            };
            refreshTimer.Start();
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

        //chequeo las fechas limites de inscripcion de cada materia y las muestro en cada label
        private void chequearFechasLimite()
        {
            try
            {
                fecha1txt.Text = "";
                fecha2txt.Text = "";
                fecha3txt.Text = "";
                fecha4txt.Text = "";
                nofechas.Visible = false;

                conexion.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos WHERE cuatrimestre = '1'", conexion);
                MySqlDataReader leer = cmd.ExecuteReader();

                int contadorMaterias = 0;

                while (leer.Read() && contadorMaterias < 4) // hasta 4 materias
                {
                    string nombreMateria = leer["nombre"].ToString();
                    string fechaLimite = leer["fechalimite"].ToString();

                    Label label = null;

                    conexion2.Open();

                    //chequeo que el estudiante no esté inscrito en la materia
                    MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM estudiantes WHERE legajo = @legajo AND (materia1 = @materia OR materia2 = @materia OR materia3 = @materia OR materia4 = @materia)", conexion2);
                    cmd2.Parameters.AddWithValue("@legajo", legajoescondidotxt.Text);
                    cmd2.Parameters.AddWithValue("@materia", nombreMateria);

                    MySqlDataReader leer2 = cmd2.ExecuteReader();

                    try
                    {
                        if (!leer2.Read())
                        {
                            switch (contadorMaterias)
                            {
                                case 0:
                                    label = fecha1txt;
                                    break;
                                case 1:
                                    label = fecha2txt;
                                    break;
                                case 2:
                                    label = fecha3txt;
                                    break;
                                case 3:
                                    label = fecha4txt;
                                    break;
                            }

                            if (label != null)
                            {
                                label.Text = "Fecha límite de " + nombreMateria + ": " + fechaLimite;

                                contadorMaterias++;
                            }
                        }
                    }
                    finally
                    {
                        leer2.Close();
                    }

                    conexion2.Close();
                }

                if (contadorMaterias == 0)
                {
                    nofechas.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
              conexion.Close();
            }
        }

        //si la fecha ya paso entonces no muestro nada
        private void chequearFechasLimite2()
        {
            //NO TE OLVIDES MATIAAAASSSSS
        }


    }
}
