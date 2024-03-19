using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Tenants
    {
        private int tenantCode;

        public int TenantCode
        {
            get { return tenantCode; }
            set { tenantCode = value; }
        }
        private string firstName;

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return  lastName; }
            set {  lastName = value; }
        }
        private int floor;

        public int Floor
        {
            get { return  floor; }
            set {  floor = value; }
        }
        private int numOfApartment;

        public int NumOfApartment
        {
            get { return numOfApartment; }
            set { numOfApartment = value; }
        }
        private string eMail;

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }


    }
}
