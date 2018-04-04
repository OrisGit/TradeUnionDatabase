using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Union_Database.Entity
{
    class TradeUnionCard
    {
        public virtual long number { get; set; }
        public virtual string name { get; set; }
        public virtual string surname { get; set; }
        public virtual string middleТame { get; set; }
        public virtual DateTime dateOfbirth { get; set; }
        public virtual string education { get; set; }
        public virtual DateTime dateOfEntry { get; set; }
        public virtual DateTime dateOfWithdrawal { get; set; }
        public virtual string address { get; set; }
        public virtual string phoneNumber { get; set; }
    }
}
