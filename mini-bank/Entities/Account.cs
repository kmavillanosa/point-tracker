using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Entities
{
    public class Account
    {
        [Browsable(false)]
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Browsable(false)]
        public List<Transaction> Transactions { get; set; }
        public Account()
        {
            Transactions = new List<Transaction>();
        }
    }
}
