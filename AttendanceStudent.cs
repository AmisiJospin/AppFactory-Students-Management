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
    public partial class AttendanceStudent : Form
    {
        public AttendanceStudent()
        {
            InitializeComponent();
            StudentsTimeIn();
            StudentsTimeOut();

            
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        private void backViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudent go = new ViewStudent();
            this.Hide();
            go.ShowDialog();
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            AdminUser go = new AdminUser();
            this.Hide();
            go.ShowDialog();
        }

        private void StudentsTimeIn()
        {

            for (int j = 0; j < DataManagement.students.Length; j++)
            {
                if (DataManagement.students[j] != null)
                {
                    if (DataManagement.students[j].Name != null)
                    {

                        timeIn.AppendText(Environment.NewLine + "Name: " + DataManagement.students[j].Name + Environment.NewLine
                        + "Time In: " + DataManagement.students[j].TimeIn + Environment.NewLine);

                    }
                }

            }

        }

        private void StudentsTimeOut()
        {

            for (int j = 0; j < DataManagement.students.Length; j++)
            {
                if (DataManagement.students[j] != null)
                {
                    if (DataManagement.students[j].Name != null)
                    {

                        timeOut.AppendText(Environment.NewLine + "Name: " + DataManagement.students[j].Name + Environment.NewLine
                        + "Time Out: " + DataManagement.students[j].TimeOut + Environment.NewLine);

                    }
                }

            }

        }

        private void attendanceClosed(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        private void AttendanceStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
