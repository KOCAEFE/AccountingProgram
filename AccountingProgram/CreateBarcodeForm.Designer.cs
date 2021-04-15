
namespace AccountingProgram
{
    partial class CreateBarcodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxbarcode = new System.Windows.Forms.TextBox();
            this.btbcreatebarcode = new System.Windows.Forms.Button();
            this.btnaddword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(79, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 270);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbxbarcode
            // 
            this.tbxbarcode.Location = new System.Drawing.Point(79, 312);
            this.tbxbarcode.MaxLength = 13;
            this.tbxbarcode.Name = "tbxbarcode";
            this.tbxbarcode.Size = new System.Drawing.Size(425, 22);
            this.tbxbarcode.TabIndex = 1;
            // 
            // btbcreatebarcode
            // 
            this.btbcreatebarcode.Location = new System.Drawing.Point(527, 312);
            this.btbcreatebarcode.Name = "btbcreatebarcode";
            this.btbcreatebarcode.Size = new System.Drawing.Size(75, 23);
            this.btbcreatebarcode.TabIndex = 2;
            this.btbcreatebarcode.Text = "button1";
            this.btbcreatebarcode.UseVisualStyleBackColor = true;
            this.btbcreatebarcode.Click += new System.EventHandler(this.btbcreatebarcode_Click);
            // 
            // btnaddword
            // 
            this.btnaddword.Location = new System.Drawing.Point(306, 364);
            this.btnaddword.Name = "btnaddword";
            this.btnaddword.Size = new System.Drawing.Size(75, 23);
            this.btnaddword.TabIndex = 3;
            this.btnaddword.Text = "button1";
            this.btnaddword.UseVisualStyleBackColor = true;
            this.btnaddword.Click += new System.EventHandler(this.btnaddword_Click);
            // 
            // CreateBarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnaddword);
            this.Controls.Add(this.btbcreatebarcode);
            this.Controls.Add(this.tbxbarcode);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateBarcodeForm";
            this.Text = "CreateBarcode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxbarcode;
        private System.Windows.Forms.Button btbcreatebarcode;
        private System.Windows.Forms.Button btnaddword;
    }
}