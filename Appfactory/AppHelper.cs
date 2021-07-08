using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Appfactory
{
    public partial class AppHelper : Form
    {
        public AppHelper()
        {
            InitializeComponent();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        private void backHelpStudent_Click(object sender, EventArgs e)
        {
            HelpStudent go = new HelpStudent();
            this.Hide();
            go.ShowDialog();

        }

        private void closeHelper(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        private void AppHelper_Load(object sender, EventArgs e)
        {

        }

    }
}
