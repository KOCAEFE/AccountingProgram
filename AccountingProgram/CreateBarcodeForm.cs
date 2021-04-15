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

        private void btbcreatebarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(tbxbarcode.Text,100);
        }

        private void btnaddword_Click(object sender, EventArgs e)
        {
            // Word uygulamasını oluşturuyoruz.
            Microsoft.Office.Interop.Word.Application WordApp = new Microsoft.Office.Interop.Word.Application();
            // Yeni doküman oluşturuyoruz.
            WordApp.Documents.Add();
            // word açılıyor.
            WordApp.Visible = true;

            Microsoft.Office.Interop.Word.Document doc = WordApp.ActiveDocument;
            // OpenFileDialog ile seçim yapılması sağlanıyor.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            ofd.Title = "Select Image To Insert....";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofd.FileNames)
                {
                    doc.InlineShapes.AddPicture(filename, Type.Missing, Type.Missing, Type.Missing);
                }
            }
        }
    }
}
