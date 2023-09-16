using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using Students_Managerment.dummydata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Managerment
{
    public partial class Register : Form
    {
        //contructer
        public Register()
        {
            InitializeComponent();
        }

        //event buttomn Register
        private void bRegister_Click(object sender, EventArgs e)
        {
           int add = IDUAccount.Instance.Register(txtUserName.Text,txtName.Text,txtAge.Text,txtMail.Text,txtPhone.Text,txtPassword.Text,comboBox1.Text);
        }

        //event buttomn delete
        private void bDelete_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtMail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
        }
    }
}
