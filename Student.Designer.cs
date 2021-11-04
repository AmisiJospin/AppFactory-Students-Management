namespace Appfactory
{
    partial class Student
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logIn = new System.Windows.Forms.Button();
            this.passStudent = new System.Windows.Forms.TextBox();
            this.pseudoStudent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Appfactory.Properties.Resources.b;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logIn);
            this.panel1.Controls.Add(this.passStudent);
            this.panel1.Controls.Add(this.pseudoStudent);
            this.panel1.Location = new System.Drawing.Point(244, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 544);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Appfactory.Properties.Resources.pass;
            this.pictureBox5.Location = new System.Drawing.Point(63, 294);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 54);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Appfactory.Properties.Resources.admin1;
            this.pictureBox4.Location = new System.Drawing.Point(63, 193);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Appfactory.Properties.Resources.Students_512;
            this.pictureBox1.Location = new System.Drawing.Point(249, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logIn.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logIn.Location = new System.Drawing.Point(118, 393);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(440, 57);
            this.logIn.TabIndex = 43;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // passStudent
            // 
            this.passStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passStudent.ForeColor = System.Drawing.Color.Black;
            this.passStudent.Location = new System.Drawing.Point(118, 294);
            this.passStudent.Multiline = true;
            this.passStudent.Name = "passStudent";
            this.passStudent.PasswordChar = '.';
            this.passStudent.Size = new System.Drawing.Size(440, 47);
            this.passStudent.TabIndex = 42;
            this.passStudent.Text = "Password";
            this.passStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passStudent.MouseEnter += new System.EventHandler(this.passStudent_MouseEnter);
            this.passStudent.MouseLeave += new System.EventHandler(this.passStudent_MouseLeave);
            // 
            // pseudoStudent
            // 
            this.pseudoStudent.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoStudent.ForeColor = System.Drawing.Color.Black;
            this.pseudoStudent.Location = new System.Drawing.Point(118, 193);
            this.pseudoStudent.Multiline = true;
            this.pseudoStudent.Name = "pseudoStudent";
            this.pseudoStudent.Size = new System.Drawing.Size(440, 54);
            this.pseudoStudent.TabIndex = 41;
            this.pseudoStudent.Text = "Af-00";
            this.pseudoStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pseudoStudent.MouseEnter += new System.EventHandler(this.pseudoStudent_MouseEnter);
            this.pseudoStudent.MouseLeave += new System.EventHandler(this.pseudoStudent_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Appfactory.Properties.Resources.homePage;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.choiceLogin_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appfactory.Properties.Resources.bchd;
            this.ClientSize = new System.Drawing.Size(1121, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeStudent);
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.TextBox passStudent;
        private System.Windows.Forms.TextBox pseudoStudent;
        private System.Windows.Forms.Button button1;
    }
}