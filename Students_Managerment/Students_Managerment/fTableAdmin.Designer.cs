namespace Students_Managerment
{
    partial class fTableAdmin
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            gbInformation = new GroupBox();
            txFindID = new TextBox();
            txAge = new TextBox();
            txPhone = new TextBox();
            txEmail = new TextBox();
            label3 = new Label();
            bFind = new Button();
            label2 = new Label();
            label1 = new Label();
            lable1 = new Label();
            txName = new TextBox();
            gbAction = new GroupBox();
            blogOut = new Button();
            bUpdate = new Button();
            bDelete = new Button();
            bAdd = new Button();
            button1 = new Button();
            gbStudentList = new GroupBox();
            dgvStudentList = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clmUserName = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            ClmPhone = new DataGridViewTextBoxColumn();
            ClmEmail = new DataGridViewTextBoxColumn();
            clmAge = new DataGridViewTextBoxColumn();
            clPassword = new DataGridViewTextBoxColumn();
            dataProviderBindingSource = new BindingSource(components);
            txSum = new TextBox();
            lSum = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            gbInformation.SuspendLayout();
            gbAction.SuspendLayout();
            gbStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataProviderBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(gbInformation);
            panel1.Controls.Add(gbAction);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 796);
            panel1.TabIndex = 0;
            // 
            // gbInformation
            // 
            gbInformation.BackColor = Color.FromArgb(224, 224, 224);
            gbInformation.Controls.Add(txFindID);
            gbInformation.Controls.Add(txAge);
            gbInformation.Controls.Add(txPhone);
            gbInformation.Controls.Add(txEmail);
            gbInformation.Controls.Add(label3);
            gbInformation.Controls.Add(bFind);
            gbInformation.Controls.Add(label2);
            gbInformation.Controls.Add(label1);
            gbInformation.Controls.Add(lable1);
            gbInformation.Controls.Add(txName);
            gbInformation.Location = new Point(3, 4);
            gbInformation.Margin = new Padding(3, 4, 3, 4);
            gbInformation.Name = "gbInformation";
            gbInformation.Padding = new Padding(3, 4, 3, 4);
            gbInformation.Size = new Size(366, 543);
            gbInformation.TabIndex = 1;
            gbInformation.TabStop = false;
            gbInformation.Text = "Information";
            // 
            // txFindID
            // 
            txFindID.Location = new Point(137, 485);
            txFindID.Margin = new Padding(3, 4, 3, 4);
            txFindID.Name = "txFindID";
            txFindID.Size = new Size(49, 27);
            txFindID.TabIndex = 4;
            txFindID.Text = "0";
            txFindID.TextAlign = HorizontalAlignment.Center;
            // 
            // txAge
            // 
            txAge.Location = new Point(152, 417);
            txAge.Margin = new Padding(3, 4, 3, 4);
            txAge.Name = "txAge";
            txAge.Size = new Size(180, 27);
            txAge.TabIndex = 3;
            // 
            // txPhone
            // 
            txPhone.Location = new Point(152, 177);
            txPhone.Margin = new Padding(3, 4, 3, 4);
            txPhone.Name = "txPhone";
            txPhone.Size = new Size(180, 27);
            txPhone.TabIndex = 1;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(152, 297);
            txEmail.Margin = new Padding(3, 4, 3, 4);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(180, 27);
            txEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 421);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Age";
            // 
            // bFind
            // 
            bFind.BackColor = Color.FromArgb(255, 128, 128);
            bFind.Location = new Point(194, 478);
            bFind.Margin = new Padding(3, 4, 3, 4);
            bFind.Name = "bFind";
            bFind.Size = new Size(87, 40);
            bFind.TabIndex = 5;
            bFind.Text = "Find";
            bFind.UseVisualStyleBackColor = false;
            bFind.Click += bFind_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 188);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 308);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(19, 68);
            lable1.Name = "lable1";
            lable1.Size = new Size(49, 20);
            lable1.TabIndex = 1;
            lable1.Text = "Name";
            // 
            // txName
            // 
            txName.Location = new Point(152, 57);
            txName.Margin = new Padding(3, 4, 3, 4);
            txName.Name = "txName";
            txName.Size = new Size(180, 27);
            txName.TabIndex = 0;
            // 
            // gbAction
            // 
            gbAction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gbAction.Controls.Add(blogOut);
            gbAction.Controls.Add(bUpdate);
            gbAction.Controls.Add(bDelete);
            gbAction.Controls.Add(bAdd);
            gbAction.Location = new Point(3, 555);
            gbAction.Margin = new Padding(3, 4, 3, 4);
            gbAction.Name = "gbAction";
            gbAction.Padding = new Padding(3, 4, 3, 4);
            gbAction.Size = new Size(366, 237);
            gbAction.TabIndex = 0;
            gbAction.TabStop = false;
            gbAction.Text = "Action";
            // 
            // blogOut
            // 
            blogOut.BackColor = Color.FromArgb(255, 128, 128);
            blogOut.Location = new Point(126, 188);
            blogOut.Margin = new Padding(3, 4, 3, 4);
            blogOut.Name = "blogOut";
            blogOut.Size = new Size(87, 40);
            blogOut.TabIndex = 9;
            blogOut.Text = "LogOut";
            blogOut.UseVisualStyleBackColor = false;
            blogOut.Click += blogOut_Click;
            // 
            // bUpdate
            // 
            bUpdate.BackColor = Color.FromArgb(192, 192, 255);
            bUpdate.Location = new Point(110, 116);
            bUpdate.Margin = new Padding(3, 4, 3, 4);
            bUpdate.Name = "bUpdate";
            bUpdate.Size = new Size(138, 48);
            bUpdate.TabIndex = 6;
            bUpdate.Text = "Update";
            bUpdate.UseVisualStyleBackColor = false;
            bUpdate.Click += bUpdate_Click;
            // 
            // bDelete
            // 
            bDelete.BackColor = Color.FromArgb(192, 192, 255);
            bDelete.Location = new Point(194, 43);
            bDelete.Margin = new Padding(3, 4, 3, 4);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(138, 48);
            bDelete.TabIndex = 8;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = false;
            bDelete.Click += bDelete_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.FromArgb(192, 192, 255);
            bAdd.Location = new Point(19, 43);
            bAdd.Margin = new Padding(3, 4, 3, 4);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(138, 48);
            bAdd.TabIndex = 7;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Dock = DockStyle.Top;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(373, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(897, 88);
            button1.TabIndex = 2;
            button1.Text = "Student Managerment";
            button1.UseVisualStyleBackColor = false;
            // 
            // gbStudentList
            // 
            gbStudentList.Controls.Add(panel3);
            gbStudentList.Controls.Add(panel2);
            gbStudentList.Dock = DockStyle.Fill;
            gbStudentList.ForeColor = SystemColors.ControlText;
            gbStudentList.Location = new Point(373, 88);
            gbStudentList.Margin = new Padding(3, 4, 3, 4);
            gbStudentList.Name = "gbStudentList";
            gbStudentList.Padding = new Padding(3, 4, 3, 4);
            gbStudentList.Size = new Size(897, 708);
            gbStudentList.TabIndex = 3;
            gbStudentList.TabStop = false;
            gbStudentList.Text = "Student List";
            // 
            // dgvStudentList
            // 
            dgvStudentList.AutoGenerateColumns = false;
            dgvStudentList.BackgroundColor = SystemColors.Control;
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Columns.AddRange(new DataGridViewColumn[] { clmId, clmUserName, clmName, ClmPhone, ClmEmail, clmAge, clPassword });
            dgvStudentList.DataSource = dataProviderBindingSource;
            dgvStudentList.Dock = DockStyle.Fill;
            dgvStudentList.Location = new Point(0, 0);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowHeadersWidth = 51;
            dgvStudentList.RowTemplate.Height = 29;
            dgvStudentList.Size = new Size(891, 555);
            dgvStudentList.TabIndex = 0;
            dgvStudentList.DataBindingComplete += dgvStudentList_DataBindingComplete;
            // 
            // clmId
            // 
            clmId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clmId.DataPropertyName = "ID";
            clmId.Frozen = true;
            clmId.HeaderText = "ID";
            clmId.MinimumWidth = 6;
            clmId.Name = "clmId";
            clmId.Width = 53;
            // 
            // clmUserName
            // 
            clmUserName.DataPropertyName = "UserName";
            clmUserName.HeaderText = "UserName";
            clmUserName.MinimumWidth = 6;
            clmUserName.Name = "clmUserName";
            clmUserName.ReadOnly = true;
            clmUserName.Visible = false;
            clmUserName.Width = 110;
            // 
            // clmName
            // 
            clmName.DataPropertyName = "name";
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.Width = 125;
            // 
            // ClmPhone
            // 
            ClmPhone.DataPropertyName = "phone";
            ClmPhone.HeaderText = "Phone";
            ClmPhone.MinimumWidth = 6;
            ClmPhone.Name = "ClmPhone";
            ClmPhone.Visible = false;
            ClmPhone.Width = 160;
            // 
            // ClmEmail
            // 
            ClmEmail.DataPropertyName = "Mail";
            ClmEmail.HeaderText = "Email";
            ClmEmail.MinimumWidth = 6;
            ClmEmail.Name = "ClmEmail";
            ClmEmail.Visible = false;
            ClmEmail.Width = 200;
            // 
            // clmAge
            // 
            clmAge.DataPropertyName = "age";
            clmAge.HeaderText = "Age";
            clmAge.MinimumWidth = 6;
            clmAge.Name = "clmAge";
            clmAge.Visible = false;
            clmAge.Width = 50;
            // 
            // clPassword
            // 
            clPassword.DataPropertyName = "Password";
            clPassword.HeaderText = "Password";
            clPassword.MinimumWidth = 6;
            clPassword.Name = "clPassword";
            clPassword.ReadOnly = true;
            clPassword.Visible = false;
            clPassword.Width = 90;
            // 
            // dataProviderBindingSource
            // 
            dataProviderBindingSource.DataSource = typeof(dummydata.DataProvider);
            // 
            // txSum
            // 
            txSum.Enabled = false;
            txSum.Location = new Point(142, 59);
            txSum.Margin = new Padding(3, 4, 3, 4);
            txSum.Name = "txSum";
            txSum.Size = new Size(93, 27);
            txSum.TabIndex = 7;
            txSum.TextAlign = HorizontalAlignment.Center;
            // 
            // lSum
            // 
            lSum.AutoSize = true;
            lSum.Location = new Point(100, 63);
            lSum.Name = "lSum";
            lSum.Size = new Size(38, 20);
            lSum.TabIndex = 5;
            lSum.Text = "Sum";
            // 
            // panel2
            // 
            panel2.Controls.Add(txSum);
            panel2.Controls.Add(lSum);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 579);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 125);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvStudentList);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(891, 555);
            panel3.TabIndex = 9;
            // 
            // fTableAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 796);
            Controls.Add(gbStudentList);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fTableAdmin";
            Text = "StudentList";
            Load += StudentList_Load;
            panel1.ResumeLayout(false);
            gbInformation.ResumeLayout(false);
            gbInformation.PerformLayout();
            gbAction.ResumeLayout(false);
            gbStudentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataProviderBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox gbAction;
        private GroupBox gbInformation;
        private Button button1;
        private Button bDelete;
        private Button bFind;
        private Button bAdd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lable1;
        private TextBox txName;
        private TextBox txAge;
        private TextBox txPhone;
        private TextBox txEmail;
        private GroupBox gbStudentList;
        private DataGridView dgvStudentList;
        private TextBox txSum;
        private Label lSum;
        private Button bUpdate;
        private TextBox txFindID;
        private Button blogOut;
        private BindingSource dataProviderBindingSource;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmUserName;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn ClmPhone;
        private DataGridViewTextBoxColumn ClmEmail;
        private DataGridViewTextBoxColumn clmAge;
        private DataGridViewTextBoxColumn clPassword;
        private Panel panel3;
        private Panel panel2;
    }
}