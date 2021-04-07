using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace AccountingProgram
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            LoginManager loginManager = new LoginManager();
            

             loginManager.SendMail(txtMail.Text);
            //UsersDataBase usersDataBase = new UsersDataBase();
            //DataBase dataBase = new DataBase();
            //usersDataBase.Mail = txtMail.Text;
            //dataBase.SendMail(usersDataBase);



        }
    }
}
