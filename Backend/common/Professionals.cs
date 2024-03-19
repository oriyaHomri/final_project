using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Professionals
    {
        private int professionalsCode;

        public int ProfessionalsCode
        {
            get { return professionalsCode; }
            set { professionalsCode = value; }
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
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string eMail;

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }
        private string mobile;

        public string Mobile 
        {
            get { return  mobile; }
            set {  mobile = value; }
        }

        private int typeOfProfessional;

        public int TypeOfProfessional
        {
            get { return typeOfProfessional; }
            set { typeOfProfessional = value; }
        }


    }
}
