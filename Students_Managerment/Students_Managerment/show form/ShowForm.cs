using Students_Managerment.dummydata;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Students_Managerment.show_form
{
    public class ShowForm
    {
        //singlaton
        private static ShowForm instance;
        public static ShowForm Instance
        {
            get { if (instance == null) instance = new ShowForm(); return instance; }
            private set
            {
                instance = value;
            }
        }
        private ShowForm() { }

        //funtion show form for Form Login(có tác dụng chạy các câu truy vấn, nên để một groub class chuyên chứa dữ liệu dataBase và chạy các câu query nhằm dễ tìm và sửa chữa khi bị lỗi và tăng độ bảo mật cho dữ liệu)
        public void showfStudent(string userName)
        {
            string query = "select [Name] from dbo.student where UserName = '" + userName + "'";
            DataTable Name = DataProvider.Indexer.ExecuteQuery(query);
            string fullName = "";
            foreach (DataRow row in Name.Rows) 
            {
                fullName += row["Name"].ToString();
            }
            fTableStudent fTableStudent = new fTableStudent(userName, fullName);
            fTableStudent.ShowDialog();
        }
        public void showfTeacher(string userName)
        {
            string query = "select [Name] from dbo.teacher where UserName = '" + userName + "'";
            DataTable Name = DataProvider.Indexer.ExecuteQuery(query);
            string fullName = "";
            foreach (DataRow row in Name.Rows)
            {
                fullName += row["Name"].ToString();
            }
            fTableTeacher fTableTeacher = new fTableTeacher(userName, fullName);
            fTableTeacher.ShowDialog();
        }
        public void showfAdmin(string userName)
        {
            fTableAdmin student = new fTableAdmin();
            student.enable("Admin");
            student.ShowDialog();
        }
        public void showRegister()
        {
            Register register = new Register();
            register.ShowDialog();
        }

        // chuyền data từ dataBase đến dataGridView
        public DataTable dgvDataSource(string table)
        {
            string query = "select * from "+table;
            DataTable dt = DataProvider.Indexer.ExecuteQuery(query);
            return dt;
        }

        //funtion count 
        public string count()
        {
            string query = "select count(userName) from dbo.Student";
            object counts = DataProvider.Indexer.ExecuteScalar(query);
            string sum = counts.ToString();
            return sum;
        }
    }
}
