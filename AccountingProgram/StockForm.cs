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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        string sorgu = "select * from Stocks";

        DataBase dataBase = new DataBase();
        private void StockForm_Load(object sender, EventArgs e)
        {
            dataBase.DataRetrieval(sorgu, dataGridView1);
        }
    }
}
