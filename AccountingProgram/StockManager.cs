using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccountingProgram
{
    public class StockManager : IStockService
    {
        DataBase dataBase = new DataBase();
        SqlCommand command;


        public void Delete(Products products,Int16 stock)
        { 
            command = new SqlCommand("update Products set StockRemaining=StockRemaining -'" 
                + stock + "' where ProductBarcode=@barcode", dataBase.connection);
            command.Parameters.AddWithValue("@barcode", products.ProductBarcode);
            dataBase.connection.Open();
            command.ExecuteNonQuery();
            dataBase.connection.Close();
        }

        public void Update(Products products,Int16 stock)
        {
            command = new SqlCommand("update Products set StockRemaining=StockRemaining +'" + stock + "' where ProductBarcode=@barcode", dataBase.connection);
            command.Parameters.AddWithValue("@barcode", products.ProductBarcode);
            dataBase.connection.Open();
            command.ExecuteNonQuery();
            dataBase.connection.Close();
        }
    }
}
