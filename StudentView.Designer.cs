namespace Appfactory
{
    partial class StudentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.profilestudentLogIN = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nameStd = new System.Windows.Forms.Label();
            this.studentListers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.studentViewProfile = new System.Windows.Forms.Panel();
            this.msgProfile = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.fbBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.profileStudentBox = new System.Windows.Forms.PictureBox();
            this.phoneProfile = new System.Windows.Forms.Label();
            this.locationProfile = new System.Windows.Forms.Label();
            this.genderProfile = new System.Windows.Forms.Label();
            this.ageProfile = new System.Windows.Forms.Label();
            this.nameProfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilestudentLogIN)).BeginInit();
            this.studentViewProfile.SuspendLayout();
            this.msgProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fbBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileStudentBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(882, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 35);
            this.button4.TabIndex = 48;
            this.button4.Text = "Sign Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.logOutStudent_Click);
            // 
            // profilestudentLogIN
            // 
            this.profilestudentLogIN.BackColor = System.Drawing.Color.Transparent;
            this.profilestudentLogIN.Image = global::Appfactory.Properties.Resources.admin;
            this.profilestudentLogIN.Location = new System.Drawing.Point(1019, 12);
            this.profilestudentLogIN.Name = "profilestudentLogIN";
            this.profilestudentLogIN.Size = new System.Drawing.Size(90, 86);
            this.profilestudentLogIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilestudentLogIN.TabIndex = 47;
            this.profilestudentLogIN.TabStop = false;
            this.profilestudentLogIN.Click += new System.EventHandler(this.profilestudentLogIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(364, 707);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 27);
            this.label1.TabIndex = 49;
            this.label1.Text = "© 2017 -  AppFactory Student ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(74, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 43);
            this.label3.TabIndex = 50;
            this.label3.Text = "Student View ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 51;
            this.button1.Text = "<<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameStd
            // 
            this.nameStd.AutoSize = true;
            this.nameStd.BackColor = System.Drawing.Color.Transparent;
            this.nameStd.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameStd.Location = new System.Drawing.Point(599, 9);
            this.nameStd.Name = "nameStd";
            this.nameStd.Size = new System.Drawing.Size(410, 31);
            this.nameStd.TabIndex = 52;
            this.nameStd.Text = "Hello! Nshimirimana Irakoze";
            // 
            // studentListers
            // 
            this.studentListers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentListers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.studentListers.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListers.Location = new System.Drawing.Point(25, 149);
            this.studentListers.Name = "studentListers";
            this.studentListers.Size = new System.Drawing.Size(467, 536);
            this.studentListers.TabIndex = 53;
            this.studentListers.UseCompatibleStateImageBehavior = false;
            this.studentListers.View = System.Windows.Forms.View.Details;
            this.studentListers.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.studentListers.SelectedIndexChanged += new System.EventHandler(this.studentListers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "         Classmates Name";
            this.columnHeader1.Width = 468;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(580, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 40);
            this.label2.TabIndex = 64;
            this.label2.Text = "Classmate  Profile";
            // 
            // studentViewProfile
            // 
            this.studentViewProfile.BackColor = System.Drawing.Color.Transparent;
            this.studentViewProfile.Controls.Add(this.msgProfile);
            this.studentViewProfile.Controls.Add(this.fbBox);
            this.studentViewProfile.Controls.Add(this.label5);
            this.studentViewProfile.Controls.Add(this.label6);
            this.studentViewProfile.Controls.Add(this.label7);
            this.studentViewProfile.Controls.Add(this.label8);
            this.studentViewProfile.Controls.Add(this.label9);
            this.studentViewProfile.Controls.Add(this.profileStudentBox);
            this.studentViewProfile.Controls.Add(this.phoneProfile);
            this.studentViewProfile.Controls.Add(this.locationProfile);
            this.studentViewProfile.Controls.Add(this.genderProfile);
            this.studentViewProfile.Controls.Add(this.ageProfile);
            this.studentViewProfile.Controls.Add(this.nameProfile);
            this.studentViewProfile.Location = new System.Drawing.Point(533, 182);
            this.studentViewProfile.Name = "studentViewProfile";
            this.studentViewProfile.Size = new System.Drawing.Size(520, 503);
            this.studentViewProfile.TabIndex = 65;
            // 
            // msgProfile
            // 
            this.msgProfile.BackColor = System.Drawing.Color.Transparent;
            this.msgProfile.Controls.Add(this.label4);
            this.msgProfile.Location = new System.Drawing.Point(1, 1);
            this.msgProfile.Name = "msgProfile";
            this.msgProfile.Size = new System.Drawing.Size(519, 502);
            this.msgProfile.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 29);
            this.label4.TabIndex = 65;
            this.label4.Text = "Click one of the name to view profile\r\n";
            // 
            // fbBox
            // 
            this.fbBox.Image = global::Appfactory.Properties.Resources.fb;
            this.fbBox.Location = new System.Drawing.Point(376, 7);
            this.fbBox.Name = "fbBox";
            this.fbBox.Size = new System.Drawing.Size(91, 82);
            this.fbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbBox.TabIndex = 75;
            this.fbBox.TabStop = false;
            this.fbBox.Click += new System.EventHandler(this.fbBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(51, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 74;
            this.label5.Text = "Phone #:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(51, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 37);
            this.label6.TabIndex = 73;
            this.label6.Text = "Location:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 37);
            this.label7.TabIndex = 72;
            this.label7.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(54, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 37);
            this.label8.TabIndex = 71;
            this.label8.Text = "Age:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(50, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 40);
            this.label9.TabIndex = 70;
            this.label9.Text = "Name: ";
            // 
            // profileStudentBox
            // 
            this.profileStudentBox.BackColor = System.Drawing.Color.Transparent;
            this.profileStudentBox.Image = global::Appfactory.Properties.Resources.admin1;
            this.profileStudentBox.Location = new System.Drawing.Point(142, 7);
            this.profileStudentBox.Name = "profileStudentBox";
            this.profileStudentBox.Size = new System.Drawing.Size(180, 151);
            this.profileStudentBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileStudentBox.TabIndex = 69;
            this.profileStudentBox.TabStop = false;
            // 
            // phoneProfile
            // 
            this.phoneProfile.AutoSize = true;
            this.phoneProfile.BackColor = System.Drawing.Color.Transparent;
            this.phoneProfile.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneProfile.Location = new System.Drawing.Point(217, 439);
            this.phoneProfile.Name = "phoneProfile";
            this.phoneProfile.Size = new System.Drawing.Size(111, 37);
            this.phoneProfile.TabIndex = 68;
            this.phoneProfile.Text = "phone";
            // 
            // locationProfile
            // 
            this.locationProfile.AutoSize = true;
            this.locationProfile.BackColor = System.Drawing.Color.Transparent;
            this.locationProfile.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationProfile.Location = new System.Drawing.Point(217, 375);
            this.locationProfile.Name = "locationProfile";
            this.locationProfile.Size = new System.Drawing.Size(141, 37);
            this.locationProfile.TabIndex = 67;
            this.locationProfile.Text = "Location";
            // 
            // genderProfile
            // 
            this.genderProfile.AutoSize = true;
            this.genderProfile.BackColor = System.Drawing.Color.Transparent;
            this.genderProfile.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderProfile.Location = new System.Drawing.Point(212, 244);
            this.genderProfile.Name = "genderProfile";
            this.genderProfile.Size = new System.Drawing.Size(128, 37);
            this.genderProfile.TabIndex = 66;
            this.genderProfile.Text = "Gender";
            // 
            // ageProfile
            // 
            this.ageProfile.AutoSize = true;
            this.ageProfile.BackColor = System.Drawing.Color.Transparent;
            this.ageProfile.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageProfile.Location = new System.Drawing.Point(220, 308);
            this.ageProfile.Name = "ageProfile";
            this.ageProfile.Size = new System.Drawing.Size(78, 37);
            this.ageProfile.TabIndex = 65;
            this.ageProfile.Text = "Age";
            // 
            // nameProfile
            // 
            this.nameProfile.AutoSize = true;
            this.nameProfile.BackColor = System.Drawing.Color.Transparent;
            this.nameProfile.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProfile.Location = new System.Drawing.Point(216, 175);
            this.nameProfile.Name = "nameProfile";
            this.nameProfile.Size = new System.Drawing.Size(106, 37);
            this.nameProfile.TabIndex = 64;
            this.nameProfile.Text = "Name";
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appfactory.Properties.Resources.bchd;
            this.ClientSize = new System.Drawing.Size(1121, 743);
            this.Controls.Add(this.studentViewProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentListers);
            this.Controls.Add(this.nameStd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.profilestudentLogIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeStudent);
            this.Load += new System.EventHandler(this.StudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilestudentLogIN)).EndInit();
            this.studentViewProfile.ResumeLayout(false);
            this.studentViewProfile.PerformLayout();
            this.msgProfile.ResumeLayout(false);
            this.msgProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fbBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileStudentBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox profilestudentLogIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nameStd;
        private System.Windows.Forms.ListView studentListers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel studentViewProfile;
        private System.Windows.Forms.PictureBox profileStudentBox;
        private System.Windows.Forms.Label phoneProfile;
        private System.Windows.Forms.Label locationProfile;
        private System.Windows.Forms.Label genderProfile;
        private System.Windows.Forms.Label ageProfile;
        private System.Windows.Forms.Label nameProfile;
        private System.Windows.Forms.Panel msgProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox fbBox;
    }
}