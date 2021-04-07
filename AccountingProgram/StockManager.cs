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
        public void Add(Stocks stocks)
        {
          
            Console.WriteLine("merhabas");
        }

        public void Delete(Stocks stocks)
        {
            Console.WriteLine("merhabas");
        }

        public void Update(Stocks stocks)
        {
            Console.WriteLine("merhabas");
        }
    }
}
