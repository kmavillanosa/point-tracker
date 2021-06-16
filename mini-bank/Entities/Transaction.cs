using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_tracker.Entities
{
    public class Transaction
    {
        [Browsable(false)]
        public string Id { get; set; }
        public int Amount { get; set; }
        public string Remarks { get; set; }
        public TransactionType Type { get; set; }
        public DateTime EntryDate { get; set; }
        [DisplayName("Active")]
        public bool IsActive { get; set; }
    }
}
