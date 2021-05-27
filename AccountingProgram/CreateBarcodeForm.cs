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
    public partial class CreateBarcodeForm : Form
    {
        public CreateBarcodeForm()
        {
            InitializeComponent();
        }
        BarcodeLib.Barcode barCode = new BarcodeLib.Barcode();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Trim() == "")
            {
                MessageBox.Show("Input Barcode", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBarcode.Text.Trim() == "")
            {
                MessageBox.Show("Input Width", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBarcode.Text.Trim() == "")
            {
                MessageBox.Show("Input Height", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            errorProvider1.Clear();
            int nW = Convert.ToInt32(txtWidth.Text.Trim());
            int nH = Convert.ToInt32(txtHeight.Text.Trim());
            barCode.Alignment = BarcodeLib.AlignmentPositions.CENTER;
            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            type = BarcodeLib.TYPE.CODE128;
            try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    barCode.IncludeLabel = true;
                    barCode.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), "RotateNoneFlipNone", true);
                    barcode.Image = barCode.Encode(type, txtBarcode.Text, Color.Black, Color.White, nW, nH);

                }
                barcode.Width = barcode.Image.Width;
                barcode.Height = barcode.Image.Height;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Graphics graph = e.Graphics)
            {
                for (int nJ = 0; nJ < 5; nJ++)
                {
                    int rowX = 0;

                    int rowY = 0;
                    for (int NI = 0; NI < 8; NI++)
                    {
                        graph.DrawImage(barcode.Image, rowY + 10, 5 + rowX);
                        rowX = rowX + barcode.Width + 22;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}

