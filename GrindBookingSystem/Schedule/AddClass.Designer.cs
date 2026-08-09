namespace GrindBookingSystem.Schedule
{
    partial class AddClass
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
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            endTime = new DateTimePicker();
            startTime = new DateTimePicker();
            date = new MonthCalendar();
            groupBox5 = new GroupBox();
            cbSubjects = new ComboBox();
            button2 = new Button();
            saveTheClass = new Button();
            dataGridView1 = new DataGridView();
            tutorCell = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            dateCell = new DataGridViewTextBoxColumn();
            startTimeCell = new DataGridViewTextBoxColumn();
            endTimeCell = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            cbRooms = new ComboBox();
            groupBox2 = new GroupBox();
            cbTutors = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(saveTheClass);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1731, 817);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "AddClass";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button3);
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(endTime);
            groupBox6.Controls.Add(startTime);
            groupBox6.Controls.Add(date);
            groupBox6.Location = new Point(1092, 193);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(620, 354);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Choose date and time";
            // 
            // button3
            // 
            button3.Location = new Point(401, 265);
            button3.Name = "button3";
            button3.Size = new Size(128, 41);
            button3.TabIndex = 4;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 162);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "End Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 71);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 2;
            label1.Text = "Start time:";
            // 
            // endTime
            // 
            endTime.Format = DateTimePickerFormat.Time;
            endTime.Location = new Point(369, 200);
            endTime.Name = "endTime";
            endTime.Size = new Size(213, 31);
            endTime.TabIndex = 1;
            // 
            // startTime
            // 
            startTime.Format = DateTimePickerFormat.Time;
            startTime.Location = new Point(369, 110);
            startTime.Name = "startTime";
            startTime.Size = new Size(213, 31);
            startTime.TabIndex = 1;
            // 
            // date
            // 
            date.Location = new Point(24, 40);
            date.Name = "date";
            date.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbSubjects);
            groupBox5.Location = new Point(657, 30);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(580, 135);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Choose Subject";
            // 
            // cbSubjects
            // 
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(101, 56);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(416, 33);
            cbSubjects.TabIndex = 0;
            cbSubjects.SelectedIndexChanged += cbSubjects_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(1416, 633);
            button2.Name = "button2";
            button2.Size = new Size(205, 87);
            button2.TabIndex = 1;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // saveTheClass
            // 
            saveTheClass.Enabled = false;
            saveTheClass.Location = new Point(1131, 633);
            saveTheClass.Name = "saveTheClass";
            saveTheClass.Size = new Size(205, 87);
            saveTheClass.TabIndex = 1;
            saveTheClass.Text = "Save";
            saveTheClass.UseVisualStyleBackColor = true;
            saveTheClass.Click += saveTheClass_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tutorCell, SubjectName, RoomNumber, dateCell, startTimeCell, endTimeCell });
            dataGridView1.Location = new Point(24, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1025, 588);
            dataGridView1.TabIndex = 0;
            // 
            // tutorCell
            // 
            tutorCell.HeaderText = "Tutor";
            tutorCell.MinimumWidth = 8;
            tutorCell.Name = "tutorCell";
            tutorCell.Width = 150;
            // 
            // SubjectName
            // 
            SubjectName.HeaderText = "Subject";
            SubjectName.MinimumWidth = 8;
            SubjectName.Name = "SubjectName";
            SubjectName.Width = 150;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "RoomNo";
            RoomNumber.MinimumWidth = 8;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Width = 150;
            // 
            // dateCell
            // 
            dateCell.HeaderText = "Date";
            dateCell.MinimumWidth = 8;
            dateCell.Name = "dateCell";
            dateCell.Width = 150;
            // 
            // startTimeCell
            // 
            startTimeCell.HeaderText = "StartTime";
            startTimeCell.MinimumWidth = 8;
            startTimeCell.Name = "startTimeCell";
            startTimeCell.Width = 150;
            // 
            // endTimeCell
            // 
            endTimeCell.HeaderText = "End Time";
            endTimeCell.MinimumWidth = 8;
            endTimeCell.Name = "endTimeCell";
            endTimeCell.Width = 150;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbRooms);
            groupBox4.Location = new Point(1257, 30);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(455, 135);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Choose Room";
            // 
            // cbRooms
            // 
            cbRooms.FormattingEnabled = true;
            cbRooms.Location = new Point(58, 51);
            cbRooms.Name = "cbRooms";
            cbRooms.Size = new Size(338, 33);
            cbRooms.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbTutors);
            groupBox2.Location = new Point(24, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(598, 135);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose Tutor";
            // 
            // cbTutors
            // 
            cbTutors.FormattingEnabled = true;
            cbTutors.Location = new Point(113, 46);
            cbTutors.Name = "cbTutors";
            cbTutors.Size = new Size(416, 33);
            cbTutors.TabIndex = 0;
            // 
            // AddClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1755, 845);
            Controls.Add(groupBox1);
            Name = "AddClass";
            Text = "AddClass";
            Load += AddClass_Load;
            groupBox1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox5;
        private Button button2;
        private Button saveTheClass;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private GroupBox groupBox6;
        private ComboBox cbSubjects;
        private ComboBox cbRooms;
        private ComboBox cbTutors;
        private Label label2;
        private Label label1;
        private DateTimePicker endTime;
        private DateTimePicker startTime;
        private Button button3;
        private MonthCalendar date;
        private DataGridViewTextBoxColumn tutorCell;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn dateCell;
        private DataGridViewTextBoxColumn startTimeCell;
        private DataGridViewTextBoxColumn endTimeCell;
    }
}