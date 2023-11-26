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
    public partial class payments : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public payments(string legajoLogeado)
        {
            InitializeComponent();
            legajoescondio(legajoLogeado);
        }

        private void legajoescondio(string legajoLogeado)
        {
            legajoescondido.Text = legajoLogeado;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(tipotarjeta.Text) ||
                string.IsNullOrWhiteSpace(numerotarjeta.Text) ||
                string.IsNullOrWhiteSpace(nombretarjeta.Text) ||
                string.IsNullOrWhiteSpace(codigotarjeta.Text) ||
                string.IsNullOrWhiteSpace(vencimientotarjeta.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar los datos de pago.");
                return;
            }

            conexion.Open();
            string query = "UPDATE datos_pagos SET tipo = @Tipo, numero = @Numero, nombre = @Nombre, codigo = @Codigo, vencimiento = @Vencimiento WHERE legajo = @Legajo";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Legajo", legajoescondido.Text);
            comando.Parameters.AddWithValue("@Tipo", tipotarjeta.Text);
            comando.Parameters.AddWithValue("@Numero", numerotarjeta.Text);
            comando.Parameters.AddWithValue("@Nombre", nombretarjeta.Text);
            comando.Parameters.AddWithValue("@Codigo", codigotarjeta.Text);
            comando.Parameters.AddWithValue("@Vencimiento", vencimientotarjeta.Text);

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos de pago actualizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos de pago: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
