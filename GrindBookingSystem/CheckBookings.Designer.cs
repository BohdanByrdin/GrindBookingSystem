namespace GrindBookingSystem
{
    partial class CheckBookings
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
            panel1 = new Panel();
            gbDetails = new GroupBox();
            bookingID = new Label();
            status = new Label();
            bookingDate = new Label();
            className = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            button4 = new Button();
            cancelbtn = new Button();
            dataGridView1 = new DataGridView();
            calendar = new MonthCalendar();
            Closebtn = new Button();
            panel1.SuspendLayout();
            gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(11, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 540);
            panel1.TabIndex = 0;
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(bookingID);
            gbDetails.Controls.Add(status);
            gbDetails.Controls.Add(bookingDate);
            gbDetails.Controls.Add(className);
            gbDetails.Controls.Add(label4);
            gbDetails.Controls.Add(label2);
            gbDetails.Controls.Add(label5);
            gbDetails.Controls.Add(label1);
            gbDetails.Controls.Add(button4);
            gbDetails.Controls.Add(cancelbtn);
            gbDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDetails.Location = new Point(784, 18);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(466, 550);
            gbDetails.TabIndex = 13;
            gbDetails.TabStop = false;
            gbDetails.Text = "Change Details";
            gbDetails.Visible = false;
            // 
            // bookingID
            // 
            bookingID.AutoSize = true;
            bookingID.Location = new Point(178, 100);
            bookingID.Name = "bookingID";
            bookingID.Size = new Size(70, 28);
            bookingID.TabIndex = 8;
            bookingID.Text = "label1";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(135, 241);
            status.Name = "status";
            status.Size = new Size(70, 28);
            status.TabIndex = 8;
            status.Text = "label1";
            // 
            // bookingDate
            // 
            bookingDate.AutoSize = true;
            bookingDate.Location = new Point(201, 192);
            bookingDate.Name = "bookingDate";
            bookingDate.Size = new Size(70, 28);
            bookingDate.TabIndex = 8;
            bookingDate.Text = "label1";
            // 
            // className
            // 
            className.AutoSize = true;
            className.Location = new Point(181, 147);
            className.Name = "className";
            className.Size = new Size(70, 28);
            className.TabIndex = 8;
            className.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 241);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 8;
            label4.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 192);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 8;
            label2.Text = "Booking Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 147);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 8;
            label5.Text = "Class Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 100);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 8;
            label1.Text = "BookingID:";
            // 
            // button4
            // 
            button4.ForeColor = Color.OrangeRed;
            button4.Location = new Point(255, 445);
            button4.Name = "button4";
            button4.Size = new Size(156, 66);
            button4.TabIndex = 7;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.ForeColor = Color.FromArgb(255, 128, 128);
            cancelbtn.Location = new Point(59, 445);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(154, 66);
            cancelbtn.TabIndex = 6;
            cancelbtn.Text = "Cancel Booking";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(734, 505);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // calendar
            // 
            calendar.Location = new Point(838, 18);
            calendar.Name = "calendar";
            calendar.TabIndex = 1;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // Closebtn
            // 
            Closebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Closebtn.ForeColor = Color.Red;
            Closebtn.Location = new Point(920, 466);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(149, 86);
            Closebtn.TabIndex = 2;
            Closebtn.Text = "Close";
            Closebtn.UseVisualStyleBackColor = true;
            Closebtn.Click += Closebtn_Click;
            // 
            // CheckBookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 580);
            Controls.Add(gbDetails);
            Controls.Add(Closebtn);
            Controls.Add(calendar);
            Controls.Add(panel1);
            Name = "CheckBookings";
            Text = "CheckBookings";
            Load += CheckBookings_Load;
            panel1.ResumeLayout(false);
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private MonthCalendar calendar;
        private Button Closebtn;
        private GroupBox gbDetails;
        private Label bookingID;
        private Label status;
        private Label bookingDate;
        private Label className;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label1;
        private Button button4;
        private Button cancelbtn;
    }
}