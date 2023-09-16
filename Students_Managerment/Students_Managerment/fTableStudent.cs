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
    public partial class fTableStudent : Form
    {
        //attribute
        private string studentName;
        private string studentFulName;

        // contructer
        public fTableStudent()
        {
            InitializeComponent();
        }
        public fTableStudent(string studentName, string fullName)
        {
            this.studentName = studentName;
            this.studentFulName = fullName;
            InitializeComponent();
        }

        //object of form Admin
        fTableAdmin studentList = new fTableAdmin();

        //event buttomn LogOunt
        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //event load of form Students
        private void fTableStudent_Load(object sender, EventArgs e)
        {
            txNameTeacher.Text = studentName;
            txFullName.Text = studentFulName;
        }

        //event buttomn ListStudents
        private void bListStudents_Click(object sender, EventArgs e)
        {
            ShowStudentList();
        }

        //funtion show form Admin in form Students
        private void ShowStudentList()
        {
            studentList.enable("Students");
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
