using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Insertions
    {
        private int idInsertion;

        public int IdInsertion
        {
            get { return idInsertion; }
            set { idInsertion = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
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
        private int? tenantId;

        public int? TenantId
        {
            get { return tenantId; }
            set { tenantId = value; }
        }
      

    }
}
