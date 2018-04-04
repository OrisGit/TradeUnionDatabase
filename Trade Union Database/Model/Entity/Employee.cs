using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Union_Database.Entity
{
    class Employee
    {
        public virtual long id { get; set; }
        public virtual string position {get; set;}
        public virtual TradeUnionCard tradeUnionCardNumber { get; set; }
    }
}
