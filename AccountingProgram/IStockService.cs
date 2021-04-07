using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    public interface IStockService
    {
        void Add(Stocks stocks);
        void Update(Stocks stocks);
        void Delete(Stocks stocks);
    }
}
