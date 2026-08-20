namespace GrindBookingSystem
{
    partial class WelcomePage
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
            button2 = new Button();
            groupBox1 = new GroupBox();
            submitbtn = new Button();
            tbNumber = new TextBox();
            label2 = new Label();
            enterButton = new Button();
            tbEmail = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(235, 236);
            button1.Name = "button1";
            button1.Size = new Size(274, 114);
            button1.TabIndex = 0;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(699, 236);
            button2.Name = "button2";
            button2.Size = new Size(274, 114);
            button2.TabIndex = 0;
            button2.Text = "Student";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(submitbtn);
            groupBox1.Controls.Add(tbNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(enterButton);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(489, 381);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 256);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Number";
            groupBox1.Visible = false;
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(372, 200);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(112, 34);
            submitbtn.TabIndex = 5;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Visible = false;
            submitbtn.Click += submitbtn_Click;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(456, 148);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(150, 34);
            tbNumber.TabIndex = 4;
            tbNumber.Visible = false;
            tbNumber.TextChanged += tbNumber_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 148);
            label2.Name = "label2";
            label2.Size = new Size(399, 28);
            label2.TabIndex = 3;
            label2.Text = "Enter the number we sent on your email:";
            label2.Visible = false;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(537, 94);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(112, 34);
            enterButton.TabIndex = 2;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(230, 94);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(301, 34);
            tbEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 94);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Email:";
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 668);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "WelcomePage";
            Text = "WelcomePage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label1;
        private Button enterButton;
        private TextBox tbEmail;
        private Button submitbtn;
        private TextBox tbNumber;
        private Label label2;
    }
}