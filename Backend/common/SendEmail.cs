using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class SendEmail
    {


        private string massage;

        public string Massage
        {
            get { return massage; }
            set { massage = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string sub;

        public string Sub
        {
            get { return sub; }
            set { sub = value; }
        }

    }
}
