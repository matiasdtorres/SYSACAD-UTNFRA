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
    public partial class dashboardAdmin : Form
    {
        login logout;
        agregarEstudiante? agregarEstudiante;
        gestionarCurso? gestionarCurso;
        reportes generarReportes;

        public dashboardAdmin()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnagregarestudiante_Click(object sender, EventArgs e)
        {
            if (agregarEstudiante == null)
            {
                agregarEstudiante = new agregarEstudiante();
                agregarEstudiante.FormClosed += AgregarEstudiante_FormClosed;
                agregarEstudiante.MdiParent = this;
                agregarEstudiante.Show();
            }
            else
            {
                agregarEstudiante.Activate();
            }

        }

        private void AgregarEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            agregarEstudiante = null;
        }

        private void btngestionarcursos_Click(object sender, EventArgs e)
        {
            if (gestionarCurso == null)
            {
                gestionarCurso = new gestionarCurso();
                gestionarCurso.FormClosed += GestionarCurso_FormClosed;
                gestionarCurso.MdiParent = this;
                gestionarCurso.Show();
            }
            else
            {
                gestionarCurso.Activate();
            }
        }

        private void GestionarCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            gestionarCurso = null;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                logout = new login();
                logout.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btngenerarreportes_Click(object sender, EventArgs e)
        {
            if (generarReportes == null)
            {
                generarReportes = new reportes();
                generarReportes.FormClosed += GenerarReportes_FormClosed;
                generarReportes.MdiParent = this;
                generarReportes.Show();
            }
            else
            {
                generarReportes.Activate();
            }
        }

        private void GenerarReportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            generarReportes = null;
        }
    }
}
