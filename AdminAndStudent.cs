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
    public partial class AdminAndStudent : Form
    {
        public AdminAndStudent()
        {
            InitializeComponent();

            DataManagement.studentsActivator();
            DataManagement.LoadStudentInToArrayFromFile();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            AdminUser go = new AdminUser();
            this.Hide();
            go.ShowDialog();
        }

        private void studentLogIn_Click(object sender, EventArgs e)
        {
            Student go = new Student();
            this.Hide();
            go.ShowDialog();
        }

        private void adminStudentClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpStudent go = new HelpStudent();
            this.Hide();
            go.ShowDialog();
        }

        private void AdminAndStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
