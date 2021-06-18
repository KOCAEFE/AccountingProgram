
namespace AccountingProgram
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnMenuBarcode = new System.Windows.Forms.Button();
            this.btnMenuReporting = new System.Windows.Forms.Button();
            this.btnMenuStock = new System.Windows.Forms.Button();
            this.btnMenuSales = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.PictureBox();
            this.btnrestoredown = new System.Windows.Forms.PictureBox();
            this.btnmaximize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.panelfill = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestoredown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelMenu.Controls.Add(this.btnNewProduct);
            this.panelMenu.Controls.Add(this.btnMenuBarcode);
            this.panelMenu.Controls.Add(this.btnMenuReporting);
            this.panelMenu.Controls.Add(this.btnMenuStock);
            this.panelMenu.Controls.Add(this.btnMenuSales);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 711);
            this.panelMenu.TabIndex = 0;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.FlatAppearance.BorderSize = 0;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnNewProduct.Image")));
            this.btnNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProduct.Location = new System.Drawing.Point(12, 449);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(188, 60);
            this.btnNewProduct.TabIndex = 4;
            this.btnNewProduct.Text = "            Ürünler";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnMenuBarcode
            // 
            this.btnMenuBarcode.FlatAppearance.BorderSize = 0;
            this.btnMenuBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuBarcode.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBarcode.Image")));
            this.btnMenuBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBarcode.Location = new System.Drawing.Point(12, 360);
            this.btnMenuBarcode.Name = "btnMenuBarcode";
            this.btnMenuBarcode.Size = new System.Drawing.Size(188, 60);
            this.btnMenuBarcode.TabIndex = 3;
            this.btnMenuBarcode.Text = "               Barkod                 Oluştur";
            this.btnMenuBarcode.UseVisualStyleBackColor = true;
            this.btnMenuBarcode.Click += new System.EventHandler(this.btnMenuBarcode_Click);
            // 
            // btnMenuReporting
            // 
            this.btnMenuReporting.FlatAppearance.BorderSize = 0;
            this.btnMenuReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuReporting.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuReporting.Image")));
            this.btnMenuReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReporting.Location = new System.Drawing.Point(12, 262);
            this.btnMenuReporting.Name = "btnMenuReporting";
            this.btnMenuReporting.Size = new System.Drawing.Size(188, 60);
            this.btnMenuReporting.TabIndex = 2;
            this.btnMenuReporting.Text = "           Raporlar";
            this.btnMenuReporting.UseVisualStyleBackColor = true;
            // 
            // btnMenuStock
            // 
            this.btnMenuStock.FlatAppearance.BorderSize = 0;
            this.btnMenuStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuStock.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuStock.Image")));
            this.btnMenuStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuStock.Location = new System.Drawing.Point(12, 171);
            this.btnMenuStock.Name = "btnMenuStock";
            this.btnMenuStock.Size = new System.Drawing.Size(188, 60);
            this.btnMenuStock.TabIndex = 1;
            this.btnMenuStock.Text = "    Stok";
            this.btnMenuStock.UseVisualStyleBackColor = true;
            this.btnMenuStock.Click += new System.EventHandler(this.btnMenuStock_Click);
            // 
            // btnMenuSales
            // 
            this.btnMenuSales.FlatAppearance.BorderSize = 0;
            this.btnMenuSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuSales.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuSales.Image")));
            this.btnMenuSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSales.Location = new System.Drawing.Point(12, 78);
            this.btnMenuSales.Name = "btnMenuSales";
            this.btnMenuSales.Size = new System.Drawing.Size(188, 71);
            this.btnMenuSales.TabIndex = 0;
            this.btnMenuSales.Text = "       Sipariş";
            this.btnMenuSales.UseVisualStyleBackColor = true;
            this.btnMenuSales.Click += new System.EventHandler(this.btnMenuSales_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.Controls.Add(this.btnminimize);
            this.panelTop.Controls.Add(this.btnrestoredown);
            this.panelTop.Controls.Add(this.btnmaximize);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnslide);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(200, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1222, 50);
            this.panelTop.TabIndex = 1;
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimize.Image = ((System.Drawing.Image)(resources.GetObject("btnminimize.Image")));
            this.btnminimize.Location = new System.Drawing.Point(1067, 13);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(25, 25);
            this.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimize.TabIndex = 4;
            this.btnminimize.TabStop = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnrestoredown
            // 
            this.btnrestoredown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestoredown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestoredown.Image = ((System.Drawing.Image)(resources.GetObject("btnrestoredown.Image")));
            this.btnrestoredown.Location = new System.Drawing.Point(1128, 12);
            this.btnrestoredown.Name = "btnrestoredown";
            this.btnrestoredown.Size = new System.Drawing.Size(25, 25);
            this.btnrestoredown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestoredown.TabIndex = 3;
            this.btnrestoredown.TabStop = false;
            this.btnrestoredown.Visible = false;
            this.btnrestoredown.Click += new System.EventHandler(this.btnrestoredown_Click);
            // 
            // btnmaximize
            // 
            this.btnmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximize.Image")));
            this.btnmaximize.Location = new System.Drawing.Point(1128, 12);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(25, 25);
            this.btnmaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximize.TabIndex = 2;
            this.btnmaximize.TabStop = false;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1185, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(3, 0);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(35, 44);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // panelfill
            // 
            this.panelfill.BackColor = System.Drawing.SystemColors.Window;
            this.panelfill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfill.Location = new System.Drawing.Point(200, 50);
            this.panelfill.Name = "panelfill";
            this.panelfill.Size = new System.Drawing.Size(1222, 661);
            this.panelfill.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 711);
            this.Controls.Add(this.panelfill);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestoredown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.Button btnMenuReporting;
        private System.Windows.Forms.Button btnMenuStock;
        private System.Windows.Forms.Button btnMenuSales;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnminimize;
        private System.Windows.Forms.PictureBox btnrestoredown;
        private System.Windows.Forms.PictureBox btnmaximize;
        private System.Windows.Forms.Button btnMenuBarcode;
        private System.Windows.Forms.Panel panelfill;
        private System.Windows.Forms.Button btnNewProduct;
    }
}