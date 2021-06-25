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

        private void ReportForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            DataBase dataBase = new DataBase();
            string sorgu = "SELECT O.Id,O.ProductName,O.ProductBarcode,O.Piece,O.SalesPrice,T.TotalPrice,C.CustomerName,C.CustomerLastName,C.Phone,C.City,C.District,C.Address,C.Mail,OrderDetails.Date FROM OrderDetails INNER JOIN Orders o ON OrderDetails.OrderId=o.Id INNER JOIN Customers c ON OrderDetails.CustomerId = c.CustomerId INNER JOIN Totalprice t ON O.Id = T.OrderId order by OrderDetails.Date desc";
            SqlCommand command = new SqlCommand(sorgu, dataBase.connection);
            dataBase.connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table= new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            dataBase.connection.Close();


        }
    }
}
