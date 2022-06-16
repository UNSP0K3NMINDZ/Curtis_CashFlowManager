using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_CashFlowManager
{
    internal class Employees : IPayable 
    {
        private string _firstName;
        private string _lastName;
        private string _ssn;
        private decimal _pay;
        private decimal _payType;
        private Ledger.LedgerType _payOption;

        public Employees (string firstName, string lastName, string ssn)
        {
            _firstName = firstName;
            _lastName = lastName;
            _ssn = ssn;
        }
        public decimal setPay(decimal pay)
        {
            _pay = pay;
            return _pay;
        }
        public decimal getPay
        {
            get { return _pay; }
        }
        public Ledger.LedgerType getPayOption (Ledger.LedgerType payOption)
        {
            _payOption = payOption;
            return _payOption;
        }
        public Ledger.LedgerType PayOption { get { return _payOption; } }

        public decimal Payable { get { return _pay; } }

    }
}
