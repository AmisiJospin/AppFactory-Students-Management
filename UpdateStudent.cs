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
    public partial class UpdateStudent : Form
    {
        byte userAge;
        char userGender;

        public UpdateStudent()
        {
            InitializeComponent();

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Width / 2;
        }

        // searching a student that you want to Update.

        private void updateSearch_Click(object sender, EventArgs e)
        {
            UpdateStudentSearch();
        }

        // Updatent a student by searching with his/her own ID.

        public void UpdateStudentSearch()
        {

            for (int i = 0; i < DataManagement.students.Length; i++)
            {
                if (DataManagement.students[i] != null)
                {
                    if (DataManagement.students[i].StudentNumber != null)
                    {
                        if (i == ViewStudent.index)
                        {
                            textBox1.Text = DataManagement.students[i].Name;
                            textBox2.Text = "" + DataManagement.students[i].Age;
                            textBox3.Text = "" + DataManagement.students[i].Gender;
                            textBox6.Text = DataManagement.students[i].Location;
                            textBox7.Text = "" + DataManagement.students[i].PhoneNumber;
                            textBox8.Text = DataManagement.students[i].StudentNumber;
                            textBox9.Text = "" + DataManagement.students[i].ImeiNumber;
                            textBox14.Text = DataManagement.students[i].Description;
                            textBox13.Text =  DataManagement.students[i].SerialNum;
                            textBox12.Text = DataManagement.students[i].MacAddress;
                            imageBox.Text = "" + DataManagement.students[i].Images;
                        }
                    }
                }
            }
            //textBox5.Clear();
        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            UpdateStudentButton();
        }

        // Update a student by clicking to the button update.

        public void UpdateStudentButton()
        {
            string dateOfToday = "DD/MM/AAAA";
            string timeIN = "00:00:00";
            string timeOut = "00:00:00";
            DataManagement.Update(textBox1.Text, UserAge(), UserGender(), textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox14.Text, textBox13.Text, textBox12.Text, dateOfToday,timeIN,timeOut, int.Parse(imageBox.Text));

            MessageBox.Show(textBox1.Text + " is updated in our list");

            textBox1.Clear(); textBox14.Clear(); textBox13.Clear(); textBox12.Clear();  textBox2.Clear();
            textBox3.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); textBox9.Clear(); imageBox.Clear();

        }

        private byte UserAge()
        {
            if ((byte.TryParse(textBox2.Text.ToLower(), out userAge)))
            {
                return userAge;
            }
            else
            {
                return 0;
            }
        }

        // A method of checking student gender where it is Male or Female.

        private char UserGender()
        {

            if ((char.TryParse(textBox3.Text.ToUpper(), out userGender)))
            {

                return userGender;
            }
            else
            {
                return '\0';
            }
        }

        // Back to the View Student.

        private void backViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudent input = new ViewStudent();
            this.Hide();
            input.ShowDialog();

        }

        // Exit the form Update

        private void closeUpdate(object sender, FormClosedEventArgs e)
        {
            DataManagement.WriteStudentToFileFromArray();
            Application.Exit();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
