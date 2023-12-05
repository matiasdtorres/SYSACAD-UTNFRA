using biblioteca;
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
        requisitosAcademicos gestionarRequisitosAcademicos;
        listasDeEspera gestionarListasDeEspera;
        perfilesDeProfes gestionarPerfilesDeProfes;
        validar validaciones;
        correccionProfe serializacion;

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

        private void btngestionarrequisitosacademicos_Click(object sender, EventArgs e)
        {
            if (gestionarRequisitosAcademicos == null)
            {
                gestionarRequisitosAcademicos = new requisitosAcademicos();
                gestionarRequisitosAcademicos.FormClosed += GestionarRequisitosAcademicos_FormClosed;
                gestionarRequisitosAcademicos.MdiParent = this;
                gestionarRequisitosAcademicos.Show();
            }
            else
            {
                gestionarRequisitosAcademicos.Activate();
            }
        }

        private void GestionarRequisitosAcademicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            gestionarRequisitosAcademicos = null;
        }

        private void btnlistasdeespera_Click(object sender, EventArgs e)
        {
            if (gestionarListasDeEspera == null)
            {
                gestionarListasDeEspera = new listasDeEspera();
                gestionarListasDeEspera.FormClosed += GestionarListasDeEspera_FormClosed;
                gestionarListasDeEspera.MdiParent = this;
                gestionarListasDeEspera.Show();
            }
            else
            {
                gestionarListasDeEspera.Activate();
            }
        }

        private void GestionarListasDeEspera_FormClosed(object sender, FormClosedEventArgs e)
        {
            gestionarListasDeEspera = null;
        }

        private void btnperfilesdeprofes_Click(object sender, EventArgs e)
        {
            if (gestionarPerfilesDeProfes == null)
            {
                gestionarPerfilesDeProfes = new perfilesDeProfes();
                gestionarPerfilesDeProfes.FormClosed += GestionarPerfilesDeProfes_FormClosed;
                gestionarPerfilesDeProfes.MdiParent = this;
                gestionarPerfilesDeProfes.Show();
            }
            else
            {
                gestionarPerfilesDeProfes.Activate();
            }
        }

        private void GestionarPerfilesDeProfes_FormClosed(object sender, FormClosedEventArgs e)
        {
            gestionarPerfilesDeProfes = null;
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if (validaciones == null)
            {
                validaciones = new validar();
                validaciones.FormClosed += Validaciones_FormClosed;
                validaciones.MdiParent = this;
                validaciones.Show();
            }
            else
            {
                validaciones.Activate();
            }
        }

        private void Validaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            validaciones = null;
        }

        private void btnprofecorreccion_Click(object sender, EventArgs e)
        {
            if (serializacion == null)
            {
                serializacion = new correccionProfe();
                serializacion.FormClosed += serializacion_FormClosed;
                serializacion.MdiParent = this;
                serializacion.Show();
            }
            else
            {
                serializacion.Activate();
            }
        }

        private void serializacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            serializacion = null;
        }
    }
}
