using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;

namespace AccountingProgram
{
    public class LoginManager : ILoginService
    {
        DataBase dataBase = new DataBase();
        public bool usercheck = true;
      
        public void Login(string userName, string password)
        {
            try
            {
                string query = "Select * From Users Where UserName='" + userName + "' And UserPassword='" + password + "'";
                SqlCommand command = new SqlCommand(query, dataBase.connection);
                dataBase.connection.Open();
                SqlDataReader sdr = command.ExecuteReader();

                if (sdr.Read())
                {

                }
                else
                {
                    MessageBox.Show("hatalı giriş");
                    usercheck = false;
                }
                dataBase.connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void SendMail(string mail)
        {
            Users usersDataBase = new Users();
            string query = "Select UserName,UserPassword From Users Where  Mail='" + mail + "'";
            SqlCommand command = new SqlCommand(query, dataBase.connection);
            dataBase.connection.Open();
            SqlDataReader sdr = command.ExecuteReader();

            if (sdr.Read())
            {
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("accdrm12394@gmail.com");
                ePosta.To.Add(mail);
                ePosta.Subject = "Şifre bilgilendirme";
                ePosta.Body = "Kullanıcı adınız:'" + sdr["UserName"] + "'\n Sifreniz:'" + sdr["UserPassword"] + "'";
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("accdrm12394@gmail.com", "denemehesabi123");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Send(ePosta);
            }
            else
            {
                MessageBox.Show("hatalı");
            }
            dataBase.connection.Close();
        }

    }
}

