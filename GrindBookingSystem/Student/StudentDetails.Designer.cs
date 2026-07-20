namespace GrindBookingSystem
{
    partial class StudentDetails
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
            closebtn = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            dobtxt = new Label();
            label4 = new Label();
            button1 = new Button();
            phonetxt = new TextBox();
            emailtxt = new TextBox();
            lnametxt = new TextBox();
            fnametxt = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(closebtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1269, 606);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "All Students";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // closebtn
            // 
            closebtn.Location = new Point(1034, 520);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(173, 70);
            closebtn.TabIndex = 2;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 72);
            label1.Name = "label1";
            label1.Size = new Size(543, 38);
            label1.TabIndex = 1;
            label1.Text = "Double Click on any cell to check details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1121, 374);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dobtxt);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(phonetxt);
            groupBox2.Controls.Add(emailtxt);
            groupBox2.Controls.Add(lnametxt);
            groupBox2.Controls.Add(fnametxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1316, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 584);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proper Details";
            groupBox2.Visible = false;
            // 
            // dobtxt
            // 
            dobtxt.AutoSize = true;
            dobtxt.Location = new Point(189, 269);
            dobtxt.Name = "dobtxt";
            dobtxt.Size = new Size(76, 30);
            dobtxt.TabIndex = 3;
            dobtxt.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 269);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 2;
            label4.Text = "Date of Birth:";
            // 
            // button1
            // 
            button1.Location = new Point(269, 491);
            button1.Name = "button1";
            button1.Size = new Size(153, 77);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // phonetxt
            // 
            phonetxt.Location = new Point(120, 211);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(219, 37);
            phonetxt.TabIndex = 1;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(111, 164);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(274, 37);
            emailtxt.TabIndex = 1;
            // 
            // lnametxt
            // 
            lnametxt.Location = new Point(167, 121);
            lnametxt.Name = "lnametxt";
            lnametxt.Size = new Size(198, 37);
            lnametxt.TabIndex = 1;
            // 
            // fnametxt
            // 
            fnametxt.Location = new Point(167, 72);
            fnametxt.Name = "fnametxt";
            fnametxt.Size = new Size(198, 37);
            fnametxt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 121);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 0;
            label3.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 211);
            label5.Name = "label5";
            label5.Size = new Size(84, 30);
            label5.TabIndex = 0;
            label5.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 163);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 0;
            label2.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 72);
            label6.Name = "label6";
            label6.Size = new Size(131, 30);
            label6.TabIndex = 0;
            label6.Text = "First Name:";
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1797, 625);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "StudentDetails";
            Text = "StudentDetails";
            Load += StudentDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button closebtn;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Label dobtxt;
        private Label label4;
        private Button button1;
        private TextBox phonetxt;
        private TextBox emailtxt;
        private TextBox lnametxt;
        private TextBox fnametxt;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label6;
    }
}