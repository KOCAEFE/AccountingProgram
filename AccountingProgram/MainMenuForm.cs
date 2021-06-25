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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            
            if (panelMenu.Width==200)
            {
                panelMenu.Width = 65;

            }
            else
            {
                panelMenu.Width = 200;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestoredown.Visible = true;
            btnmaximize.Visible = false;
        }

        private void btnrestoredown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestoredown.Visible = false;
            btnmaximize.Visible = true;
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        public void MenuEkle(object formmenu)
        {
            if (this.panelfill.Controls.Count>0)
            {
                this.panelfill.Controls.RemoveAt(0);
            }
            Form fh = formmenu as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelfill.Controls.Add(fh);
            this.panelfill.Tag = fh;
            fh.Show();
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            MenuEkle(new NewProductForm());
        }

        private void btnMenuStock_Click(object sender, EventArgs e)
        {
            MenuEkle(new StockForm());
        }

        private void btnMenuBarcode_Click(object sender, EventArgs e)
        {
            MenuEkle(new CreateBarcodeForm());
        }


        private void btnMenuSales_Click(object sender, EventArgs e)
        {
            MenuEkle(new OrderForm());
        }

        private void btnMenuReporting_Click(object sender, EventArgs e)
        {
            MenuEkle(new ReportForm());
        }
    }
}
