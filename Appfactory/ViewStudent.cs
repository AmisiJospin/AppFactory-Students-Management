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
    public partial class ViewStudent : Form
    {
        public static int index;
        public ViewStudent()
        {
            InitializeComponent();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        // Button of showing all the students

        private void showStudents_Click(object sender, EventArgs e)
        {
            ShowStudents();
        }

        //A method of showing all information that come from the array and show it the textBox4

        private void ShowStudents()
        {

            textBox4.Text = "";

            for (int j = 0; j < DataManagement.students.Length; j++)
            {
                if (DataManagement.students[j] != null)
                {
                    if (DataManagement.students[j].Name != null)
                    {

                        textBox4.AppendText(Environment.NewLine + "Name: " + DataManagement.students[j].Name + Environment.NewLine + "\n" + "Age: " + DataManagement.students[j].Age + Environment.NewLine + "Gender: " + DataManagement.students[j].Gender + Environment.NewLine
                        + "Location: " + DataManagement.students[j].Location + Environment.NewLine + "Phone Number: " + DataManagement.students[j].PhoneNumber + Environment.NewLine + "Laptop Number: " + DataManagement.students[j].ImeiNumber +
                           Environment.NewLine + "Student Number: " + DataManagement.students[j].StudentNumber + Environment.NewLine + "Description: " + DataManagement.students[j].Description + Environment.NewLine + "\n" + "Serial Number: " + DataManagement.students[j].SerialNum + Environment.NewLine + "Mac Address: " + DataManagement.students[j].MacAddress + Environment.NewLine
                        );

                    }
                }

            }

        }

        // A Method of returning back in home page.

        private void backHomePage_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();

        }

        private void closeViewStudent(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        // Clean all of the information with Button in the textbox4

        private void clearShowBox_Click(object sender, EventArgs e)
        {
            textBox4.Clear();

        }

        // delete all the students in the array.

        private void deleteAllStudents_Click(object sender, EventArgs e)
        {
            DialogResult input = MessageBox.Show("Are you sure you want to delete all students?", "Attention!", MessageBoxButtons.YesNo);
            if (input == DialogResult.Yes)
            {
                for (byte a = 0; a < DataManagement.students.Length; a++)
                {
                    DataManagement.students[a] = null;
                }
                MessageBox.Show("All students have been deleted");
                textBox4.Clear();
            }
        }

        // Button of searching student.

        private void searchStudent_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }

        // Searching Method By Name or Id Student and show information in textBox4

        private void SearchStudents()
        {

            textBox4.Text = "";

            if (textBox5.Text.Length > 0)
            {
                for (int j = 0; j < DataManagement.students.Length; j++)
                {
                    if (DataManagement.students[j] != null)
                    {
                        if ((DataManagement.students[j].Name != null && DataManagement.students[j].Name.ToLower().Contains(textBox5.Text.ToLower())) || (DataManagement.students[j].StudentNumber != null && DataManagement.students[j].StudentNumber.ToLower().Contains(textBox5.Text.ToLower())))
                        {
                            textBox4.AppendText(Environment.NewLine + "Name: " + DataManagement.students[j].Name + Environment.NewLine + "\n" + "Age: " + DataManagement.students[j].Age + Environment.NewLine + "Gender: " + DataManagement.students[j].Gender + Environment.NewLine
                        + "Location :" + DataManagement.students[j].Location + Environment.NewLine + "Phone Number: " + DataManagement.students[j].PhoneNumber + Environment.NewLine + "Laptop Number: " + DataManagement.students[j].ImeiNumber +
                           Environment.NewLine + "Student Number: " + DataManagement.students[j].StudentNumber + Environment.NewLine + "Description: " + DataManagement.students[j].Description + Environment.NewLine + "\n" + "Serial Number: " + DataManagement.students[j].SerialNum + Environment.NewLine + "Mac Address: " + DataManagement.students[j].MacAddress + Environment.NewLine
                        );

                        }
                    }

                }
                textBox5.Clear();
            }
        }

        private void deleteAStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        // Delete a student using his/her own Id

        private void DeleteStudent()
        {
            textBox4.Clear();
            textBox4.Text = "\n Type a Name or Id of a student in searchBox in order to delete in the list" + Environment.NewLine + Environment.NewLine;

            for (int j = 0; j < DataManagement.students.Length; j++)
            {
                if (DataManagement.students[j].Name != null)
                {
                    if (DataManagement.students[j].Name.ToLower().Contains(textBox5.Text.ToLower()))
                    {
                        textBox4.AppendText(Environment.NewLine + "Name: " + DataManagement.students[j].Name + Environment.NewLine + "\n" + "Age: " + DataManagement.students[j].Age + Environment.NewLine + "Gender: " + DataManagement.students[j].Gender + Environment.NewLine
                        + "Location :" + DataManagement.students[j].Location + Environment.NewLine + "Phone Number: " + DataManagement.students[j].PhoneNumber + Environment.NewLine + "Laptop Number: " + DataManagement.students[j].ImeiNumber +
                           Environment.NewLine + "Student Number: " + DataManagement.students[j].StudentNumber + Environment.NewLine + "Description: " + DataManagement.students[j].Description + Environment.NewLine + "\n" + "Serial Number: " + DataManagement.students[j].SerialNum + Environment.NewLine + "Mac Address: " + DataManagement.students[j].MacAddress + Environment.NewLine
                        );
                    }

                    else if (DataManagement.students[j].StudentNumber.ToLower() == textBox5.Text.ToLower())
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to delete " + DataManagement.students[j].Name + "?", "Attention", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            MessageBox.Show(DataManagement.students[j].Name + " was deleted!");
                            DataManagement.students[j] = null;
                        }
                    }
                }
            }
        }

        // Go the update form by pressing the button update

        public void updateButtonEvent_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataManagement.students.Length; i++)
            {
                if (DataManagement.students[i] != null)
                {
                    if (DataManagement.students[i].StudentNumber != null)
                    {
                        if (DataManagement.students[i].StudentNumber.ToLower() == textBox5.Text.ToLower())
                        {
                            index = i;
                            UpdateStudent update = new UpdateStudent();
                            update.UpdateStudentSearch();
                            this.Hide();
                            update.ShowDialog();
                        }
                    }
                }
            }
        }

        private void profileStudent_Click(object sender, EventArgs e)
        {
            ViewProfile go = new ViewProfile();
            this.Hide();
            go.ShowDialog();
        }

        private void attendaceSTudent_Click(object sender, EventArgs e)
        {
            AttendanceStudent go = new AttendanceStudent();
            this.Hide();
            go.ShowDialog();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {

        }

    }
}
