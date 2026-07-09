namespace GrindBookingSystem
{
    partial class AddStudent
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
            date = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            AddButton = new Button();
            email = new TextBox();
            phone = new TextBox();
            lname = new TextBox();
            fname = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // date
            // 
            date.Location = new Point(198, 305);
            date.Name = "date";
            date.Size = new Size(374, 37);
            date.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 101);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 152);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 201);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 1;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 249);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 305);
            label5.Name = "label5";
            label5.Size = new Size(142, 28);
            label5.TabIndex = 1;
            label5.Text = "Date of Birth:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(phone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(fname);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(date);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(920, 525);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "AddStudent";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(619, 401);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(193, 81);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // email
            // 
            email.Location = new Point(125, 245);
            email.Name = "email";
            email.Size = new Size(211, 37);
            email.TabIndex = 2;
            // 
            // phone
            // 
            phone.Location = new Point(125, 197);
            phone.Name = "phone";
            phone.Size = new Size(233, 37);
            phone.TabIndex = 2;
            // 
            // lname
            // 
            lname.Location = new Point(173, 148);
            lname.Name = "lname";
            lname.Size = new Size(225, 37);
            lname.TabIndex = 2;
            // 
            // fname
            // 
            fname.Location = new Point(187, 101);
            fname.Name = "fname";
            fname.Size = new Size(223, 37);
            fname.TabIndex = 2;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 556);
            Controls.Add(groupBox1);
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker date;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox email;
        private TextBox phone;
        private TextBox lname;
        private TextBox fname;
        private Button AddButton;
    }
}