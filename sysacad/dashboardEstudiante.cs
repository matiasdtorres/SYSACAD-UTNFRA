using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sysacad
{
    public partial class dashboardEstudiante : Form
    {
        login logout;
        public dashboardEstudiante()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
