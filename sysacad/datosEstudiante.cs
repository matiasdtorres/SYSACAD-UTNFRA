﻿using MySql.Data.MySqlClient;
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
    public partial class datosEstudiante : Form
    {

        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public datosEstudiante(string legajoLogeado)
        {
            InitializeComponent();
            MostrarDatosEstudiante(legajoLogeado);
        }

        private void MostrarDatosEstudiante(string legajoLogeado)
        {
            try
            {
                // Establece la cadena de conexión a la base de datos MySQL

                using (conexion)
                {
                    conexion.Open();

                    // Consulta SQL para obtener los datos del estudiante
                    string query = "SELECT * FROM estudiantes WHERE Legajo = @Legajo";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Legajo", legajoLogeado);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Mostrar la información del estudiante en los Labels
                            nombretxt.Text = reader["nombre"].ToString();
                            apellidotxt.Text = reader["apellido"].ToString();
                            direcciontxt.Text = reader["direccion"].ToString();
                            emailtxt.Text = reader["email"].ToString();
                            telefonotxt.Text = "+54-11-" + reader["telefono"].ToString();
                            legajotxt.Text = reader["legajo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontro un estudiante con ese numero.");
                            conexion.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del estudiante desde la base de datos: " + ex.Message);
                conexion.Close();
            }
        }
    }
}