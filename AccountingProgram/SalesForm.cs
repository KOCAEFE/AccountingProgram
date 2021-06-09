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
    
    public partial class SalesForm : Form
    {
        DataBase dataBase = new DataBase();
        SalesManager salesManager = new SalesManager();
        SqlDataReader sdr;
        SqlCommand command;

        public SalesForm()
        {
            InitializeComponent();
        }
        public void Ekle()
        {
            string barkod = txtbarcode.Text;
            command = new SqlCommand("Select ProductBarcode,ProductName,SalesPrice From Products Where ProductBarcode='" + barkod + "'", dataBase.connection);
            dataBase.connection.Open();
            sdr = command.ExecuteReader();
            if (sdr.Read())
            {
                command = new SqlCommand("insert into Orders values(@productid,@piece,@date)", dataBase.connection);
                command.Parameters.AddWithValue("@productid", barkod);
                command.Parameters.AddWithValue("@piece", Convert.ToInt16(txtPiece.Text));
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                dataBase.connection.Open();
                command.ExecuteNonQuery();
                dataBase.connection.Close();
            }
            else
            {
                MessageBox.Show("hatalı");
            }
            dataBase.connection.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle();
           
        }
    }
}
