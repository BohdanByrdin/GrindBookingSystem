namespace GrindBookingSystem.Schedule
{
    partial class UpdateClassDetails
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
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            calendar = new MonthCalendar();
            button1 = new Button();
            gbDetails = new GroupBox();
            button4 = new Button();
            Update = new Button();
            groupBox3 = new GroupBox();
            cbTutors = new ComboBox();
            groupBox4 = new GroupBox();
            cbRooms = new ComboBox();
            groupBox5 = new GroupBox();
            cbSubjects = new ComboBox();
            groupBox6 = new GroupBox();
            saveTimeAndDate = new Button();
            label2 = new Label();
            label1 = new Label();
            endTime = new DateTimePicker();
            startTime = new DateTimePicker();
            date = new MonthCalendar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            gbDetails.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1255, 1017);
            panel1.TabIndex = 0;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(calendar);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1300, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 325);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Month";
            // 
            // calendar
            // 
            calendar.Location = new Point(49, 39);
            calendar.Name = "calendar";
            calendar.TabIndex = 0;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(1419, 755);
            button1.Name = "button1";
            button1.Size = new Size(186, 115);
            button1.TabIndex = 2;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(button4);
            gbDetails.Controls.Add(Update);
            gbDetails.Controls.Add(groupBox3);
            gbDetails.Controls.Add(groupBox4);
            gbDetails.Controls.Add(groupBox5);
            gbDetails.Controls.Add(groupBox6);
            gbDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDetails.Location = new Point(1294, 12);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(390, 1017);
            gbDetails.TabIndex = 8;
            gbDetails.TabStop = false;
            gbDetails.Text = "Change Details";
            gbDetails.Visible = false;
            // 
            // button4
            // 
            button4.ForeColor = Color.OrangeRed;
            button4.Location = new Point(205, 931);
            button4.Name = "button4";
            button4.Size = new Size(156, 66);
            button4.TabIndex = 7;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            Update.ForeColor = Color.LimeGreen;
            Update.Location = new Point(22, 931);
            Update.Name = "Update";
            Update.Size = new Size(154, 66);
            Update.TabIndex = 6;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbTutors);
            groupBox3.Location = new Point(22, 807);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 99);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Choose Tutor";
            // 
            // cbTutors
            // 
            cbTutors.FormattingEnabled = true;
            cbTutors.Location = new Point(27, 46);
            cbTutors.Name = "cbTutors";
            cbTutors.Size = new Size(268, 36);
            cbTutors.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbRooms);
            groupBox4.Location = new Point(22, 695);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(334, 106);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Choose Room";
            // 
            // cbRooms
            // 
            cbRooms.FormattingEnabled = true;
            cbRooms.Location = new Point(27, 51);
            cbRooms.Name = "cbRooms";
            cbRooms.Size = new Size(268, 36);
            cbRooms.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbSubjects);
            groupBox5.Location = new Point(22, 602);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(339, 87);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Choose Subject";
            // 
            // cbSubjects
            // 
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(27, 33);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(268, 36);
            cbSubjects.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(saveTimeAndDate);
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(endTime);
            groupBox6.Controls.Add(startTime);
            groupBox6.Controls.Add(date);
            groupBox6.Location = new Point(20, 39);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(350, 553);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Choose date and time";
            // 
            // saveTimeAndDate
            // 
            saveTimeAndDate.Location = new Point(75, 496);
            saveTimeAndDate.Name = "saveTimeAndDate";
            saveTimeAndDate.Size = new Size(128, 41);
            saveTimeAndDate.TabIndex = 4;
            saveTimeAndDate.Text = "Save";
            saveTimeAndDate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 393);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 3;
            label2.Text = "End Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 302);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 2;
            label1.Text = "Start time:";
            // 
            // endTime
            // 
            endTime.Format = DateTimePickerFormat.Time;
            endTime.Location = new Point(43, 431);
            endTime.Name = "endTime";
            endTime.Size = new Size(213, 34);
            endTime.TabIndex = 1;
            // 
            // startTime
            // 
            startTime.Format = DateTimePickerFormat.Time;
            startTime.Location = new Point(43, 341);
            startTime.Name = "startTime";
            startTime.Size = new Size(213, 34);
            startTime.TabIndex = 1;
            // 
            // date
            // 
            date.Location = new Point(24, 40);
            date.Name = "date";
            date.TabIndex = 0;
            // 
            // UpdateClassDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 1058);
            Controls.Add(gbDetails);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "UpdateClassDetails";
            Text = "UpdateClassDetails";
            Load += UpdateClassDetails_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            gbDetails.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private MonthCalendar calendar;
        private Button button1;
        private GroupBox gbDetails;
        private GroupBox groupBox6;
        private Button saveTimeAndDate;
        private Label label2;
        private Label label1;
        private DateTimePicker endTime;
        private DateTimePicker startTime;
        private MonthCalendar date;
        private GroupBox groupBox4;
        private ComboBox cbRooms;
        private GroupBox groupBox5;
        private ComboBox cbSubjects;
        private Button button4;
        private Button Update;
        private GroupBox groupBox3;
        private ComboBox cbTutors;
    }
}