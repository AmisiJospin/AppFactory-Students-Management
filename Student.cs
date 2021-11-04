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
    public partial class Student : Form
    {
        public static string nameStudent;

        public Student()
        {
            InitializeComponent();
            DataManagement.studentsActivator();
            //DataManagement.AddFiveStudents();
            DataManagement.LoadStudentInToArrayFromFile();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        private void choiceLogin_Click(object sender, EventArgs e)
        {
            AdminAndStudent go = new AdminAndStudent();
            this.Hide();
            go.ShowDialog();
        }

        private void closeStudent(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pseudoStudent_MouseEnter(object sender, EventArgs e)
        {
            if (pseudoStudent.Text.Equals("Af-00")) {
                pseudoStudent.Text = "";
                // This code change a color of a text when an user is typing something
                pseudoStudent.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void pseudoStudent_MouseLeave(object sender, EventArgs e)
        {
            if (pseudoStudent.Text.Equals(""))
            {
                pseudoStudent.Text = "Af-00";
            }
        }

        private void passStudent_MouseEnter(object sender, EventArgs e)
        {
            if (passStudent.Text.Equals("Password")) {
                passStudent.Text = "";

                // This code change a color of a text when an user is typing something
                passStudent.ForeColor = System.Drawing.Color.Black;
                
            }
        }

        private void passStudent_MouseLeave(object sender, EventArgs e)
        {
            if (passStudent.Text.Equals(""))
            {
                passStudent.Text = "Password";

            }
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataManagement.students.Length; i++)
            {
                if (DataManagement.students[i].Name != null && pseudoStudent.Text.ToLower() == DataManagement.students[i].StudentNumber.ToLower() && passStudent.Text.Equals("malawi"))
                {
                    string getTime = DateTime.Now.ToString();
                    DataManagement.students[i].TimeIn = getTime;
                    nameStudent = DataManagement.students[i].Name;
                    DataManagement.WriteStudentToFileFromArray();

                    StudentView go = new StudentView();
                    this.Hide();
                    go.ShowDialog();
                }  
            }
        }

        public virtual string NameStudent() {
            return nameStudent;
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

    }
}

