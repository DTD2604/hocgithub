using Microsoft.VisualBasic;
using Students_Managerment.show_form;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Managerment.dummydata
{
    public class IDUAccount
    {
        //singlaton
        private static IDUAccount instance;
        public static IDUAccount Instance
        {
            get { if (instance == null) instance = new IDUAccount(); return instance; }
            private set
            {
                instance = value;
            }
        }
        private IDUAccount() { }

        //funtion delete for form Admin
        public int DeleteById(string ID)
        {
            string query = $"delete dbo.Student where ID = {ID}";
            int Deleted = DataProvider.Indexer.ExecuteNonQuery(query);

            if (Deleted > 0) { MessageBox.Show("successful", "announcement"); }
            else { MessageBox.Show("false", "announcement"); }

            return Deleted;
        }

        //funtion Update for form Admin
        public int UpdateSinhVien(string ID, string name, string email, string age, string phone)
        {
            string query = $"update dbo.Student set Name = '{name}', Mail = '{email}', Age = {age}, Phone = {phone} where ID ={ID}";
            int update = DataProvider.Indexer.ExecuteNonQuery(query);

            if (update > 0) { MessageBox.Show("successful", "announcement"); }
            else { MessageBox.Show("false", "announcement"); }

            return update;
        }

        //funtion Add for form Admin
        public int addStudent(string name, string age, string email, string phone, int sum)
        {
            int newStudent = 0;
            if (name != "")
            {
                if (age != "")
                {
                    if (email != "")
                    {
                        if (email != "")
                        {
                            string query = $"insert into dbo.Student values({sum + 1},'" + $"student{sum + 1}" + "','" + name + "'," + age + ",N'" + email + "'," + phone + ",N'" + $"123a{sum + 1}" + "')";
                            newStudent = DataProvider.Indexer.ExecuteNonQuery(query);
                        }
                        else { MessageBox.Show("You haven't entered the student's phone number", "announcement"); }
                    }
                    else { MessageBox.Show("You haven't entered the student's email", "announcement"); }
                }
                else { MessageBox.Show("you have not entered studetn's age", "announcement"); }
            }
            else { MessageBox.Show("You haven't entered the student's name", "announcement"); }

            if (newStudent > 0) { MessageBox.Show("successful", "announcement"); }
            else { MessageBox.Show("false", "announcement"); }

            return newStudent;
        }

        //funtion Find for Form Admin
        public DataTable findStudent(string id)
        {
            string query = "select * from dbo.student where ID = '" + id + "'";
            DataTable findStudy = DataProvider.Indexer.ExecuteQuery(query);
            return findStudy;
        }

        //funtion Add for form Register
        public int Register(string userName, string name, string age, string email, string phone, string Password, string method)
        {
            int newStudent = 0;
            int sum = Convert.ToInt32(ShowForm.Instance.count());
            if (name != "" && age != "" && email != "" && method != "" && userName != "" && Password != "" && phone != "")
            {
                string query = $"insert into dbo.{method} values({sum + 1},'" + $"{userName}" + "','" + name + "'," + age + ",N'" + email + "'," + phone + ",N'" + $"{Password}" + "')";
                newStudent = DataProvider.Indexer.ExecuteNonQuery(query);
            }
            else { MessageBox.Show("Do not leave blank.", "announcement"); }

            if (newStudent > 0) { MessageBox.Show("successful", "announcement"); }
            else { MessageBox.Show("false", "announcement"); }

            return newStudent;
        }
    }
}

