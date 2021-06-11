using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        int sayi;
        public OrderForm()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtbarcode.Clear();
            txtPiece.Clear();
        }
        public void Ekle()
        {
            command = new SqlCommand("select * from Products Where ProductBarcode=@barcode", dataBase.connection);
            command.Parameters.AddWithValue("@barcode", txtbarcode.Text);
            dataBase.connection.Open();
            sdr = command.ExecuteReader();
            if (sdr.Read())
            {

                dataGridView1.DataSource = table;
                table.Rows.Add(sayi, sdr["ProductName"], txtbarcode.Text, txtPiece.Text, sdr["SalesPrice"], dateTimePicker1.Value);
                clear();
                double toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    toplam = toplam + (Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value));
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
            if (dataGridView1.SelectedRows.Count>0)
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
            Ekle();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            sayi = rnd.Next();
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

                if (Convert.ToInt32(idlist[i]) == sayi)
                {
                    i = -1;
                    sayi = rnd.Next();

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
    }
}
