namespace Students_Managerment
{
    partial class fTableTeacher
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
            panel1 = new Panel();
            bListStudents = new Button();
            panel3 = new Panel();
            bLogOut = new Button();
            txFullName = new TextBox();
            txNameTeacher = new TextBox();
            lFullName = new Label();
            lUserName = new Label();
            button1 = new Button();
            panelDesktop = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(bListStudents);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 845);
            panel1.TabIndex = 0;
            // 
            // bListStudents
            // 
            bListStudents.Anchor = AnchorStyles.None;
            bListStudents.BackColor = Color.FromArgb(128, 128, 255);
            bListStudents.Location = new Point(4, 352);
            bListStudents.Margin = new Padding(3, 4, 3, 4);
            bListStudents.Name = "bListStudents";
            bListStudents.Size = new Size(235, 249);
            bListStudents.TabIndex = 3;
            bListStudents.Text = "List Students";
            bListStudents.UseVisualStyleBackColor = false;
            bListStudents.Click += bListStudents_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(bLogOut);
            panel3.Controls.Add(txFullName);
            panel3.Controls.Add(txNameTeacher);
            panel3.Controls.Add(lFullName);
            panel3.Controls.Add(lUserName);
            panel3.Location = new Point(3, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 207);
            panel3.TabIndex = 0;
            // 
            // bLogOut
            // 
            bLogOut.BackColor = Color.FromArgb(255, 128, 128);
            bLogOut.Location = new Point(70, 151);
            bLogOut.Margin = new Padding(3, 4, 3, 4);
            bLogOut.Name = "bLogOut";
            bLogOut.Size = new Size(86, 31);
            bLogOut.TabIndex = 4;
            bLogOut.Text = "LogOut";
            bLogOut.UseVisualStyleBackColor = false;
            bLogOut.Click += bLogOut_Click;
            // 
            // txFullName
            // 
            txFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txFullName.BackColor = Color.FromArgb(224, 224, 224);
            txFullName.Enabled = false;
            txFullName.Location = new Point(104, 91);
            txFullName.Margin = new Padding(3, 4, 3, 4);
            txFullName.Name = "txFullName";
            txFullName.Size = new Size(127, 27);
            txFullName.TabIndex = 3;
            // 
            // txNameTeacher
            // 
            txNameTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txNameTeacher.BackColor = Color.FromArgb(224, 224, 224);
            txNameTeacher.Enabled = false;
            txNameTeacher.Location = new Point(104, 37);
            txNameTeacher.Margin = new Padding(3, 4, 3, 4);
            txNameTeacher.Name = "txNameTeacher";
            txNameTeacher.Size = new Size(127, 27);
            txNameTeacher.TabIndex = 2;
            // 
            // lFullName
            // 
            lFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lFullName.AutoSize = true;
            lFullName.Location = new Point(16, 95);
            lFullName.Name = "lFullName";
            lFullName.Size = new Size(74, 20);
            lFullName.TabIndex = 1;
            lFullName.Text = "full Name";
            // 
            // lUserName
            // 
            lUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lUserName.AutoSize = true;
            lUserName.Location = new Point(16, 41);
            lUserName.Name = "lUserName";
            lUserName.Size = new Size(76, 20);
            lUserName.TabIndex = 0;
            lUserName.Text = "userName";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Dock = DockStyle.Top;
            button1.Enabled = false;
            button1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(242, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(1035, 125);
            button1.TabIndex = 6;
            button1.Text = "Welcome, the teacher has come to the student management program.";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(242, 125);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1035, 720);
            panelDesktop.TabIndex = 10;
            // 
            // fTableTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 845);
            Controls.Add(panelDesktop);
            Controls.Add(button1);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fTableTeacher";
            Text = "fTableTeacher";
            WindowState = FormWindowState.Maximized;
            Load += fTableTeacher_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button bListStudents;
        private Label lFullName;
        private Label lUserName;
        private TextBox txFullName;
        private TextBox txNameTeacher;
        private Button bLogOut;
        private Button button1;
        private Panel panelDesktop;
    }
}