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
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();

            ////Initialization of the array and adding the 5 students in a file called studentManagement .
            DataManagement.studentsActivator();
            //DataManagement.AddFiveStudents();
            DataManagement.LoadStudentInToArrayFromFile();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
            
          
        }

        private void logIn_Click(object sender, EventArgs e)
        {
           
        }

        private void AdminType(object sender, EventArgs e)
        {
            if (pseudoUser.Text.Equals("Pseudo")) {
                pseudoUser.Text = "";
                // This code change a color of a text when an user is typing something
                pseudoUser.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void AdminLeave(object sender, EventArgs e)
        {
            if (pseudoUser.Text.Equals(""))
            {
                pseudoUser.Text = "Pseudo";
            }
        }

        private void AdminPassowrdEnter(object sender, EventArgs e)
        {
            if (passUser.Text.Equals("Password")) {
                passUser.Text = "";

                // This code change a color of a text when an user is typing something
                pseudoUser.ForeColor = System.Drawing.Color.Black;
                
            }
        }

        private void AdminPasswordLeave(object sender, EventArgs e)
        {

            if (passUser.Text.Equals(""))
            {
                passUser.Text = "Password";

            }
        }

        private void logIn_Click_1(object sender, EventArgs e)
        {

            if (pseudoUser.Text.Equals("admin") && passUser.Text.Equals("admin"))
            {
                HomePage welcome = new HomePage();
                this.Hide();
                welcome.ShowDialog();
                //Show() it goes direct to another form 
                //ShowDialog() it pop up another form.

            }

            else
            {
                MessageBox.Show("Your Pesudo or Password is incorrect");
            }
        }

        private void homeHelper_Click(object sender, EventArgs e)
        {
            AdminAndStudent go = new AdminAndStudent();
            this.Hide();
            go.ShowDialog();
        }

        private void adminClose(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        private void AdminUser_Load(object sender, EventArgs e)
        {
           
           
         


        }

       
    }
}
