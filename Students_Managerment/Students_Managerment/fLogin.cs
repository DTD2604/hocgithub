using Students_Managerment.dummydata;
using Students_Managerment.show_form;
using System.Data.SqlClient;

namespace Students_Managerment
{
    public partial class fLogin : Form
    {
        // contructer
        public fLogin()
        {
            InitializeComponent();
        }

        //attribute
        private string UserName;
        private string Password;
        private string method;

        //event buttomn exit
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //event closing form login
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the program?", "announcement", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        //event buttomn login
        private void login_Click(object sender, EventArgs e)
        {

            // trường hợp điền đầy đủ userName và passWord
            if (txUserName.Text != "" && txPassWord.Text != "")
            {
                UserName = txUserName.Text;
                Password = txPassWord.Text;
                method = cbMethod.Text;

                //TH1: chọn đối tượng là Teacher
                if (method == "Teacher")
                {
                    if (Login(UserName, Password, method))
                    {
                        ShowfTeacher(UserName);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect account or password.", "announcement");
                    }
                }
                //TH2: chọn đối tượng là Students
                else if (method == "Students")
                {
                    if (Login(UserName, Password, method))
                    {
                        ShowfStudents(UserName);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect account or password.", "announcement");
                    }
                }
                //TH3: chọn đối tượng là Admin
                else if (method == "Admin")
                {
                    if (Login(UserName, Password, method))
                    {
                        ShowfAdmin(UserName);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect account or password.", "announcement");
                    }
                }
            }
            // trường hợp điền thiếu một trong hai textBox
            else
            {
                MessageBox.Show("Passwords or accounts must not be left blank.!", "announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //event linkLabel Register
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm.Instance.showRegister();
        }

        //event keyPress of textBox userName
        private void txUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Special characters are not allowed.", "announcement");
                e.Handled = true;
            }
        }

        //event keyPress of textBox PassWord
        private void txPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Special characters are not allowed.", "announcement");
                e.Handled = true;
            }
        }

        //event buttomn show
        private void bShow_Click(object sender, EventArgs e)
        {
            txPassWord.PasswordChar = txPassWord.PasswordChar == '*' ? '\0' : '*';
        }

        // function Login
        public bool Login(string UserName, string Password, string Method)
        {
            return AccountDAO.Instance.login(UserName, Password, Method);
        }

        // function Show form Admin
        private void ShowfAdmin(string userName)
        {
            this.Hide();
            ShowForm.Instance.showfAdmin(userName);
            this.Show();
        }

        // funtion Show form Students
        private void ShowfStudents(string userName)
        {
            this.Hide();
            ShowForm.Instance.showfStudent(userName);
            this.Show();
        }

        // funtion Show form Teacher
        private void ShowfTeacher(string userName)
        {
            this.Hide();
            ShowForm.Instance.showfTeacher(userName);
            this.Show();
        }
    }
}