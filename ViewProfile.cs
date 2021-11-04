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
    public partial class ViewProfile : Form
    {
        public static int index = index + 1;

        public ViewProfile()
        {
            InitializeComponent();
            DisplayAStudent();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        private void backViewStudent_Click(object sender, EventArgs e)
        {
           
            ViewStudent go = new ViewStudent();
            this.Hide();
            go.ShowDialog();
                  
            
        }

        private void closeProfile(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        // Display At the first one Student
        public void DisplayAStudent() {
            for (int i = 0; i < DataManagement.students.Length; i++)
            {
                if (DataManagement.students[i] != null) {
                    nameProfile.Text = "Name: " + DataManagement.students[0].Name;
                    ageProfile.Text = "Age: " + DataManagement.students[0].Age;
                    genderProfile.Text = "Gender: " + DataManagement.students[0].Gender;
                    locationProfile.Text = "Location: " + DataManagement.students[0].Location;
                    phoneProfile.Text = "Phone Number: " + DataManagement.students[0].PhoneNumber;
                    studentIdProfile.Text = "Student #: " + DataManagement.students[0].StudentNumber;
                    lapNumProfile.Text = "Laptop #: " + DataManagement.students[0].ImeiNumber;
                    profilePic.Image = (Image)DataManagement.images[DataManagement.students[0].Images];
                }
            }
        }
        
        //Button next to the view profile

        private void nextProfile_Click(object sender, EventArgs e)
        {
            if (DataManagement.students[index].Name != null && index < DataManagement.students.Length)
            {
                nameProfile.Text = "Name: " + DataManagement.students[index].Name;
                ageProfile.Text = "Age: " + DataManagement.students[index].Age;
                genderProfile.Text = "Gender: " + DataManagement.students[index].Gender;
                locationProfile.Text = "Location: " + DataManagement.students[index].Location;
                phoneProfile.Text = "Phone Number: " + DataManagement.students[index].PhoneNumber;
                studentIdProfile.Text = "Student #: " + DataManagement.students[index].StudentNumber;
                lapNumProfile.Text = "Laptop #: " + DataManagement.students[index].ImeiNumber;
                profilePic.Image = (Image)DataManagement.images[DataManagement.students[index].Images];

                index++;
            }
            else {
                index = 0;
            }
        }

        //Button previous to the view profile

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (DataManagement.students[index - 1].Name != null && index < DataManagement.students.Length)
            {
                nameProfile.Text = "Name: " + DataManagement.students[index - 1].Name;
                ageProfile.Text = "Age: " + DataManagement.students[index - 1].Age;
                genderProfile.Text = "Gender: " + DataManagement.students[index - 1].Gender;
                locationProfile.Text = "Location: " + DataManagement.students[index - 1].Location;
                phoneProfile.Text = "Phone Number: " + DataManagement.students[index - 1].PhoneNumber;
                studentIdProfile.Text ="Student #: " + DataManagement.students[index - 1].StudentNumber;
                lapNumProfile.Text = "Laptop #: " + DataManagement.students[index - 1].ImeiNumber;
                profilePic.Image = (Image)DataManagement.images[DataManagement.students[index - 1].Images];

                index--;
            }
            else
            {
                index = index - 1;
            }
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
