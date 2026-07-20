namespace GrindBookingSystem
{
    partial class AddTutor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnSubmit = new Button();
            cbSubjects = new ComboBox();
            tb_Phone = new TextBox();
            tb_Email = new TextBox();
            tb_LastName = new TextBox();
            tb_FirstName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 76);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(414, 67);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 0;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 128);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 189);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 0;
            label4.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(91, 260);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 0;
            label5.Text = "Choose Subject:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbSubjects);
            groupBox1.Controls.Add(tb_Phone);
            groupBox1.Controls.Add(tb_Email);
            groupBox1.Controls.Add(tb_LastName);
            groupBox1.Controls.Add(tb_FirstName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(937, 431);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Tutor";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(591, 318);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(247, 80);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cbSubjects
            // 
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(258, 256);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(208, 38);
            cbSubjects.TabIndex = 2;
            // 
            // tb_Phone
            // 
            tb_Phone.Location = new Point(173, 185);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.Size = new Size(214, 37);
            tb_Phone.TabIndex = 1;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(170, 128);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(259, 37);
            tb_Email.TabIndex = 1;
            // 
            // tb_LastName
            // 
            tb_LastName.Location = new Point(537, 67);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(150, 37);
            tb_LastName.TabIndex = 1;
            // 
            // tb_FirstName
            // 
            tb_FirstName.Location = new Point(217, 67);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(150, 37);
            tb_FirstName.TabIndex = 1;
            // 
            // AddTutor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 441);
            Controls.Add(groupBox1);
            Name = "AddTutor";
            Text = "AddTutor";
            Load += AddTutor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox tb_FirstName;
        private TextBox tb_Phone;
        private TextBox tb_Email;
        private TextBox tb_LastName;
        private ComboBox cbSubjects;
        private Button btnSubmit;
    }
}