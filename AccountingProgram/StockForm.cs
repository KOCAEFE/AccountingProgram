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
        string sorgu = "select ProductName,ProductBarcode,StockRemaining from Products order by StockRemaining asc";

        DataBase dataBase = new DataBase();
        ProductManager productManager = new ProductManager();
        Products products = new Products();
        StockManager stockManager = new StockManager();
        private void StockForm_Load(object sender, EventArgs e)
        {
            dataBase.DataRetrieval(sorgu, dataGridView1);
        }
        public void Clear()
        {
            tbxProductBarcode.Clear();
            tbxProductName.Clear();
            tbxpiece.Clear();

        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //this.dataGridView1.Columns["ProductId"].Visible = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxProductName.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxProductBarcode.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int16 sayi = Convert.ToInt16(tbxpiece.Text);


            // products.ProductId = Convert.ToInt32(textBox1.Text);
            products.ProductBarcode = tbxProductBarcode.Text;

            stockManager.Update(products, sayi);
            dataBase.DataRetrieval(sorgu, dataGridView1);
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int16 sayi = Convert.ToInt16(tbxpiece.Text);
            // products.ProductId= Convert.ToInt32(textBox1.Text);
            products.ProductBarcode = tbxProductBarcode.Text;
            stockManager.Delete(products, sayi);
            dataBase.DataRetrieval(sorgu, dataGridView1);
            Clear();
        }

        private void tbxsearch_TextChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select  ProductName,ProductBarcode,StockRemaining from Products Where ProductName like'%" + tbxsearch.Text +
                "%'OR ProductBarcode like'%" + tbxsearch.Text + "%'";
            dataBase.DataSearch(sorgu2, dataGridView1);
        }

        private void tbxpiece_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
