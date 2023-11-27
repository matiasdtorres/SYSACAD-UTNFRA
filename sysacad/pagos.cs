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
    public partial class pagos : Form
    {
        payments metodopagos;

        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public pagos(string legajoLogeado)
        {
            InitializeComponent();
            legajoescondio(legajoLogeado);
            chequeopagos(legajoLogeado);
            mostrardatosdepago(legajoLogeado);
        }

        private void legajoescondio(string legajoLogeado)
        {
            legajoescondido.Text = legajoLogeado;
        }

        private void chequeopagos(string legajoLogeado)
        {
            conexion.Open();
            //buscar en la tabla pagos donde el legajo sea el legajo del estudiante logeado
            string query = "SELECT * FROM pagos WHERE legajo = '" + legajoLogeado + "'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                if (reader["matricula"].ToString() == "PAGADO")
                {
                    matriculatxt.Text = "PAGADO";
                }
                if (reader["mes1"].ToString() == "PAGADO")
                {
                    mes1txt.Text = "PAGADO";
                }
                if (reader["mes2"].ToString() == "PAGADO")
                {
                    mes2txt.Text = "PAGADO";
                }
                if (reader["mes3"].ToString() == "PAGADO")
                {
                    mes3txt.Text = "PAGADO";
                }
                if (reader["mes4"].ToString() == "PAGADO")
                {
                    mes4txt.Text = "PAGADO";
                }
                if (reader["mes5"].ToString() == "PAGADO")
                {
                    mes5txt.Text = "PAGADO";
                }
                if (reader["mes6"].ToString() == "PAGADO")
                {
                    mes6txt.Text = "PAGADO";
                }
                if (reader["mes7"].ToString() == "PAGADO")
                {
                    mes7txt.Text = "PAGADO";
                }
                if (reader["mes8"].ToString() == "PAGADO")
                {
                    mes8txt.Text = "PAGADO";
                }
            }
            conexion.Close();
        }

        private void btnmes1_Click(object sender, EventArgs e)
        {
            //chequeo que no haya pagado ya el mes
            if (mes1txt.Text == "PAGADO")
            {
                MessageBox.Show("Ya pagaste el mes 1");
            }
            else
            {
                //chequeo que haya pagado la matricula
                if (matriculatxt.Text == "PAGADO")
                {
                    conexion.Open();
                    //actualizo la tabla pagos donde el legajo sea el legajo del estudiante logeado
                    string query = "UPDATE pagos SET mes1 = 'PAGADO' WHERE legajo = '" + legajoescondido.Text + "'";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Pago realizado con exito");
                    chequeopagos(legajoescondido.Text);
                }
                else
                {
                    MessageBox.Show("Primero debes pagar la matricula");
                }

            }
        }

        private void btnmes2_Click(object sender, EventArgs e)
        {
            //chequeo que no haya pagado ya el mes
            if (mes2txt.Text == "PAGADO")
            {
                MessageBox.Show("Ya pagaste el mes 2");
            }
            else
            {
                //chequeo que haya pagado el mes anterior
                if (mes1txt.Text == "PAGADO")
                {
                    conexion.Open();
                    //actualizo la tabla pagos donde el legajo sea el legajo del estudiante logeado
                    string query = "UPDATE pagos SET mes2 = 'PAGADO' WHERE legajo = '" + legajoescondido.Text + "'";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Pago realizado con exito");
                    chequeopagos(legajoescondido.Text);
                }
                else
                {
                    MessageBox.Show("Primero debes pagar el mes anterior");
                }
            }
        }

        private void btnmes3_Click(object sender, EventArgs e)
        {
            //chequeo que no haya pagado ya el mes
            if (mes3txt.Text == "PAGADO")
            {
                MessageBox.Show("Ya pagaste el mes 3");
            }
            else
            {
                //chequeo que haya pagado el mes anterior
                if (mes2txt.Text == "PAGADO")
                {
                    conexion.Open();
                    //actualizo la tabla pagos donde el legajo sea el legajo del estudiante logeado
                    string query = "UPDATE pagos SET mes3 = 'PAGADO' WHERE legajo = '" + legajoescondido.Text + "'";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Pago realizado con exito");
                    chequeopagos(legajoescondido.Text);
                }
                else
                {
                    MessageBox.Show("Primero debes pagar el mes anterior");
                }
            }
        }

        private void btnmes4_Click(object sender, EventArgs e)
        {
            //chequeo que no haya pagado ya el mes
            if (mes4txt.Text == "PAGADO")
            {
                MessageBox.Show("Ya pagaste el mes 4");
            }
            else
            {
                //chequeo que haya pagado el mes anterior
                if (mes3txt.Text == "PAGADO")
                {
                    conexion.Open();
                    //actualizo la tabla pagos donde el legajo sea el legajo del estudiante logeado
                    string query = "UPDATE pagos SET mes4 = 'PAGADO' WHERE legajo = '" + legajoescondido.Text + "'";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Pago realizado con exito");
                    chequeopagos(legajoescondido.Text);
                }
                else
                {
                    MessageBox.Show("Primero debes pagar el mes anterior");
                }
            }
        }

        private void btnmatricula_Click(object sender, EventArgs e)
        {
            //chequeo que los labels no esten vacios
            if (string.IsNullOrEmpty(tipotxt.Text) || string.IsNullOrEmpty(numerotxt.Text) || string.IsNullOrEmpty(nombretxt.Text) || string.IsNullOrEmpty(codigotxt.Text) || string.IsNullOrEmpty(vencimientotxt.Text))
            {
                MessageBox.Show("Primero debes Agregar un metodo de pago");
            }
            else
            {
                //chequeo que no haya pagado ya la matricula
                if (matriculatxt.Text == "PAGADO")
                {
                    MessageBox.Show("Ya pagaste la matricula");
                }
                else
                {
                    conexion.Open();
                    //actualizo la tabla pagos donde el legajo sea el legajo del estudiante logeado
                    string query = "UPDATE pagos SET matricula = 'PAGADO' WHERE legajo = '" + legajoescondido.Text + "'";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Pago realizado con exito");
                    chequeopagos(legajoescondido.Text);
                }
            }
        }

        private void btnagregarmetodopago_Click(object sender, EventArgs e)
        {
            metodopagos = new payments(legajoescondido.Text);
            metodopagos.Show();
        }

        private void mostrardatosdepago(String legajoLogeado)
        {
            //busco en la tabla datos_pagos donde el legajo sea el legajo del estudiante logeado
            conexion.Open();
            string query = "SELECT * FROM datos_pagos WHERE legajo = @Legajo";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Legajo", legajoLogeado);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                tipotxt.Text = reader["tipo"].ToString();
                numerotxt.Text = reader["numero"].ToString();
                nombretxt.Text = reader["nombre"].ToString();
                codigotxt.Text = reader["codigo"].ToString();
                vencimientotxt.Text = reader["vencimiento"].ToString();

            }
            conexion.Close();
        }

        private void btnmes5_Click(object sender, EventArgs e)
        {
            //chequeo que haya pagado el cuatrimestre anterior
            if (mes4txt.Text == "PAGADO")
            {
                conexion.Open();
                //actualizo la tabla pagos donde el legajo sea el legajo del estudiante logeado
                string query = "UPDATE pagos SET mes5 = 'PAGADO' WHERE legajo = '" + legajoescondido.Text + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Pago realizado con exito");
                chequeopagos(legajoescondido.Text);
            }
            else
            {
                MessageBox.Show("Primero debes tener pago todo el 1er cuatrimestre");
            }
        }

        private void btnmes6_Click(object sender, EventArgs e)
        {
            //chequeo que haya pagado el cuatrimestre anterior
            if (mes5txt.Text == "PAGADO")
            {
                conexion.Open();
                //actualizo la tabla pagos donde el legajo sea el legajo del estudiante logeado
                string query = "UPDATE pagos SET mes6 = 'PAGADO' WHERE legajo = '" + legajoescondido.Text + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Pago realizado con exito");
                chequeopagos(legajoescondido.Text);
            }
            else
            {
                MessageBox.Show("Primero debes pagar el mes anterior");
            }
        }

        private void btnmes7_Click(object sender, EventArgs e)
        {
            //chequeo que haya pagado el cuatrimestre anterior
            if (mes6txt.Text == "PAGADO")
            {
                conexion.Open();
                //actualizo la tabla pagos donde el legajo sea el legajo del estudiante logeado
                string query = "UPDATE pagos SET mes7 = 'PAGADO' WHERE legajo = '" + legajoescondido.Text + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Pago realizado con exito");
                chequeopagos(legajoescondido.Text);
            }
            else
            {
                MessageBox.Show("Primero debes pagar el mes anterior");
            }
        }

        private void btnmes8_Click(object sender, EventArgs e)
        {
            //chequeo que haya pagado el cuatrimestre anterior
            if (mes7txt.Text == "PAGADO")
            {
                conexion.Open();
                //actualizo la tabla pagos donde el legajo sea el legajo del estudiante logeado
                string query = "UPDATE pagos SET mes8 = 'PAGADO' WHERE legajo = '" + legajoescondido.Text + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Pago realizado con exito");
                chequeopagos(legajoescondido.Text);
            }
            else
            {
                MessageBox.Show("Primero debes pagar el mes anterior");
            }
        }
    }
}
