namespace Students_Managerment
{
    partial class Register
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
            bRegister = new Button();
            txtUserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            txtName = new TextBox();
            txtMail = new TextBox();
            txtAge = new TextBox();
            txtPhone = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            txtPassword = new TextBox();
            bDelete = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 77);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // bRegister
            // 
            bRegister.Location = new Point(197, 353);
            bRegister.Name = "bRegister";
            bRegister.Size = new Size(94, 29);
            bRegister.TabIndex = 7;
            bRegister.Text = "Register";
            bRegister.UseVisualStyleBackColor = true;
            bRegister.Click += bRegister_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(118, 33);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(173, 27);
            txtUserName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 36);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 129);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 0;
            label3.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 187);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 77);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 0;
            label5.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 36);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 0;
            label7.Text = "User Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(bDelete);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtMail);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bRegister);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(84, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 409);
            panel1.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(249, 27);
            txtName.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(118, 126);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(249, 27);
            txtMail.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(477, 74);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(113, 27);
            txtAge.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(118, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(249, 27);
            txtPhone.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 247);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 8;
            label6.Text = "Method";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Teacher", "Student", "Admin" });
            comboBox1.Location = new Point(272, 244);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(412, 29);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(178, 27);
            txtPassword.TabIndex = 1;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(325, 353);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(94, 29);
            bDelete.TabIndex = 8;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Picture1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button bRegister;
        private TextBox txtUserName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Panel panel1;
        private TextBox txtAge;
        private TextBox txtMail;
        private TextBox txtName;
        private Button bDelete;
        private TextBox txtPassword;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox txtPhone;
        private PictureBox pictureBox1;
    }
}