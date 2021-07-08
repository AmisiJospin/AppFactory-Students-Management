using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Appfactory
{
    public partial class HelpStudent : Form
    {
        public HelpStudent()
        {
            Thread t = new Thread(new ThreadStart(LoadFirst));
            t.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            t.Abort();
            ////Initialization of the array and adding the 5 students in a file called studentManagement .
            DataManagement.studentsActivator();
            //DataManagement.AddFiveStudents();
            DataManagement.LoadStudentInToArrayFromFile();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        public void LoadFirst() {
            Application.Run(new SplashHome());
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            AdminAndStudent go = new AdminAndStudent();
            this.Hide();
            go.ShowDialog();
        }

        private void helpApp_Click(object sender, EventArgs e)
        {
            AppHelper go = new AppHelper();
            this.Hide();
            go.ShowDialog();
        }

        private void helpStudentColse(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        private void HelpStudent_Load(object sender, EventArgs e)
        {

        }


 
    }
}
