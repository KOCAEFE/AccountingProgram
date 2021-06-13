using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingProgram
{
    public partial class OrderForm : Form
    {
        DataBase dataBase = new DataBase();
        SqlDataReader sdr;
        SqlCommand command;
        DataTable table = new DataTable();
        Random rnd = new Random();
        int siparisno;
        int sonid;
        public OrderForm()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtbarcode.Clear();
            txtPiece.Clear();
        }
        
        void SonId()
        {
            try
            {
                dataBase.connection.Open();
                command = new SqlCommand("select count(*) from Customers", dataBase.connection);
                int sayi = (int)command.ExecuteScalar();
                if (sayi>0)
                {
                    command = new SqlCommand("select IDENT_CURRENT ('Customers')", dataBase.connection);

                    sonid = Convert.ToInt32(command.ExecuteScalar());
                    sdr = command.ExecuteReader();
                }
                dataBase.connection.Close();
            }
            catch (Exception)
            {

               
            }
            

        }

        public void NewCustomerMessage()
        {
            SonId();
            
            command = new SqlCommand("select *from customers where CustomerId='" + sonid + "'", dataBase.connection);
            dataBase.connection.Open();
            sdr = command.ExecuteReader();


            if (sdr.Read())
            {
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("accdrm12394@gmail.com");
                ePosta.To.Add(Convert.ToString(sdr["Mail"]));
                ePosta.Subject = "" + sdr["CustomerName"] + " " + sdr["CustomerLastName"] + " Hoş geldiniz";
                ePosta.Body = "" + sdr["CustomerName"] + " " + sdr["CustomerLastName"] + " Hoş geldiniz"
                    + "\n" + "Müşteri numaranız " + "" + sonid + "\n" + "iyi günler dileriz";
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
        public void UrunEkle()
        {
            command = new SqlCommand("select * from Products Where ProductBarcode=@barcode", dataBase.connection);
            command.Parameters.AddWithValue("@barcode", txtbarcode.Text);
            dataBase.connection.Open();
            sdr = command.ExecuteReader();
            if (sdr.Read())
            {

                dataGridView1.DataSource = table;
                table.Rows.Add(siparisno, sdr["ProductName"], txtbarcode.Text, txtPiece.Text, sdr["SalesPrice"],
                    dateTimePicker1.Value);
                clear();
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    toplam = toplam + (Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value)
                        * Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value));
                    label4.Text = /*" "*/ Convert.ToString(toplam);  //" ₺";
                }
                dataBase.connection.Close();


            }
            else
            {
                MessageBox.Show("hata");
            }
            dataBase.connection.Close();
        }

        void UrunCikar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("SEÇİLECEK ");
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            UrunEkle();
        }
        void YeniMusteri()
        {

            command = new SqlCommand("insert into Customers(CustomerName,CustomerLastName,City,Phone,Mail)" +
                "values(@name,@lastname,@city,@phone,@mail)", dataBase.connection);
            command.Parameters.AddWithValue("@name", txtname.Text);
            command.Parameters.AddWithValue("@lastname", txtlastname.Text);
            command.Parameters.AddWithValue("@city", cbxCity.Text);
            command.Parameters.AddWithValue("@phone", txtphone.Text);
            command.Parameters.AddWithValue("@mail", txtMail.Text);
            dataBase.connection.Open();
            command.ExecuteNonQuery();
            dataBase.connection.Close();

        }
        void YeniMusteri2()
        {
            try
            {
                dataBase.connection.Open();
                command = new SqlCommand("select count(*) from Customers where Phone='" + txtphone.Text + "'", dataBase.connection);
                int sonuc =Convert.ToInt32(command.ExecuteScalar());
                dataBase.connection.Close();
                if (sonuc == 0)
                {
                    if (txtlastname.Text!=""&& txtname.Text != "" && txtphone.Text != "")
                    {
                        dataBase.connection.Open();
                        command = new SqlCommand("insert into Customers(CustomerName,CustomerLastName,City,Phone,Mail)" +
                        "values(@name,@lastname,@city,@phone,@mail)", dataBase.connection);
                        command.Parameters.AddWithValue("@name", txtname.Text);
                        command.Parameters.AddWithValue("@lastname", txtlastname.Text);
                        command.Parameters.AddWithValue("@city", cbxCity.Text);
                        command.Parameters.AddWithValue("@phone", txtphone.Text);
                        command.Parameters.AddWithValue("@mail", txtMail.Text);
                        command.ExecuteNonQuery();
                        dataBase.connection.Close();
                        MessageBox.Show("müşteri kaydedildi");

                    }
                    else
                    {
                        if (txtname.Text == "")
                        {
                            MessageBox.Show("isim boş bırakılamaz");
                        }
                        if (txtlastname.Text == "")
                        {
                            MessageBox.Show("soyad boş bırakılamaz");
                        }
                        else
                        {
                            MessageBox.Show("telefon boş bırakılamaz");
                        }
                    }
                        
                    
                }
                if (sonuc>0)
                {
                    MessageBox.Show("KAYITLI MÜŞTERİ");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("kayıt hatalı");
            }
        }
        void SehirDoldur()
        {
            command = new SqlCommand("select* from City", dataBase.connection);
            dataBase.connection.Open();
            sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                cbxCity.Items.Add(sdr["City"]);
            }
            dataBase.connection.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            SehirDoldur();
            siparisno = rnd.Next();
            List<string> idlist = new List<string>();

            command = new SqlCommand("select * from Orders", dataBase.connection);
            dataBase.connection.Open();
            sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                idlist.Add(sdr["Id"].ToString());
            }
            for (int i = 0; i < idlist.Count; i++)
            {

                if (Convert.ToInt32(idlist[i]) == siparisno)
                {
                    i = -1;
                    siparisno = rnd.Next();

                }
            }
            dataBase.connection.Close();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("ProductBarcode", typeof(string));
            table.Columns.Add("Piece", typeof(Int16));
            table.Columns.Add("SalesPrice", typeof(decimal));
            table.Columns.Add("Date", typeof(DateTime));
        }
        public void SiparisTamamla()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                command = new SqlCommand("insert into Orders(Id,ProductBarcode,ProductName,Piece,SalesPrice,TotalPrice,Date)" +
                    " values(@id,@barcode,@name,@piece,@salesprice,@totalprice,@date)", dataBase.connection);
                command.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                command.Parameters.AddWithValue("@barcode", Convert.ToString(dataGridView1.Rows[i].Cells[2].Value));
                command.Parameters.AddWithValue("@name", Convert.ToString(dataGridView1.Rows[i].Cells[1].Value));
                command.Parameters.AddWithValue("@piece", Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value));
                command.Parameters.AddWithValue("@salesprice", Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value));
                command.Parameters.AddWithValue("@totalprice", Convert.ToDecimal(label4.Text));
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                dataBase.connection.Open();
                command.ExecuteNonQuery();
                dataBase.connection.Close();
            }

        }

        private void btncomplete_Click(object sender, EventArgs e)
        {
            SiparisTamamla();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            UrunCikar();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
             YeniMusteri2();
            NewCustomerMessage();
        }
    }
}
