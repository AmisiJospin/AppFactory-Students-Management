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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        private void homePageClose(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        private void registerStudent_Click(object sender, EventArgs e)
        {
            RegisterUser user = new RegisterUser();
            this.Hide();
            user.ShowDialog();
        }

        private void viewStudent_Click(object sender, EventArgs e)
        {
            ViewStudent view = new ViewStudent();
            this.Hide();
            view.ShowDialog();
        }

        private void backAdminPage_Click(object sender, EventArgs e)
        {
            AdminUser home = new AdminUser();
            this.Hide();
            home.ShowDialog();
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            HelpStudent go = new HelpStudent();
            this.Hide();
            go.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
