namespace GrindBookingSystem
{
    partial class DeleteTutor
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
            tutorIDtxt = new Label();
            label4 = new Label();
            btnCloseUpdate = new Button();
            label6 = new Label();
            btnDelete = new Button();
            Subject = new TextBox();
            phonetxt = new TextBox();
            emailtxt = new TextBox();
            lnametxt = new TextBox();
            fnametxt = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            gbDetails.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(tutorIDtxt);
            gbDetails.Controls.Add(label4);
            gbDetails.Controls.Add(btnCloseUpdate);
            gbDetails.Controls.Add(label6);
            gbDetails.Controls.Add(btnDelete);
            gbDetails.Controls.Add(Subject);
            gbDetails.Controls.Add(phonetxt);
            gbDetails.Controls.Add(emailtxt);
            gbDetails.Controls.Add(lnametxt);
            gbDetails.Controls.Add(fnametxt);
            gbDetails.Controls.Add(label3);
            gbDetails.Controls.Add(label5);
            gbDetails.Controls.Add(label2);
            gbDetails.Controls.Add(label1);
            gbDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDetails.Location = new Point(1196, 12);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(416, 509);
            gbDetails.TabIndex = 3;
            gbDetails.TabStop = false;
            gbDetails.Text = "TutorDetails";
            gbDetails.Visible = false;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 44);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 15;
            label4.Text = "TutorID:";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 275);
            label6.Name = "label6";
            label6.Size = new Size(105, 32);
            label6.TabIndex = 12;
            label6.Text = "Subject:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(32, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 72);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // Subject
            // 
            Subject.Location = new Point(139, 275);
            Subject.Name = "Subject";
            Subject.Size = new Size(219, 39);
            Subject.TabIndex = 8;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1149, 522);
            groupBox1.TabIndex = 4;
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1040, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // DeleteTutor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 536);
            Controls.Add(groupBox1);
            Controls.Add(gbDetails);
            Name = "DeleteTutor";
            Text = "DeleteTutor";
            Load += DeleteTutor_Load;
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDetails;
        private Label tutorIDtxt;
        private Label label4;
        private Button btnCloseUpdate;
        private Label label6;
        private Button btnDelete;
        private TextBox phonetxt;
        private TextBox emailtxt;
        private TextBox lnametxt;
        private TextBox fnametxt;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox Subject;
        private GroupBox groupBox1;
        private Button btnClose;
        private DataGridView dataGridView1;
    }
}