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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        SqlCommand command;
        DataTable table;
        SqlDataAdapter da;
        SqlDataReader sdr;
        private void ReportForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Siparişler();







        }

        public void Ciro()
        {
            string sorgu = "select * from TotalPrice";
            dataBase.DataRetrieval(sorgu, dataGridView1);
            command = new SqlCommand("select sum(totalprice)from TotalPrice where date between'" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "'", dataBase.connection);


        }
        public void Siparişler()
        {

            string sorgu = "SELECT O.Id,O.ProductName,O.ProductBarcode,O.Piece,O.SalesPrice,C.CustomerName,C.CustomerLastName,C.Phone,C.City,C.District,C.Address,C.Mail,OrderDetails.Date FROM OrderDetails INNER JOIN Orders o ON OrderDetails.OrderId=o.Id INNER JOIN Customers c ON OrderDetails.CustomerId = c.CustomerId  order by OrderDetails.Date desc";
            command = new SqlCommand(sorgu, dataBase.connection);
            dataBase.connection.Open();
            da = new SqlDataAdapter(command);
            table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            dataBase.connection.Close();
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Siparişler();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                string sorgu = "select * from TotalPrice";
                dataBase.DataRetrieval(sorgu, dataGridView1);
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.connection.Open();
            string cirosorgu = "select sum(totalprice) as Ciro from TotalPrice where date between @tarih1 and @tarih2";
            table = new DataTable();
            da = new SqlDataAdapter(cirosorgu, dataBase.connection);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Value);
            da.Fill(table);
            dataBase.connection.Close();
            dataGridView1.DataSource = table;
        }
    }
}
