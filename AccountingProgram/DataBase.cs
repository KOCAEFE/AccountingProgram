using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Configuration;
using System.Data;


namespace AccountingProgram
{
    class DataBase
    {
        //public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-97S6E8G;Initial Catalog=AccountingProgram;Integrated Security=True");
        public SqlConnection connection = new SqlConnection
            (ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);

        public void DataRetrieval(string sorgu,DataGridView dataGridView)
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu, connection);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView.DataSource = table;
            connection.Close();  
        }
        public void DataSearch(string sorgu,DataGridView dataGridView)
        {
            connection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sorgu, connection);
            da.Fill(table);
            dataGridView.DataSource = table;
            connection.Close();
        }
      
       
    }

        

    
}
