using Students_Managerment.dummydata;
using Students_Managerment.show_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Managerment
{
    public partial class fTableAdmin : Form
    {
        // contructer
        public fTableAdmin()
        {
            InitializeComponent();
        }

        //event load of form Admin
        private void StudentList_Load(object sender, EventArgs e)
        {

            dgvStudentList.DataSource = ShowForm.Instance.dgvDataSource("dbo.Student");
            AddText();
        }

        //event buttomn Find
        private void bFind_Click(object sender, EventArgs e)
        {
            DataTable data = IDUAccount.Instance.findStudent(txFindID.Text);
            foreach (DataRow row in data.Rows)
            {
                clearText();
                txName.Text += row["Name"].ToString();
                txPhone.Text += row["Phone"].ToString();
                txEmail.Text += row["Mail"].ToString();
                txAge.Text += row["Age"].ToString();
            }
            dgvStudentList.Refresh();
        }

        //event buttomn Add
        private void bAdd_Click(object sender, EventArgs e)
        {
            int newStudent = IDUAccount.Instance.addStudent(txName.Text, txAge.Text, txEmail.Text, txPhone.Text, int.Parse(txSum.Text));
            dgvStudentList.RefreshEdit();
        }

        //event buttomn Update
        private void bUpdate_Click(object sender, EventArgs e)
        {
            int update = IDUAccount.Instance.UpdateSinhVien(txFindID.Text, txName.Text, txEmail.Text, txAge.Text, txPhone.Text);
            dgvStudentList.RefreshEdit();
        }

        //event buttomn Delete
        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this student?", "announcement", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                IDUAccount.Instance.DeleteById(txFindID.Text);
                dgvStudentList.RefreshEdit();
            }
        }

        //event buttomn LogOut
        private void blogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void dgvStudentList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvStudentList.Refresh();
        }

        //funtion binding from dataGridView to textBox
        private void AddText()
        {
            txSum.Text = ShowForm.Instance.count();

            txName.DataBindings.Add(new Binding("text", dgvStudentList.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txAge.DataBindings.Add(new Binding("text", dgvStudentList.DataSource, "Age", true, DataSourceUpdateMode.Never));
            txEmail.DataBindings.Add(new Binding("text", dgvStudentList.DataSource, "Mail", true, DataSourceUpdateMode.Never));
            txPhone.DataBindings.Add(new Binding("text", dgvStudentList.DataSource, "Phone", true, DataSourceUpdateMode.Never));
            txFindID.DataBindings.Add(new Binding("text", dgvStudentList.DataSource, "ID", true, DataSourceUpdateMode.Never));
            dgvStudentList.Refresh();
        }

        //funtion enable toolBox
        public void enable(string method)
        {
            if (method == "Students")
            {
                panel1.Hide();
                clmAge.Visible = true;
            }
            else if (method == "Teacher")
            {
                panel1.Show();
                txAge.Enabled = false;
                txEmail.Enabled = false;
                txName.Enabled = false;
                txPhone.Enabled = false;
                gbAction.Enabled = false;
                clmAge.Visible = false;
                ClmEmail.Visible = false;
                ClmPhone.Visible = false;
                clmUserName.Visible = true;
            }
            else if (method == "Admin")
            {
                panel1.Show();
                txAge.Enabled = true;
                txEmail.Enabled = true;
                txName.Enabled = true;
                txPhone.Enabled = true;
                gbAction.Enabled = true;
                clPassword.Visible = true;
                clmAge.Visible = true;
                ClmEmail.Visible = true;
                ClmPhone.Visible = true;
                clmUserName.Visible = true;
            }
        }

        //funtion clear texBox
        private void clearText()
        {
            txName.Clear();
            txAge.Clear();
            txEmail.Clear();
            txPhone.Clear();
        }
    }
}
