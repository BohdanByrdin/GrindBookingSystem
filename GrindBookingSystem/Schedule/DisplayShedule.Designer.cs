namespace GrindBookingSystem.Schedule
{
    partial class DisplayShedule
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
            button1 = new Button();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            rbInactive = new RadioButton();
            rbActive = new RadioButton();
            groupBox2 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(1183, 635);
            button1.Name = "button1";
            button1.Size = new Size(231, 72);
            button1.TabIndex = 4;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(1098, 503);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(396, 88);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Order By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(49, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 36);
            comboBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbInactive);
            groupBox3.Controls.Add(rbActive);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1098, 330);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(396, 167);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Active or Inactive";
            // 
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.Location = new Point(146, 71);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(105, 29);
            rbInactive.TabIndex = 3;
            rbInactive.TabStop = true;
            rbInactive.Text = "Inactive";
            rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Location = new Point(38, 71);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(91, 29);
            rbActive.TabIndex = 3;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(monthCalendar1);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1098, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 310);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Month";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(49, 33);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 714);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Schedule";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1045, 660);
            dataGridView1.TabIndex = 0;
            // 
            // DisplayShedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 743);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DisplayShedule";
            Text = "DisplayShedule";
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private RadioButton rbInactive;
        private RadioButton rbActive;
        private GroupBox groupBox2;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}