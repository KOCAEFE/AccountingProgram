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
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        ProductManager productManager = new ProductManager();
        
        public void Clear()
        {
            tbxId.Clear();
            tbxProductName.Clear();
            tbxProductBarcode.Clear();
            tbxBuyingPrice.Clear();
            tbxSalePrice.Clear();
        }
       
            
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Products newProduct()
            {
                Products product = new Products();
                product.ProductName = tbxProductName.Text;
                product.ProductBarcode = tbxProductBarcode.Text;
                product.BuyingPrice = Convert.ToDecimal(tbxBuyingPrice.Text);
                product.SalesPrice = Convert.ToDecimal(tbxSalePrice.Text);
                return product;
            }

            productManager.Add(newProduct());
            dataBase.DataRetrieval(sorgu,dataGridView1);
            Clear();
        }
        string sorgu = "select*from Products";

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            
            dataBase.DataRetrieval(sorgu,dataGridView1);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataBase.DataSearch(tbxsearch,dataGridView1);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridviewda tıklanılan satırın ilgili textboxlara dolması
            tbxId.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxProductBarcode.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxBuyingPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxSalePrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.ProductId = Convert.ToInt32(tbxId.Text);
            productManager.Delete(product);
            dataBase.DataRetrieval(sorgu,dataGridView1);
            Clear();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Products newProduct()
            {
                Products product = new Products();
                product.ProductId = Convert.ToInt32(tbxId.Text);
                product.ProductName = tbxProductName.Text;
                product.ProductBarcode = tbxProductBarcode.Text;
                product.BuyingPrice = Convert.ToDecimal(tbxBuyingPrice.Text);
                product.SalesPrice = Convert.ToDecimal(tbxSalePrice.Text);
                return product;
            }
            productManager.Update(newProduct());
            dataBase.DataRetrieval(sorgu,dataGridView1);
            Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.Columns["ProductId"].Visible = false;
            
        }
    }
}
