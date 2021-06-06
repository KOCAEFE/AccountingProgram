using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Int16 Piece { get; set; }
        public DateTime Date { get; set; }
    }
}
