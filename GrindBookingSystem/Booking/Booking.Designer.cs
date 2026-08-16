namespace GrindBookingSystem.Booking
{
    partial class Booking
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
            gbStudent = new GroupBox();
            studentData = new DataGridView();
            searchStudent = new TextBox();
            gbClass = new GroupBox();
            btnClose = new Button();
            btnBook = new Button();
            dataGridView2 = new DataGridView();
            calendar = new MonthCalendar();
            gbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentData).BeginInit();
            gbClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // gbStudent
            // 
            gbStudent.Controls.Add(studentData);
            gbStudent.Controls.Add(searchStudent);
            gbStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbStudent.Location = new Point(12, 12);
            gbStudent.Name = "gbStudent";
            gbStudent.Size = new Size(1372, 391);
            gbStudent.TabIndex = 0;
            gbStudent.TabStop = false;
            gbStudent.Text = "Choose Student";
            // 
            // studentData
            // 
            studentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentData.Location = new Point(37, 104);
            studentData.Name = "studentData";
            studentData.RowHeadersWidth = 62;
            studentData.Size = new Size(1294, 225);
            studentData.TabIndex = 2;
            studentData.CellDoubleClick += studentData_CellDoubleClick;
            // 
            // searchStudent
            // 
            searchStudent.Location = new Point(37, 51);
            searchStudent.Name = "searchStudent";
            searchStudent.Size = new Size(538, 34);
            searchStudent.TabIndex = 1;
            searchStudent.TextChanged += searchStudent_TextChanged;
            // 
            // gbClass
            // 
            gbClass.Controls.Add(btnClose);
            gbClass.Controls.Add(btnBook);
            gbClass.Controls.Add(dataGridView2);
            gbClass.Controls.Add(calendar);
            gbClass.Enabled = false;
            gbClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbClass.Location = new Point(12, 419);
            gbClass.Name = "gbClass";
            gbClass.Size = new Size(1372, 448);
            gbClass.TabIndex = 1;
            gbClass.TabStop = false;
            gbClass.Text = "Choose Class";
            // 
            // btnClose
            // 
            btnClose.ForeColor = Color.OrangeRed;
            btnClose.Location = new Point(1199, 341);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 62);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnBook
            // 
            btnBook.ForeColor = Color.Green;
            btnBook.Location = new Point(1048, 341);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(145, 62);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book Lesson";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(15, 50);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1021, 368);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // calendar
            // 
            calendar.Location = new Point(1048, 39);
            calendar.Name = "calendar";
            calendar.TabIndex = 0;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 891);
            Controls.Add(gbClass);
            Controls.Add(gbStudent);
            Name = "Booking";
            Text = "Booking";
            Load += Booking_Load;
            gbStudent.ResumeLayout(false);
            gbStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentData).EndInit();
            gbClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbStudent;
        private DataGridView studentData;
        private TextBox searchStudent;
        private GroupBox gbClass;
        private Button btnClose;
        private Button btnBook;
        private DataGridView dataGridView2;
        private MonthCalendar calendar;
    }
}