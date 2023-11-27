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

        private void btncurso_Click(object sender, EventArgs e)
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

            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clLegajo);

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

            MessageBox.Show("Reporte generado con éxito en el escritorio.");
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

        private void btnestudiante_Click(object sender, EventArgs e)
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

            PdfPTable tblPrueba = new PdfPTable(9);
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

            tblPrueba.AddCell(clLegajo);
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(cldireccion);
            tblPrueba.AddCell(cltelefono);
            tblPrueba.AddCell(clmateria1);
            tblPrueba.AddCell(clmateria2);
            tblPrueba.AddCell(clmateria3);
            tblPrueba.AddCell(clmateria4);

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
            }
            conexion.Close();

            doc.Add(tblPrueba);
            doc.Close();

            MessageBox.Show("Reporte generado con éxito en el escritorio.");
        }

        private void btnpagos_Click(object sender, EventArgs e)
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

            PdfPTable tblPrueba = new PdfPTable(6);
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

            tblPrueba.AddCell(clLegajo);
            tblPrueba.AddCell(clMatricula);
            tblPrueba.AddCell(clmes1);
            tblPrueba.AddCell(clmes2);
            tblPrueba.AddCell(clmes3);
            tblPrueba.AddCell(clmes4);

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
            }
            conexion.Close();

            doc.Add(tblPrueba);
            doc.Close();

            MessageBox.Show("Reporte generado con éxito en el escritorio.");
        }
    }
}
