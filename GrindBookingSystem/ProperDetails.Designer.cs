namespace GrindBookingSystem
{
    partial class ProperDetails
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
            subNametxt = new TextBox();
            phonetxt = new TextBox();
            emailtxt = new TextBox();
            lnametxt = new TextBox();
            fnametxt = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(closebtn);
            groupBox1.Controls.Add(subNametxt);
            groupBox1.Controls.Add(phonetxt);
            groupBox1.Controls.Add(emailtxt);
            groupBox1.Controls.Add(lnametxt);
            groupBox1.Controls.Add(fnametxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 484);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proper Details";
            // 
            // closebtn
            // 
            closebtn.Location = new Point(281, 369);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(153, 77);
            closebtn.TabIndex = 1;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // subNametxt
            // 
            subNametxt.Location = new Point(199, 254);
            subNametxt.Name = "subNametxt";
            subNametxt.Size = new Size(140, 37);
            subNametxt.TabIndex = 1;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 255);
            label4.Name = "label4";
            label4.Size = new Size(163, 30);
            label4.TabIndex = 0;
            label4.Text = "Subject Name:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 72);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // ProperDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 517);
            Controls.Add(groupBox1);
            Name = "ProperDetails";
            Text = "ProperDetails";
            Load += ProperDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox subNametxt;
        private TextBox phonetxt;
        private TextBox emailtxt;
        private TextBox lnametxt;
        private TextBox fnametxt;
        private Button closebtn;
    }
}