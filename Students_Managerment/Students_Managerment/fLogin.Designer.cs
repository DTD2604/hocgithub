namespace Students_Managerment
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            bExit = new Button();
            txUserName = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            label3 = new Label();
            cbMethod = new ComboBox();
            panel2 = new Panel();
            bShow = new Button();
            label2 = new Label();
            txPassWord = new TextBox();
            panel1 = new Panel();
            login = new Button();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 1;
            label1.Text = "User name";
            // 
            // bExit
            // 
            bExit.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            bExit.Location = new Point(423, 253);
            bExit.Margin = new Padding(3, 4, 3, 4);
            bExit.Name = "bExit";
            bExit.Size = new Size(145, 73);
            bExit.TabIndex = 4;
            bExit.Text = "Exit";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // txUserName
            // 
            txUserName.Location = new Point(141, 4);
            txUserName.Margin = new Padding(3, 4, 3, 4);
            txUserName.Name = "txUserName";
            txUserName.Size = new Size(134, 27);
            txUserName.TabIndex = 1;
            txUserName.KeyPress += txUserName_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(login);
            groupBox1.Controls.Add(bExit);
            groupBox1.Location = new Point(78, 243);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(745, 390);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 349);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 9;
            label4.Text = "create a new account ?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(372, 349);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cbMethod);
            panel3.Location = new Point(192, 165);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 41);
            panel3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 4);
            label3.Name = "label3";
            label3.Size = new Size(107, 31);
            label3.TabIndex = 1;
            label3.Text = "Method ";
            // 
            // cbMethod
            // 
            cbMethod.FormattingEnabled = true;
            cbMethod.Items.AddRange(new object[] { "Teacher", "Students", "Admin" });
            cbMethod.Location = new Point(155, 4);
            cbMethod.Margin = new Padding(3, 4, 3, 4);
            cbMethod.Name = "cbMethod";
            cbMethod.Size = new Size(134, 28);
            cbMethod.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(bShow);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txPassWord);
            panel2.Location = new Point(379, 77);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 52);
            panel2.TabIndex = 6;
            // 
            // bShow
            // 
            bShow.Location = new Point(285, 0);
            bShow.Margin = new Padding(3, 4, 3, 4);
            bShow.Name = "bShow";
            bShow.Size = new Size(59, 35);
            bShow.TabIndex = 2;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txPassWord
            // 
            txPassWord.Location = new Point(136, 4);
            txPassWord.Margin = new Padding(3, 4, 3, 4);
            txPassWord.Name = "txPassWord";
            txPassWord.PasswordChar = '*';
            txPassWord.Size = new Size(134, 27);
            txPassWord.TabIndex = 1;
            txPassWord.KeyPress += txPassword_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txUserName);
            panel1.Location = new Point(22, 77);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 52);
            panel1.TabIndex = 5;
            // 
            // login
            // 
            login.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(118, 253);
            login.Margin = new Padding(3, 4, 3, 4);
            login.Name = "login";
            login.Size = new Size(145, 73);
            login.TabIndex = 3;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Picture1;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(913, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(1, 1);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(921, 648);
            panel4.TabIndex = 6;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 647);
            Controls.Add(panel4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fLogin";
            Text = "Form1";
            FormClosing += fLogin_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button bExit;
        private TextBox txUserName;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txPassWord;
        private ComboBox cbMethod;
        private Label label3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button login;
        private Button bShow;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}