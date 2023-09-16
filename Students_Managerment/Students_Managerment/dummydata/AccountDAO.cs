using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Students_Managerment.dummydata
{
    internal class AccountDAO
    {
        //singleton
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set
            {
                instance = value;
            }
        }
        private AccountDAO() { }

        //function Login for form Login (có tác dụng chạy các câu lệnh truy vấn )
        public bool login(string username, string password, string Method)
        {
            if (Method == "Students")
            {
                string query = $"select * from dbo.Student sv where '{username}' = sv.UserName and '{password}' = sv.Password";
                DataTable result = DataProvider.Indexer.ExecuteQuery(query);
                return result.Rows.Count > 0;
            }
            else if (Method == "Teacher")
            {
                string query = $"select * from dbo.teacher sv where '{username}' = sv.UserName and '{password}' = sv.Password";
                DataTable result = DataProvider.Indexer.ExecuteQuery(query);
                return result.Rows.Count > 0;
            }
            else if (Method == "Admin")
            {
                string query = $"select * from dbo.admin sv where '{username}' = sv.UserName and '{password}' = sv.Password";
                DataTable result = DataProvider.Indexer.ExecuteQuery(query);
                return result.Rows.Count > 0;
            }
            else
            {
                return false;
            }
            
        }
    }
}
