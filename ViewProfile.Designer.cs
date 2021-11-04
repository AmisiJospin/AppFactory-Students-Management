namespace Appfactory
{
    partial class ViewProfile
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nameProfile = new System.Windows.Forms.Label();
            this.ageProfile = new System.Windows.Forms.Label();
            this.genderProfile = new System.Windows.Forms.Label();
            this.locationProfile = new System.Windows.Forms.Label();
            this.phoneProfile = new System.Windows.Forms.Label();
            this.studentIdProfile = new System.Windows.Forms.Label();
            this.lapNumProfile = new System.Windows.Forms.Label();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(24, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 44;
            this.button1.Text = "<<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.backViewStudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(742, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 43);
            this.label3.TabIndex = 43;
            this.label3.Text = "Student Profile";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(294, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 45;
            this.button2.Text = "<<<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(735, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 46;
            this.button3.Text = ">>>";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.nextProfile_Click);
            // 
            // nameProfile
            // 
            this.nameProfile.AutoSize = true;
            this.nameProfile.BackColor = System.Drawing.Color.Transparent;
            this.nameProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProfile.Location = new System.Drawing.Point(452, 134);
            this.nameProfile.Name = "nameProfile";
            this.nameProfile.Size = new System.Drawing.Size(97, 34);
            this.nameProfile.TabIndex = 48;
            this.nameProfile.Text = "Name";
            // 
            // ageProfile
            // 
            this.ageProfile.AutoSize = true;
            this.ageProfile.BackColor = System.Drawing.Color.Transparent;
            this.ageProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageProfile.Location = new System.Drawing.Point(452, 186);
            this.ageProfile.Name = "ageProfile";
            this.ageProfile.Size = new System.Drawing.Size(70, 34);
            this.ageProfile.TabIndex = 49;
            this.ageProfile.Text = "Age";
            // 
            // genderProfile
            // 
            this.genderProfile.AutoSize = true;
            this.genderProfile.BackColor = System.Drawing.Color.Transparent;
            this.genderProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderProfile.Location = new System.Drawing.Point(452, 249);
            this.genderProfile.Name = "genderProfile";
            this.genderProfile.Size = new System.Drawing.Size(119, 34);
            this.genderProfile.TabIndex = 50;
            this.genderProfile.Text = "Gender";
            // 
            // locationProfile
            // 
            this.locationProfile.AutoSize = true;
            this.locationProfile.BackColor = System.Drawing.Color.Transparent;
            this.locationProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationProfile.Location = new System.Drawing.Point(452, 304);
            this.locationProfile.Name = "locationProfile";
            this.locationProfile.Size = new System.Drawing.Size(136, 34);
            this.locationProfile.TabIndex = 51;
            this.locationProfile.Text = "Location";
            // 
            // phoneProfile
            // 
            this.phoneProfile.AutoSize = true;
            this.phoneProfile.BackColor = System.Drawing.Color.Transparent;
            this.phoneProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneProfile.Location = new System.Drawing.Point(452, 368);
            this.phoneProfile.Name = "phoneProfile";
            this.phoneProfile.Size = new System.Drawing.Size(105, 34);
            this.phoneProfile.TabIndex = 52;
            this.phoneProfile.Text = "phone";
            // 
            // studentIdProfile
            // 
            this.studentIdProfile.AutoSize = true;
            this.studentIdProfile.BackColor = System.Drawing.Color.Transparent;
            this.studentIdProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdProfile.Location = new System.Drawing.Point(452, 432);
            this.studentIdProfile.Name = "studentIdProfile";
            this.studentIdProfile.Size = new System.Drawing.Size(152, 34);
            this.studentIdProfile.TabIndex = 53;
            this.studentIdProfile.Text = "studentId";
            // 
            // lapNumProfile
            // 
            this.lapNumProfile.AutoSize = true;
            this.lapNumProfile.BackColor = System.Drawing.Color.Transparent;
            this.lapNumProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapNumProfile.Location = new System.Drawing.Point(452, 499);
            this.lapNumProfile.Name = "lapNumProfile";
            this.lapNumProfile.Size = new System.Drawing.Size(107, 34);
            this.lapNumProfile.TabIndex = 54;
            this.lapNumProfile.Text = "laptop";
            // 
            // profilePic
            // 
            this.profilePic.BackColor = System.Drawing.Color.Transparent;
            this.profilePic.Image = global::Appfactory.Properties.Resources.admin;
            this.profilePic.Location = new System.Drawing.Point(58, 134);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(311, 399);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 55;
            this.profilePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(364, 707);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 32);
            this.label1.TabIndex = 56;
            this.label1.Text = "© 2017 -  AppFactory Student ";
            // 
            // ViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appfactory.Properties.Resources.b;
            this.ClientSize = new System.Drawing.Size(1121, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.lapNumProfile);
            this.Controls.Add(this.studentIdProfile);
            this.Controls.Add(this.phoneProfile);
            this.Controls.Add(this.locationProfile);
            this.Controls.Add(this.genderProfile);
            this.Controls.Add(this.ageProfile);
            this.Controls.Add(this.nameProfile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ViewProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProfile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeProfile);
            this.Load += new System.EventHandler(this.ViewProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label nameProfile;
        private System.Windows.Forms.Label ageProfile;
        private System.Windows.Forms.Label genderProfile;
        private System.Windows.Forms.Label locationProfile;
        private System.Windows.Forms.Label phoneProfile;
        private System.Windows.Forms.Label studentIdProfile;
        private System.Windows.Forms.Label lapNumProfile;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label label1;
    }
}