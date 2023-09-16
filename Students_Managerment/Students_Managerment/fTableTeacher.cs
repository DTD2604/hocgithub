using Students_Managerment.dummydata;
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
    public partial class fTableTeacher : Form
    {
        //attribute
        private string UserName;
        private string fullName;

        // contructer
        public fTableTeacher()
        {
            InitializeComponent();
        }
        public fTableTeacher(string name, string fullname)
        {
            this.UserName = name;
            this.fullName = fullname;
            InitializeComponent();
        }

        //object of form Admin
        fTableAdmin studentList = new fTableAdmin();

        //event load form Teacher
        private void fTableTeacher_Load(object sender, EventArgs e)
        {
            txFullName.Text = fullName;
            txNameTeacher.Text = UserName;
        }

        //event buttomn LogOut
        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //event buttomn ListStudents
        private void bListStudents_Click(object sender, EventArgs e)
        {
            ShowStudentList();
        }

        //funtion show form Admin in form Teacher
        private void ShowStudentList()
        {
            studentList.enable("Teacher");
            studentList.MdiParent = this;
            studentList.TopLevel = false;
            studentList.FormBorderStyle = FormBorderStyle.None;
            studentList.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(studentList);
            this.panelDesktop.Tag = studentList;
            studentList.BringToFront();
            studentList.Show();
        }
    }
}
