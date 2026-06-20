namespace GrindBookingSystem
{
    partial class UpdateTutor
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
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            gbDetails = new GroupBox();
            btnCloseUpdate = new Button();
            cbSubjects = new ComboBox();
            label6 = new Label();
            btnUpdate = new Button();
            phonetxt = new TextBox();
            emailtxt = new TextBox();
            lnametxt = new TextBox();
            fnametxt = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            tutorIDtxt = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbDetails.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1160, 522);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tutors";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(959, 456);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(168, 60);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1040, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(tutorIDtxt);
            gbDetails.Controls.Add(label4);
            gbDetails.Controls.Add(btnCloseUpdate);
            gbDetails.Controls.Add(cbSubjects);
            gbDetails.Controls.Add(label6);
            gbDetails.Controls.Add(btnUpdate);
            gbDetails.Controls.Add(phonetxt);
            gbDetails.Controls.Add(emailtxt);
            gbDetails.Controls.Add(lnametxt);
            gbDetails.Controls.Add(fnametxt);
            gbDetails.Controls.Add(label3);
            gbDetails.Controls.Add(label5);
            gbDetails.Controls.Add(label2);
            gbDetails.Controls.Add(label1);
            gbDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDetails.Location = new Point(1192, 25);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(416, 509);
            gbDetails.TabIndex = 1;
            gbDetails.TabStop = false;
            gbDetails.Text = "TutorDetails";
            gbDetails.Visible = false;
            // 
            // btnCloseUpdate
            // 
            btnCloseUpdate.Location = new Point(230, 398);
            btnCloseUpdate.Name = "btnCloseUpdate";
            btnCloseUpdate.Size = new Size(157, 72);
            btnCloseUpdate.TabIndex = 14;
            btnCloseUpdate.Text = "Close";
            btnCloseUpdate.UseVisualStyleBackColor = true;
            btnCloseUpdate.Click += btnCloseUpdate_Click;
            // 
            // cbSubjects
            // 
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(143, 275);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(173, 40);
            cbSubjects.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 275);
            label6.Name = "label6";
            label6.Size = new Size(105, 32);
            label6.TabIndex = 12;
            label6.Text = "Subject:";
            label6.Click += label6_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(32, 398);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(170, 72);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // phonetxt
            // 
            phonetxt.Location = new Point(122, 215);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(219, 39);
            phonetxt.TabIndex = 8;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(113, 168);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(274, 39);
            emailtxt.TabIndex = 9;
            // 
            // lnametxt
            // 
            lnametxt.Location = new Point(169, 125);
            lnametxt.Name = "lnametxt";
            lnametxt.Size = new Size(198, 39);
            lnametxt.TabIndex = 10;
            // 
            // fnametxt
            // 
            fnametxt.Location = new Point(169, 76);
            fnametxt.Name = "fnametxt";
            fnametxt.Size = new Size(198, 39);
            fnametxt.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 125);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 215);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 3;
            label5.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 167);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 76);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 6;
            label1.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 44);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 15;
            label4.Text = "TutorID:";
            // 
            // tutorIDtxt
            // 
            tutorIDtxt.AutoSize = true;
            tutorIDtxt.Location = new Point(139, 44);
            tutorIDtxt.Name = "tutorIDtxt";
            tutorIDtxt.Size = new Size(83, 32);
            tutorIDtxt.TabIndex = 15;
            tutorIDtxt.Text = "label4";
            // 
            // UpdateTutor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 546);
            Controls.Add(gbDetails);
            Controls.Add(groupBox1);
            Name = "UpdateTutor";
            Text = "UpdateTutor";
            Load += UpdateTutor_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox gbDetails;
        private Button btnClose;
        private Button btnUpdate;
        private TextBox phonetxt;
        private TextBox emailtxt;
        private TextBox lnametxt;
        private TextBox fnametxt;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private ComboBox cbSubjects;
        private Label label6;
        private Button btnCloseUpdate;
        private Label tutorIDtxt;
        private Label label4;
    }
}