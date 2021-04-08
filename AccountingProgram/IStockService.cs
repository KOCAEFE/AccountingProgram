using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    public interface IStockService
    {
        
        void Update(Products products, Int16 stock);
        void Delete(Products products, Int16 stock);
    }
}
