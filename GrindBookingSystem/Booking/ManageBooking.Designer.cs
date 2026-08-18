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
            button4 = new Button();
            Update = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            calendar = new MonthCalendar();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            cancelbtn = new Button();
            gbDetails.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(button4);
            gbDetails.Controls.Add(cancelbtn);
            gbDetails.Controls.Add(Update);
            gbDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDetails.Location = new Point(1287, 12);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(458, 1017);
            gbDetails.TabIndex = 12;
            gbDetails.TabStop = false;
            gbDetails.Text = "Change Details";
            gbDetails.Visible = false;
            // 
            // button4
            // 
            button4.ForeColor = Color.OrangeRed;
            button4.Location = new Point(263, 852);
            button4.Name = "button4";
            button4.Size = new Size(156, 66);
            button4.TabIndex = 7;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            Update.Enabled = false;
            Update.ForeColor = Color.LimeGreen;
            Update.Location = new Point(49, 852);
            Update.Name = "Update";
            Update.Size = new Size(154, 66);
            Update.TabIndex = 6;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
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
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(calendar);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1300, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 325);
            groupBox2.TabIndex = 11;
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
            // panel1
            // 
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
            // 
            // cancelbtn
            // 
            cancelbtn.Enabled = false;
            cancelbtn.ForeColor = Color.FromArgb(255, 128, 128);
            cancelbtn.Location = new Point(151, 931);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(154, 66);
            cancelbtn.TabIndex = 6;
            cancelbtn.Text = "Cancel Booking";
            cancelbtn.UseVisualStyleBackColor = true;
            // 
            // ManageBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1770, 1054);
            Controls.Add(gbDetails);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "ManageBooking";
            Text = "ManageBooking";
            Load += ManageBooking_Load;
            gbDetails.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDetails;
        private Button button4;
        private Button Update;
        private Button button1;
        private GroupBox groupBox2;
        private MonthCalendar calendar;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button cancelbtn;
    }
}