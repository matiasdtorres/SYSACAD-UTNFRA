using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class reportes : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost;port=3306;database=sysacad;Uid=root;pwd=;");

        public reportes()
        {
            InitializeComponent();
            nombrecursos();
        }

        private async void btncurso_Click(object sender, EventArgs e)
        {
            if (cursostxt.Text == "")
            {
                MessageBox.Show("Debe ingresar un curso.");
                return;
            }
            else
            {
                // desabilito el boton para evitar que se hagan multiples clicks
                btncurso.Enabled = false;

                // Generar el PDF en un hilo separado
                await Task.Run(() =>
                {
                    Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                    string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ReporteCurso.pdf";
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                    doc.Open();

                    iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                    doc.Add(new Paragraph("Reporte de Curso", font));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Paragraph("Nombre del Curso: " + cursostxt.Text, font));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Paragraph("Cantidad de Alumnos: " + cantidadalumnos(), font));
                    doc.Add(Chunk.NEWLINE);

                    PdfPTable tblPrueba = new PdfPTable(3);
                    tblPrueba.WidthPercentage = 100;

                    PdfPCell clLegajo = new PdfPCell(new Phrase("Legajo", font));
                    clLegajo.BorderWidth = 0;
                    clLegajo.BorderWidthBottom = 0.75f;

                    PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", font));
                    clNombre.BorderWidth = 0;
                    clNombre.BorderWidthBottom = 0.75f;

                    PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", font));
                    clApellido.BorderWidth = 0;
                    clApellido.BorderWidthBottom = 0.75f;

                    tblPrueba.AddCell(clLegajo);
                    tblPrueba.AddCell(clNombre);
                    tblPrueba.AddCell(clApellido);

                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM estudiantes WHERE materia1 = @curso", conexion);
                    cmd.Parameters.AddWithValue("@curso", cursostxt.Text);
                    MySqlDataReader leer = cmd.ExecuteReader();
                    while (leer.Read())
                    {
                        tblPrueba.AddCell(new Phrase(leer["legajo"].ToString(), font));
                        tblPrueba.AddCell(new Phrase(leer["nombre"].ToString(), font));
                        tblPrueba.AddCell(new Phrase(leer["apellido"].ToString(), font));
                    }
                    conexion.Close();

                    doc.Add(tblPrueba);
                    doc.Close();

                    // Agregar un retraso de 5 segundos
                    Task.Delay(5000).Wait();

                    // Habilitar el botón después de completar el proceso
                    this.Invoke((MethodInvoker)delegate
                    {
                        btncurso.Enabled = true;
                    });

                    MessageBox.Show("Reporte generado con éxito en el escritorio.");
                });
            }
        }


        private int cantidadalumnos()
        {
            int cantidad = 0;
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM estudiantes WHERE materia1 = @curso", conexion);
            cmd.Parameters.AddWithValue("@curso", cursostxt.Text);
            MySqlDataReader leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                cantidad++;
            }
            conexion.Close();
            return cantidad;
        }

        private void nombrecursos()
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos", conexion);
            MySqlDataReader leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                cursostxt.Items.Add(leer["nombre"].ToString());
            }
            conexion.Close();
        }

        // Función para verificar si el legajo existe en la base de datos
        private bool LegajoExiste(string legajo)
        {
            bool existe = false;

            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM estudiantes WHERE legajo = @legajo", conexion);
                cmd.Parameters.AddWithValue("@legajo", legajo);

                // ExecuteScalar devuelve el número de filas con el legajo especificado
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                existe = (cantidad > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el legajo en la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return existe;
        }

        private async void btnestudiante_Click(object sender, EventArgs e)
        {
            if (legajotxt.Text == "")
            {
                MessageBox.Show("Debe ingresar un legajo.");
                return;
            }
            else
            {
                // desabilito el boton para evitar que se hagan multiples clicks
                btnestudiante.Enabled = false;

                // Verifico si el legajo existe en la base de datos
                if (!LegajoExiste(legajotxt.Text))
                {
                    MessageBox.Show("El legajo ingresado no existe en la base de datos.");
                    return;
                }
                else
                {
                    // Generar el PDF en un hilo separado
                    await Task.Run(() =>
                    {
                        //traigo todos los datos del estudiante y los descargo en pdf
                        Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                        string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ReporteEstudiante.pdf";
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                        doc.Open();

                        iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        doc.Add(new Paragraph("Reporte de Estudiante", font));
                        doc.Add(Chunk.NEWLINE);
                        doc.Add(Chunk.NEWLINE);

                        PdfPTable tblPrueba = new PdfPTable(13);
                        tblPrueba.WidthPercentage = 100;

                        PdfPCell clLegajo = new PdfPCell(new Phrase("Legajo", font));
                        clLegajo.BorderWidth = 0;
                        clLegajo.BorderWidthBottom = 0.75f;

                        PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", font));
                        clNombre.BorderWidth = 0;
                        clNombre.BorderWidthBottom = 0.75f;

                        PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", font));
                        clApellido.BorderWidth = 0;
                        clApellido.BorderWidthBottom = 0.75f;

                        PdfPCell cldireccion = new PdfPCell(new Phrase("Direccion", font));
                        cldireccion.BorderWidth = 0;
                        cldireccion.BorderWidthBottom = 0.75f;

                        PdfPCell cltelefono = new PdfPCell(new Phrase("Telefono", font));
                        cltelefono.BorderWidth = 0;
                        cltelefono.BorderWidthBottom = 0.75f;

                        PdfPCell clmateria1 = new PdfPCell(new Phrase("Materia 1", font));
                        clmateria1.BorderWidth = 0;
                        clmateria1.BorderWidthBottom = 0.75f;

                        PdfPCell clmateria2 = new PdfPCell(new Phrase("Materia 2", font));
                        clmateria2.BorderWidth = 0;
                        clmateria2.BorderWidthBottom = 0.75f;

                        PdfPCell clmateria3 = new PdfPCell(new Phrase("Materia 3", font));
                        clmateria3.BorderWidth = 0;
                        clmateria3.BorderWidthBottom = 0.75f;

                        PdfPCell clmateria4 = new PdfPCell(new Phrase("Materia 4", font));
                        clmateria4.BorderWidth = 0;
                        clmateria4.BorderWidthBottom = 0.75f;

                        PdfPCell clmateria5 = new PdfPCell(new Phrase("Materia 5", font));
                        clmateria5.BorderWidth = 0;
                        clmateria5.BorderWidthBottom = 0.75f;

                        PdfPCell clmateria6 = new PdfPCell(new Phrase("Materia 6", font));
                        clmateria6.BorderWidth = 0;
                        clmateria6.BorderWidthBottom = 0.75f;

                        PdfPCell clmateria7 = new PdfPCell(new Phrase("Materia 7", font));
                        clmateria7.BorderWidth = 0;
                        clmateria7.BorderWidthBottom = 0.75f;

                        PdfPCell clmateria8 = new PdfPCell(new Phrase("Materia 8", font));
                        clmateria8.BorderWidth = 0;
                        clmateria8.BorderWidthBottom = 0.75f;


                        tblPrueba.AddCell(clLegajo);
                        tblPrueba.AddCell(clNombre);
                        tblPrueba.AddCell(clApellido);
                        tblPrueba.AddCell(cldireccion);
                        tblPrueba.AddCell(cltelefono);
                        tblPrueba.AddCell(clmateria1);
                        tblPrueba.AddCell(clmateria2);
                        tblPrueba.AddCell(clmateria3);
                        tblPrueba.AddCell(clmateria4);
                        tblPrueba.AddCell(clmateria5);
                        tblPrueba.AddCell(clmateria6);
                        tblPrueba.AddCell(clmateria7);
                        tblPrueba.AddCell(clmateria8);

                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM estudiantes WHERE legajo = @legajo", conexion);
                        cmd.Parameters.AddWithValue("@legajo", legajotxt.Text);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        while (leer.Read())
                        {
                            tblPrueba.AddCell(new Phrase(leer["legajo"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["nombre"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["apellido"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["direccion"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["telefono"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["materia1"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["materia2"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["materia3"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["materia4"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["materia5"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["materia6"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["materia7"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["materia8"].ToString(), font));
                        }
                        conexion.Close();

                        doc.Add(tblPrueba);
                        doc.Close();

                        // Agregar un retraso de 5 segundos
                        Task.Delay(5000).Wait();

                        // Habilitar el botón después de completar el proceso
                        this.Invoke((MethodInvoker)delegate
                        {
                            btnestudiante.Enabled = true;
                        });

                        MessageBox.Show("Reporte generado con éxito en el escritorio.");
                    });
                }
            }
        }

        private async void btnpagos_Click(object sender, EventArgs e)
        {
            if (legajopagostxt.Text == "")
            {
                MessageBox.Show("Debe ingresar un legajo.");
                return;
            }
            else
            {
                // desabilito el boton para evitar que se hagan multiples clicks
                btnpagos.Enabled = false;

                // Verifico si el legajo existe en la base de datos
                if (!LegajoExiste(legajopagostxt.Text))
                {
                    MessageBox.Show("El legajo ingresado no existe en la base de datos.");
                    return;
                }
                else
                {
                    // Generar el PDF en un hilo separado
                    await Task.Run(() =>
                    {
                        Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                        string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\ReportePagos.pdf";
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                        doc.Open();

                        iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        doc.Add(new Paragraph("Reporte de Pagos", font));
                        doc.Add(Chunk.NEWLINE);
                        doc.Add(new Paragraph("Legajo del estudiante: " + legajopagostxt.Text, font));
                        doc.Add(Chunk.NEWLINE);
                        doc.Add(Chunk.NEWLINE);

                        PdfPTable tblPrueba = new PdfPTable(10);
                        tblPrueba.WidthPercentage = 100;

                        PdfPCell clLegajo = new PdfPCell(new Phrase("Legajo", font));
                        clLegajo.BorderWidth = 0;
                        clLegajo.BorderWidthBottom = 0.75f;

                        PdfPCell clMatricula = new PdfPCell(new Phrase("Matricula", font));
                        clMatricula.BorderWidth = 0;
                        clMatricula.BorderWidthBottom = 0.75f;

                        PdfPCell clmes1 = new PdfPCell(new Phrase("mes1", font));
                        clmes1.BorderWidth = 0;
                        clmes1.BorderWidthBottom = 0.75f;

                        PdfPCell clmes2 = new PdfPCell(new Phrase("mes2", font));
                        clmes2.BorderWidth = 0;
                        clmes2.BorderWidthBottom = 0.75f;

                        PdfPCell clmes3 = new PdfPCell(new Phrase("mes3", font));
                        clmes3.BorderWidth = 0;
                        clmes3.BorderWidthBottom = 0.75f;

                        PdfPCell clmes4 = new PdfPCell(new Phrase("mes4", font));
                        clmes4.BorderWidth = 0;
                        clmes4.BorderWidthBottom = 0.75f;

                        PdfPCell clmes5 = new PdfPCell(new Phrase("mes5", font));
                        clmes5.BorderWidth = 0;
                        clmes5.BorderWidthBottom = 0.75f;

                        PdfPCell clmes6 = new PdfPCell(new Phrase("mes6", font));
                        clmes6.BorderWidth = 0;
                        clmes6.BorderWidthBottom = 0.75f;

                        PdfPCell clmes7 = new PdfPCell(new Phrase("mes7", font));
                        clmes7.BorderWidth = 0;
                        clmes7.BorderWidthBottom = 0.75f;

                        PdfPCell clmes8 = new PdfPCell(new Phrase("mes8", font));
                        clmes8.BorderWidth = 0;
                        clmes8.BorderWidthBottom = 0.75f;

                        tblPrueba.AddCell(clLegajo);
                        tblPrueba.AddCell(clMatricula);
                        tblPrueba.AddCell(clmes1);
                        tblPrueba.AddCell(clmes2);
                        tblPrueba.AddCell(clmes3);
                        tblPrueba.AddCell(clmes4);
                        tblPrueba.AddCell(clmes5);
                        tblPrueba.AddCell(clmes6);
                        tblPrueba.AddCell(clmes7);
                        tblPrueba.AddCell(clmes8);

                        conexion.Open();
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM pagos WHERE legajo = @legajo", conexion);
                        cmd.Parameters.AddWithValue("@legajo", legajopagostxt.Text);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        while (leer.Read())
                        {
                            tblPrueba.AddCell(new Phrase(leer["legajo"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["matricula"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["mes1"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["mes2"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["mes3"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["mes4"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["mes5"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["mes6"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["mes7"].ToString(), font));
                            tblPrueba.AddCell(new Phrase(leer["mes8"].ToString(), font));
                        }
                        conexion.Close();

                        doc.Add(tblPrueba);
                        doc.Close();

                        // Agregar un retraso de 5 segundos
                        Task.Delay(5000).Wait();

                        // Habilitar el botón después de completar el proceso
                        this.Invoke((MethodInvoker)delegate
                        {
                            btnpagos.Enabled = true;
                        });

                        MessageBox.Show("Reporte generado con éxito en el escritorio.");
                    });
                }
            }
        }
    }
}
