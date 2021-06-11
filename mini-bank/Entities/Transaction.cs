using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Entities
{
    public class Transaction
    {
        [Browsable(false)]
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public TransactionType Type { get; set; }
        public DateTime EntryDate { get; set; }
        [DisplayName("Active")]
        public bool IsActive { get; set; }
    }
}
