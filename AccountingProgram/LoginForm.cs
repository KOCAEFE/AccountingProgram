using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingProgram
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            LoginManager loginManager = new LoginManager();
            string userName = tbxUserName.Text;
            string password = tbxPassword.Text;
            loginManager.Login(userName, password);
            if (loginManager.usercheck==true)
            {
                MainMenuForm mainMenuForm = new MainMenuForm();
                this.Hide();
                mainMenuForm.Show();
            }
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordform = new ForgotPassword();
            this.Hide();
            forgotPasswordform.Show();
        }
    }
}
