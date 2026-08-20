namespace GrindBookingSystem
{
    partial class MakeBooking
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
            gbClass = new GroupBox();
            btnClose = new Button();
            btnBook = new Button();
            dataGridView2 = new DataGridView();
            calendar = new MonthCalendar();
            label1 = new Label();
            gbClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // gbClass
            // 
            gbClass.Controls.Add(label1);
            gbClass.Controls.Add(btnClose);
            gbClass.Controls.Add(btnBook);
            gbClass.Controls.Add(dataGridView2);
            gbClass.Controls.Add(calendar);
            gbClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbClass.Location = new Point(12, 12);
            gbClass.Name = "gbClass";
            gbClass.Size = new Size(1372, 448);
            gbClass.TabIndex = 2;
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
            dataGridView2.Location = new Point(15, 74);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 39);
            label1.Name = "label1";
            label1.Size = new Size(376, 28);
            label1.TabIndex = 3;
            label1.Text = "Double Click on the class to choose it*";
            // 
            // MakeBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 481);
            Controls.Add(gbClass);
            Name = "MakeBooking";
            Text = "MakeBooking";
            Load += MakeBooking_Load;
            gbClass.ResumeLayout(false);
            gbClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbClass;
        private Button btnClose;
        private Button btnBook;
        private DataGridView dataGridView2;
        private MonthCalendar calendar;
        private Label label1;
    }
}