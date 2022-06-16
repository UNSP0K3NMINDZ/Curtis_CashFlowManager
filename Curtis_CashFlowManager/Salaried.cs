using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_CashFlowManager
{
    internal class Salaried : Employees
    {
        private decimal _weeklyPay;
        public Salaried(string firstName, string lastName, string ssn, decimal weekly):base(firstName, lastName, ssn)
        {
            _weeklyPay = weekly;
            base.setPay(_weeklyPay);
            base.getPayOption(Ledger.LedgerType.Salaried);
        }

    }
}
