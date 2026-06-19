namespace GrindBookingSystem
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            menuStrip1 = new MenuStrip();
            tutorsToolStripMenuItem = new ToolStripMenuItem();
            addtutor_btn = new ToolStripMenuItem();
            removeTutorToolStripMenuItem = new ToolStripMenuItem();
            displayTutorDetailsToolStripMenuItem = new ToolStripMenuItem();
            updateTutorDetailsToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            removeStudentToolStripMenuItem = new ToolStripMenuItem();
            displayStudentDetailsToolStripMenuItem = new ToolStripMenuItem();
            updateStudentDetailsToolStripMenuItem = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            addClassToScheduleToolStripMenuItem = new ToolStripMenuItem();
            removeClassFromScheduleToolStripMenuItem = new ToolStripMenuItem();
            displayRoomScheduleToolStripMenuItem = new ToolStripMenuItem();
            updateClassDetailsToolStripMenuItem = new ToolStripMenuItem();
            bookinToolStripMenuItem = new ToolStripMenuItem();
            makeBookingToolStripMenuItem = new ToolStripMenuItem();
            manageBookingToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tutorsToolStripMenuItem, studentsToolStripMenuItem, scheduleToolStripMenuItem, bookinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(986, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // tutorsToolStripMenuItem
            // 
            tutorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addtutor_btn, removeTutorToolStripMenuItem, displayTutorDetailsToolStripMenuItem, updateTutorDetailsToolStripMenuItem });
            tutorsToolStripMenuItem.Name = "tutorsToolStripMenuItem";
            tutorsToolStripMenuItem.Size = new Size(78, 29);
            tutorsToolStripMenuItem.Text = "Tutors";
            // 
            // addtutor_btn
            // 
            addtutor_btn.Name = "addtutor_btn";
            addtutor_btn.Size = new Size(277, 34);
            addtutor_btn.Text = "Add Tutor";
            addtutor_btn.Click += addtutor_btn_Click;
            // 
            // removeTutorToolStripMenuItem
            // 
            removeTutorToolStripMenuItem.Name = "removeTutorToolStripMenuItem";
            removeTutorToolStripMenuItem.Size = new Size(277, 34);
            removeTutorToolStripMenuItem.Text = "Remove Tutor";
            // 
            // displayTutorDetailsToolStripMenuItem
            // 
            displayTutorDetailsToolStripMenuItem.Name = "displayTutorDetailsToolStripMenuItem";
            displayTutorDetailsToolStripMenuItem.Size = new Size(277, 34);
            displayTutorDetailsToolStripMenuItem.Text = "Display Tutor Details";
            displayTutorDetailsToolStripMenuItem.Click += displayTutorDetailsToolStripMenuItem_Click;
            // 
            // updateTutorDetailsToolStripMenuItem
            // 
            updateTutorDetailsToolStripMenuItem.Name = "updateTutorDetailsToolStripMenuItem";
            updateTutorDetailsToolStripMenuItem.Size = new Size(277, 34);
            updateTutorDetailsToolStripMenuItem.Text = "Update Tutor Details";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, removeStudentToolStripMenuItem, displayStudentDetailsToolStripMenuItem, updateStudentDetailsToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(97, 29);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(296, 34);
            addStudentToolStripMenuItem.Text = "Add Student";
            // 
            // removeStudentToolStripMenuItem
            // 
            removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            removeStudentToolStripMenuItem.Size = new Size(296, 34);
            removeStudentToolStripMenuItem.Text = "Remove Student";
            // 
            // displayStudentDetailsToolStripMenuItem
            // 
            displayStudentDetailsToolStripMenuItem.Name = "displayStudentDetailsToolStripMenuItem";
            displayStudentDetailsToolStripMenuItem.Size = new Size(296, 34);
            displayStudentDetailsToolStripMenuItem.Text = "Display Student Details";
            // 
            // updateStudentDetailsToolStripMenuItem
            // 
            updateStudentDetailsToolStripMenuItem.Name = "updateStudentDetailsToolStripMenuItem";
            updateStudentDetailsToolStripMenuItem.Size = new Size(296, 34);
            updateStudentDetailsToolStripMenuItem.Text = "Update Student Details";
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addClassToScheduleToolStripMenuItem, removeClassFromScheduleToolStripMenuItem, displayRoomScheduleToolStripMenuItem, updateClassDetailsToolStripMenuItem });
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(99, 29);
            scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // addClassToScheduleToolStripMenuItem
            // 
            addClassToScheduleToolStripMenuItem.Name = "addClassToScheduleToolStripMenuItem";
            addClassToScheduleToolStripMenuItem.Size = new Size(343, 34);
            addClassToScheduleToolStripMenuItem.Text = "Add Class to Schedule";
            // 
            // removeClassFromScheduleToolStripMenuItem
            // 
            removeClassFromScheduleToolStripMenuItem.Name = "removeClassFromScheduleToolStripMenuItem";
            removeClassFromScheduleToolStripMenuItem.Size = new Size(343, 34);
            removeClassFromScheduleToolStripMenuItem.Text = "Remove Class from Schedule";
            // 
            // displayRoomScheduleToolStripMenuItem
            // 
            displayRoomScheduleToolStripMenuItem.Name = "displayRoomScheduleToolStripMenuItem";
            displayRoomScheduleToolStripMenuItem.Size = new Size(343, 34);
            displayRoomScheduleToolStripMenuItem.Text = "Display Room Schedule";
            // 
            // updateClassDetailsToolStripMenuItem
            // 
            updateClassDetailsToolStripMenuItem.Name = "updateClassDetailsToolStripMenuItem";
            updateClassDetailsToolStripMenuItem.Size = new Size(343, 34);
            updateClassDetailsToolStripMenuItem.Text = "Update Class Details";
            // 
            // bookinToolStripMenuItem
            // 
            bookinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { makeBookingToolStripMenuItem, manageBookingToolStripMenuItem });
            bookinToolStripMenuItem.Name = "bookinToolStripMenuItem";
            bookinToolStripMenuItem.Size = new Size(102, 29);
            bookinToolStripMenuItem.Text = "Bookings";
            // 
            // makeBookingToolStripMenuItem
            // 
            makeBookingToolStripMenuItem.Name = "makeBookingToolStripMenuItem";
            makeBookingToolStripMenuItem.Size = new Size(249, 34);
            makeBookingToolStripMenuItem.Text = "Make Booking";
            // 
            // manageBookingToolStripMenuItem
            // 
            manageBookingToolStripMenuItem.Name = "manageBookingToolStripMenuItem";
            manageBookingToolStripMenuItem.Size = new Size(249, 34);
            manageBookingToolStripMenuItem.Text = "Manage Booking";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(959, 524);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 572);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainPage";
            Text = "GrindBookingSystem";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tutorsToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem addtutor_btn;
        private ToolStripMenuItem removeTutorToolStripMenuItem;
        private ToolStripMenuItem displayTutorDetailsToolStripMenuItem;
        private ToolStripMenuItem updateTutorDetailsToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem removeStudentToolStripMenuItem;
        private ToolStripMenuItem displayStudentDetailsToolStripMenuItem;
        private ToolStripMenuItem updateStudentDetailsToolStripMenuItem;
        private ToolStripMenuItem addClassToScheduleToolStripMenuItem;
        private ToolStripMenuItem removeClassFromScheduleToolStripMenuItem;
        private ToolStripMenuItem displayRoomScheduleToolStripMenuItem;
        private ToolStripMenuItem updateClassDetailsToolStripMenuItem;
        private ToolStripMenuItem bookinToolStripMenuItem;
        private ToolStripMenuItem makeBookingToolStripMenuItem;
        private ToolStripMenuItem manageBookingToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
