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

        public SalesForm()
        {
            InitializeComponent();
        }
        public void Ekle()
        {
            string barkod = txtbarcode.Text;
            SqlCommand command = new SqlCommand("Select From Products Where ProductBarcode='" + barkod + "'", dataBase.connection);
            dataBase.connection.Open();
            SqlDataReader sdr = command.ExecuteReader();
            if (sdr.Read())
            {
                listBox1.Items.Add(barkod);
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
