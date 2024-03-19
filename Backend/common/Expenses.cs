using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Expenses
    {
        private int idExpense;

        public int IdExpense
        {
            get { return idExpense; }
            set { idExpense = value; }
        }
        private string amount;

        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private DateTime? date1;

        public DateTime? Date1
        {
            get { return  date1; }
            set {  date1 = value; }
        }
        private string details;

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        private string receipt;

        public string Receipt
        {
            get { return receipt; }
            set { receipt = value; }
        }
       

    }
}
