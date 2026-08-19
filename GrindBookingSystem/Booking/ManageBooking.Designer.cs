namespace GrindBookingSystem.Booking
{
    partial class ManageBooking
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
            gbDetails = new GroupBox();
            bookingID = new Label();
            status = new Label();
            bookingDate = new Label();
            className = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            studentName = new Label();
            label3 = new Label();
            label1 = new Label();
            button4 = new Button();
            cancelbtn = new Button();
            button1 = new Button();
            gbMonth = new GroupBox();
            calendar = new MonthCalendar();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            gbDetails.SuspendLayout();
            gbMonth.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            gbDetails.Controls.Add(studentName);
            gbDetails.Controls.Add(label3);
            gbDetails.Controls.Add(label1);
            gbDetails.Controls.Add(button4);
            gbDetails.Controls.Add(cancelbtn);
            gbDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDetails.Location = new Point(621, 210);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(541, 579);
            gbDetails.TabIndex = 12;
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
            status.Location = new Point(132, 300);
            status.Name = "status";
            status.Size = new Size(70, 28);
            status.TabIndex = 8;
            status.Text = "label1";
            // 
            // bookingDate
            // 
            bookingDate.AutoSize = true;
            bookingDate.Location = new Point(201, 243);
            bookingDate.Name = "bookingDate";
            bookingDate.Size = new Size(70, 28);
            bookingDate.TabIndex = 8;
            bookingDate.Text = "label1";
            // 
            // className
            // 
            className.AutoSize = true;
            className.Location = new Point(190, 197);
            className.Name = "className";
            className.Size = new Size(70, 28);
            className.TabIndex = 8;
            className.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 300);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 8;
            label4.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 243);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 8;
            label2.Text = "Booking Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 197);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 8;
            label5.Text = "Class Name:";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Location = new Point(213, 145);
            studentName.Name = "studentName";
            studentName.Size = new Size(70, 28);
            studentName.TabIndex = 8;
            studentName.Text = "label1";
            studentName.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 145);
            label3.Name = "label3";
            label3.Size = new Size(153, 28);
            label3.TabIndex = 8;
            label3.Text = "Student Name:";
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
            button4.Location = new Point(297, 451);
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
            cancelbtn.Location = new Point(78, 451);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(154, 66);
            cancelbtn.TabIndex = 6;
            cancelbtn.Text = "Cancel Booking";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(1419, 755);
            button1.Name = "button1";
            button1.Size = new Size(186, 115);
            button1.TabIndex = 10;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gbMonth
            // 
            gbMonth.Controls.Add(calendar);
            gbMonth.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbMonth.Location = new Point(1300, 12);
            gbMonth.Name = "gbMonth";
            gbMonth.Size = new Size(390, 325);
            gbMonth.TabIndex = 11;
            gbMonth.TabStop = false;
            gbMonth.Text = "Month";
            // 
            // calendar
            // 
            calendar.Location = new Point(49, 39);
            calendar.Name = "calendar";
            calendar.TabIndex = 0;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(gbDetails);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1255, 1017);
            panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1220, 960);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // ManageBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1770, 1054);
            Controls.Add(button1);
            Controls.Add(gbMonth);
            Controls.Add(panel1);
            Name = "ManageBooking";
            Text = "ManageBooking";
            Load += ManageBooking_Load;
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            gbMonth.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDetails;
        private Button button4;
        private Button button1;
        private GroupBox gbMonth;
        private MonthCalendar calendar;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button cancelbtn;
        private Label bookingID;
        private Label className;
        private Label label5;
        private Label studentName;
        private Label label3;
        private Label label1;
        private Label status;
        private Label bookingDate;
        private Label label4;
        private Label label2;
    }
}