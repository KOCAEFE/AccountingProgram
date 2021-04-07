using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    public interface IProductService
    {
        void Add(Products product);
        void Delete(Products product);
        void Update(Products product);
    }
}
