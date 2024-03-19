using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Frequencies
    {
        private int frequenciesCode;

        public int FrequenciesCode
        {
            get { return frequenciesCode; }
            set { frequenciesCode = value; }
        }
        private string details;

       public string Details
        {
            get { return details; }
            set { details = value; }
        }
     
        private bool? fixed1;

        public bool? Fixed1
        {
            get { return fixed1; }
            set { fixed1 = value; }
        }

        private int? frequencyType1;

        public int? FrequencyType1
        {
            get { return frequencyType1; }
            set { frequencyType1 = value; }
        }
        private DateTime? startDate;

        public DateTime? StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }


    }
}
