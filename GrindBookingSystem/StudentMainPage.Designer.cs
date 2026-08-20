namespace GrindBookingSystem
{
    partial class StudentMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainPage));
            menuStrip1 = new MenuStrip();
            checkMyProfileToolStripMenuItem = new ToolStripMenuItem();
            bookForClassToolStripMenuItem = new ToolStripMenuItem();
            checkMyProfileToolStripMenuItem1 = new ToolStripMenuItem();
            bookForClassToolStripMenuItem1 = new ToolStripMenuItem();
            checkMyBookingsToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { checkMyProfileToolStripMenuItem, bookForClassToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(755, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // checkMyProfileToolStripMenuItem
            // 
            checkMyProfileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkMyProfileToolStripMenuItem1 });
            checkMyProfileToolStripMenuItem.Name = "checkMyProfileToolStripMenuItem";
            checkMyProfileToolStripMenuItem.Size = new Size(78, 29);
            checkMyProfileToolStripMenuItem.Text = "Profile";
            checkMyProfileToolStripMenuItem.Click += checkMyProfileToolStripMenuItem_Click;
            // 
            // bookForClassToolStripMenuItem
            // 
            bookForClassToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookForClassToolStripMenuItem1, checkMyBookingsToolStripMenuItem });
            bookForClassToolStripMenuItem.Name = "bookForClassToolStripMenuItem";
            bookForClassToolStripMenuItem.Size = new Size(94, 29);
            bookForClassToolStripMenuItem.Text = "Booking";
            // 
            // checkMyProfileToolStripMenuItem1
            // 
            checkMyProfileToolStripMenuItem1.Name = "checkMyProfileToolStripMenuItem1";
            checkMyProfileToolStripMenuItem1.Size = new Size(270, 34);
            checkMyProfileToolStripMenuItem1.Text = "Check My Profile";
            checkMyProfileToolStripMenuItem1.Click += checkMyProfileToolStripMenuItem1_Click;
            // 
            // bookForClassToolStripMenuItem1
            // 
            bookForClassToolStripMenuItem1.Name = "bookForClassToolStripMenuItem1";
            bookForClassToolStripMenuItem1.Size = new Size(270, 34);
            bookForClassToolStripMenuItem1.Text = "Book for Class";
            // 
            // checkMyBookingsToolStripMenuItem
            // 
            checkMyBookingsToolStripMenuItem.Name = "checkMyBookingsToolStripMenuItem";
            checkMyBookingsToolStripMenuItem.Size = new Size(270, 34);
            checkMyBookingsToolStripMenuItem.Text = "Check My Bookings";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(728, 410);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // StudentMainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 462);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "StudentMainPage";
            Text = "StudentMainPage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem checkMyProfileToolStripMenuItem;
        private ToolStripMenuItem bookForClassToolStripMenuItem;
        private ToolStripMenuItem checkMyProfileToolStripMenuItem1;
        private ToolStripMenuItem bookForClassToolStripMenuItem1;
        private ToolStripMenuItem checkMyBookingsToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}