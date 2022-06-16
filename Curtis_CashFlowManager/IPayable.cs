using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_CashFlowManager
{
    internal interface IPayable
    {
        public decimal Payable { get; }

        public Ledger.LedgerType PayOption { get; }
    }
}
