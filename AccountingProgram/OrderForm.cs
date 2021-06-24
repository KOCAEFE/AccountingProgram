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
        int musteriid;
        double toplam;
        public OrderForm()
        {
            InitializeComponent();
        }
        void Productclear()
        {
            txtbarcode.Clear();
            txtPiece.Clear();
        }
        void CustomerClear()
        {
            txtname.Clear();
            txtlastname.Clear();
            txtbarcode.Clear();
            txtaddress.Clear();
            txtMail.Clear();
            txtphone.Clear();
            cbxCity.Text = "";
            cbxDistrict.Text = "";

        }
        //Müşteriler tablosuna eklenen son kaydın id'sini alır mesaj göndermek için
        void SonId()
        {
            try
            {
                dataBase.connection.Open();
                command = new SqlCommand("select count(*) from Customers", dataBase.connection);
                int sayi = (int)command.ExecuteScalar();
                if (sayi > 0)
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
        //Kayıt olan müşteriye müşteri numarasını mail ile gönderir
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
        void Tutar()
        {
            toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               
                toplam = toplam + (Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value)
                    * Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value));
                label4.Text = /*" "*/ Convert.ToString(toplam);  //" ₺";
            }
            
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
                Productclear();
                
                dataBase.connection.Close();
            }
            else
            {
                MessageBox.Show("hatalı ürün girişi");
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
            Tutar();
        }
        void MusteriGetir()
        {
            if (txtphone.TextLength==10)
            {
                dataBase.connection.Open();
                command = new SqlCommand("Select * from Customers Where Phone=@phone", dataBase.connection);
                command.Parameters.AddWithValue("@phone", txtphone.Text);
                sdr = command.ExecuteReader();
                if (sdr.Read())
                {
                    txtname.Text = (string)sdr["CustomerName"];
                    txtlastname.Text = (string)sdr["CustomerLastName"];
                    cbxCity.Text = (string)sdr["City"];
                    cbxDistrict.Text = (string)sdr["District"];
                    txtaddress.Text = (string)sdr["Address"];
                    txtMail.Text = (string)sdr["Mail"];
                    musteriid = (int)sdr["CustomerId"];

                    btnNewCustomer.Visible = false;
                    btnClear.Visible=true;     
                }

                dataBase.connection.Close();
                SehirEkle();

            }
        }
        
        void YeniMusteri()
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
                        command = new SqlCommand("insert into Customers(CustomerName,CustomerLastName,City,District,Address,Phone,Mail,Date)" +
                        "values(@name,@lastname,@city,@district,@address,@phone,@mail,@date)", dataBase.connection);
                        command.Parameters.AddWithValue("@name", txtname.Text);
                        command.Parameters.AddWithValue("@lastname", txtlastname.Text);
                        command.Parameters.AddWithValue("@city", cbxCity.Text);
                        command.Parameters.AddWithValue("@district", cbxDistrict.Text);
                        command.Parameters.AddWithValue("@address", txtaddress.Text);
                        command.Parameters.AddWithValue("@phone", txtphone.Text);
                        command.Parameters.AddWithValue("@mail", txtMail.Text);
                        command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                        command.ExecuteNonQuery();
                             
                        dataBase.connection.Close();
                        btnNewCustomer.Visible = false;
                        MessageBox.Show("müşteri kaydedildi");
                        
                        NewCustomerMessage();
                        MusteriGetir();

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
                   
                    MessageBox.Show("Müşteri zaten kayıtlı");
                    btnNewCustomer.Visible = false;
                    btnClear.Visible = true;

                }
                
            }
            catch (Exception)
            {
               
                MessageBox.Show("kayıt hatalı");
            }
        }
        void SehirEkle()
        {
            command = new SqlCommand("select* from City", dataBase.connection);
            dataBase.connection.Open();
            sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                cbxCity.Items.Add(sdr["CityName"]);
            }
            dataBase.connection.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //SehirEkle();
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
            try
            {
                if (btnNewCustomer.Visible == false )
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        command = new SqlCommand("insert into Orders(Id,ProductBarcode,ProductName,Piece,SalesPrice,Date)" +
                            " values(@id,@barcode,@name,@piece,@salesprice,@date)", dataBase.connection);
                        //command.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                        command.Parameters.AddWithValue("@id", siparisno);
                        command.Parameters.AddWithValue("@barcode", Convert.ToString(dataGridView1.Rows[i].Cells[2].Value));
                        command.Parameters.AddWithValue("@name", Convert.ToString(dataGridView1.Rows[i].Cells[1].Value));
                        command.Parameters.AddWithValue("@piece", Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value));
                        command.Parameters.AddWithValue("@salesprice", Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value));
                        command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                        dataBase.connection.Open();
                        command.ExecuteNonQuery();
                        dataBase.connection.Close();
                    }
                    command = new SqlCommand("insert into TotalPrice(OrderID,TotalPrice,Date)values(@id,@totalprice,@date)", dataBase.connection);
                    command.Parameters.AddWithValue("@id", siparisno);
                    command.Parameters.AddWithValue("@totalprice", Convert.ToDecimal(label4.Text));
                    command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    dataBase.connection.Open();
                    command.ExecuteNonQuery();
                    dataBase.connection.Close();

                    command = new SqlCommand("insert into OrderDetails(OrderId,CustomerId,Date)values(@orderid,@customerid,@date)", dataBase.connection);
                    command.Parameters.AddWithValue("@orderid", siparisno);
                    command.Parameters.AddWithValue("@customerid", musteriid);
                    command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    dataBase.connection.Open();
                    command.ExecuteNonQuery();
                    dataBase.connection.Close();
                    CustomerClear();
                    dataGridView1.Columns.Clear();
                    label4.Text = "0";

                }
                else
                {
                    MessageBox.Show("müşteri bilgilerini giriniz");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ÜRÜN GİRİNİZ");
            }
           
        }

        private void btncomplete_Click(object sender, EventArgs e)
        {
            SiparisTamamla();
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            UrunCikar();
            Tutar();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
             YeniMusteri();
            //NewCustomerMessage();
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDistrict.Items.Clear();
            cbxDistrict.Text = "";
            if (btnNewCustomer.Visible ==true)
            {
                dataBase.connection.Open();
                command = new SqlCommand("select * From District where CityId=@city", dataBase.connection);
                command.Parameters.AddWithValue("@city", cbxCity.SelectedIndex + 1);
                sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    cbxDistrict.Items.Add(sdr["DistrictName"]);
                }
                dataBase.connection.Close();
            }
        }

        private void txtphone_TextChanged_1(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CustomerClear();
            btnNewCustomer.Visible = true;
        }
    }
}
