﻿
namespace AccountingProgram
{
    partial class OrderForm
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
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtPiece = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncomplete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(121, 19);
            this.txtbarcode.MaxLength = 13;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(132, 22);
            this.txtbarcode.TabIndex = 0;
            // 
            // txtPiece
            // 
            this.txtPiece.Location = new System.Drawing.Point(357, 19);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Size = new System.Drawing.Size(139, 22);
            this.txtPiece.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(279, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(444, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(530, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(449, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Visible = false;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadd.Location = new System.Drawing.Point(519, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(103, 39);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Ekle";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncomplete
            // 
            this.btncomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncomplete.Location = new System.Drawing.Point(94, 530);
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.Size = new System.Drawing.Size(247, 54);
            this.btncomplete.TabIndex = 8;
            this.btncomplete.Text = "Siparişi Tamamla";
            this.btncomplete.UseVisualStyleBackColor = true;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(738, 425);
            this.dataGridView1.TabIndex = 9;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(654, 12);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 39);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Çıkar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 651);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncomplete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPiece);
            this.Controls.Add(this.txtbarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtPiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncomplete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
    }
}