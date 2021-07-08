using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Appfactory
{
    public partial class StudentView : Form
    {

        string userFb;

        public StudentView()
        {
            InitializeComponent();

            DataManagement.studentsActivator();
            //DataManagement.AddFiveStudents();
            DataManagement.LoadStudentInToArrayFromFile();
            studentViewProfile.Hide();
            ShowNames();
            Student go = new Student();
            nameStd.Text = "Hello! " + go.NameStudent();
            msgProfile.Show();
            setProfileStudent();
            profileStudent();


            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Student go = new Student();
            this.Hide();
            go.ShowDialog();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            msgProfile.Hide();
            for (int i = 0; i < DataManagement.students.Length; i++)
            {
                if (DataManagement.students[e.ItemIndex].Name == DataManagement.students[i].Name) {
                    nameProfile.Text = DataManagement.students[i].Name;
                    ageProfile.Text = "" + DataManagement.students[i].Age;
                    genderProfile.Text = "" + DataManagement.students[i].Gender;
                    locationProfile.Text = DataManagement.students[i].Location;
                    phoneProfile.Text = DataManagement.students[i].PhoneNumber;
                    profileStudentBox.Image = (Image)DataManagement.images[DataManagement.students[i].Images];
                    userFb = DataManagement.students[i].Name;
                }
            }
        }

        /// <summary>
        /// Show students in list view
        /// </summary>
        private void ShowNames() {
            for (int i = 0; i < DataManagement.students.Length; i++)
            {
                if (DataManagement.students[i].Name != null) {
                    studentListers.Items.Add(DataManagement.students[i].Name);
                    msgProfile.Hide();
                    studentViewProfile.Show();
                }
            }
        }

        

        private void closeStudent(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        private void setProfileStudent() {

            string user = FormatUserName(nameStd.Text.ToLower());

            for (int i = 0; i < DataManagement.students.Length; i++)
            {
                if (DataManagement.students[i].Name != null && DataManagement.students[i].Name == user)
                {
                    profileStudentBox.Image = (Image)DataManagement.images[DataManagement.students[i].Images];
                }
            }
        }

        private void profileStudent()
        {
            string user = FormatUserName(nameStd.Text.ToLower());

            for (int i = 0; i < DataManagement.students.Length; i++)
            {
                if (DataManagement.students[i].Name != null && DataManagement.students[i].Name.ToLower() == user)
                {
                    profilestudentLogIN.Image = (Image)DataManagement.images[DataManagement.students[i].Images];
                }
            }


        }

        private void logOutStudent_Click(object sender, EventArgs e)
        {
            string user = FormatUserName(nameStd.Text.ToLower());

            for (int i = 0; i < DataManagement.students.Length; i++)
            {
                if (DataManagement.students[i].Name != null && DataManagement.students[i].Name.ToLower() == user)
                {
                    string timeIn  = DataManagement.students[i].TimeIn;
                    DataManagement.students[i].TimeOut = DateTime.Now.ToString();
                    DataManagement.WriteStudentToFileFromArray();

                    AdminAndStudent go = new AdminAndStudent();
                    this.Hide();
                    go.Show();
                    break;
                }
            }
        }

        private void fbBox_Click(object sender, EventArgs e)
        {
            ProcessStartInfo fbButton = new ProcessStartInfo("www.facebook.com/" + nameConcated(userFb));
            Process.Start(fbButton);
               
        }

        private string nameConcated(string name)
        {
            name = name.Replace(" ", ".");
            return name;
        }

        private string FormatUserName(string title)
        {
            title = title.Remove(0, 7);
            //title = title.Remove(0);
            return title;
        }

        private void StudentView_Load(object sender, EventArgs e)
        {

        }

        private void profilestudentLogIN_Click(object sender, EventArgs e)
        {

        }

        private void studentListers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
