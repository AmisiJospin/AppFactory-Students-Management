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
    public partial class RegisterUser : Form
    {
        
        byte userAge;
        char userGender;

        public RegisterUser()
        {
            InitializeComponent();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        private void RegisterUserClose(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        private void backHomePage_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }

        private void registerStudent_Click(object sender, EventArgs e)
        {
            string dateOfToday = "DD/MM/AAAA";
            string timeIN = "DD/MM/AAAA - 00:00:00";
            string timeOut = "DD/MM/AAAA - 00:00:00";

            DataManagement.AddNewStudent(textBox1.Text, UserAge(), UserGender(), textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox14.Text, textBox13.Text, textBox12.Text, dateOfToday, timeIN, timeOut, int.Parse(imageBox.Text));

            MessageBox.Show(textBox1.Text + " is added in our list");
            
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); textBox9.Clear();
            textBox14.Clear(); textBox13.Clear(); textBox12.Clear(); imageBox.Clear();

        }



        //private void RegisterStudent()
        //{

        //    int i = 0;
        //    while (i < DataManagement.students.Length)
        //    {
        //        if (DataManagement.students[i] == null)
        //        {
        //            DataManagement.students[i] = new Appfactory();

        //            if (textBox1.Text.Length < 2)
        //            {
        //                MessageBox.Show("Your name is invalid!");
        //            }
        //            else
        //            {
        //                DataManagement.students[i].Name = textBox1.Text;
        //            }


                   
        //            if ((byte.TryParse(textBox2.Text.ToLower(), out userAge)) && (userAge > 2 && userAge < 100))
        //            {
        //                DataManagement.students[i].Age = userAge;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Your age is invalid!");
        //            }

                    
        //            if ((char.TryParse(textBox3.Text.ToLower(), out userGender)) && (userGender.ToString().ToUpper() == "M" || userGender.ToString().ToUpper() == "F"))
        //            {
        //                DataManagement.students[i].Gender = userGender;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Your sex is invalid!");
        //            }

        //            if (textBox6.Text.Length < 2)
        //            {
        //                MessageBox.Show("Your location is not correct!");
        //            }

        //            else
        //            {
        //                DataManagement.students[i].Location = textBox6.Text;

        //            }

        //            if (textBox7.Text.Length < 9)
        //            {
        //                MessageBox.Show("Your phone number is not correct!");
        //            }

        //            else
        //            {
        //                DataManagement.students[i].PhoneNumber = long.Parse(textBox7.Text);

        //            }

                    

        //            if (textBox9.Text.Length < 4)
        //            {
        //                MessageBox.Show("Your laptop number is not correct!");
        //            }

        //            else
        //            {
        //                DataManagement.students[i].LaptopNumber = int.Parse(textBox9.Text);

        //            }

        //            if (textBox8.Text.Length < 3)
        //            {
        //                MessageBox.Show("Your student number is invalid!");
        //            }

        //            else
        //            {
        //                DataManagement.students[i].StudentNumber = textBox8.Text;

        //            }


        //            MessageBox.Show(DataManagement.students[i].Name + " is added in your list");

        //            break;
        //        }
        //        i++;
        //    }
        //    textBox1.Clear();
        //    textBox2.Clear();
        //    textBox3.Clear();
        //    textBox6.Clear();
        //    textBox7.Clear();
        //    textBox8.Clear();
        //    textBox9.Clear();
        //}

        // A method of checking student age where it is a byte data type 

       

        private byte UserAge() {
            if ((byte.TryParse(textBox2.Text.ToLower(), out userAge))){ 
                return userAge;
            }
            else
            {
                return 0;
            }
        }

        // A method of checking student gender where it is Male or Female.

        private char UserGender() {

            if ((char.TryParse(textBox3.Text.ToUpper(), out userGender)))
            {

                return userGender;
            }
            else
            {
                return '\0';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void RegisterUser_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

      

        
        
    }
}
