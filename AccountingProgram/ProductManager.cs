using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountingProgram
{
    public class ProductManager : IProductService
    {
        DataBase dataBase = new DataBase();
        SqlCommand command;
        
        
        
        public void Add(Products product)
        {
                command = new SqlCommand("insert into Products Values(@name,@barcodeno," +
                "@buyingprice,@salesprice,@stock)", dataBase.connection);
                command.Parameters.AddWithValue("@name", product.ProductName);
                command.Parameters.AddWithValue("@barcodeno", product.ProductBarcode);
                command.Parameters.AddWithValue("@buyingprice", product.BuyingPrice);
                command.Parameters.AddWithValue("@salesprice", product.SalesPrice);
                command.Parameters.AddWithValue("@stock", product.StockRemaining);
                dataBase.connection.Open();
                command.ExecuteNonQuery();
                dataBase.connection.Close();    
        }

        public void Delete(Products product)
        {
            command = new SqlCommand("Delete From Products Where ProductBarcode=@barcode"
                , dataBase.connection);
            command.Parameters.AddWithValue("@barcode", product.ProductBarcode);
            dataBase.connection.Open();
            command.ExecuteNonQuery();
            dataBase.connection.Close();
        }

        public void Update(Products product)
        {
            command = new SqlCommand("UPDATE Products Set ProductName=@name,BuyingPrice=@buy," +
                "SalesPrice=@sales Where ProductBarcode=@barcode", dataBase.connection);
            command.Parameters.AddWithValue("@barcode", product.ProductBarcode);
            command.Parameters.AddWithValue("@name", product.ProductName);
            command.Parameters.AddWithValue("@buy", product.BuyingPrice);
            command.Parameters.AddWithValue("@sales", product.SalesPrice);
            dataBase.connection.Open();
            command.ExecuteNonQuery();
            dataBase.connection.Close();
        }
    }
}
