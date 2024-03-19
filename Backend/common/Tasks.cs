using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Tasks
    {
        private int idTask;

        public int IdTask
        {
            get { return idTask; }
            set { idTask = value; }
        }
        private int? typeOfTask;

        public int? TypeOfTask
        {
            get { return typeOfTask; }
            set { typeOfTask = value; }
        }
        private DateTime? date1;

        public DateTime? Date1
        {
            get { return  date1; }
            set {  date1 = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int? fixedBy;

        public int? FixedBy
        {
            get { return fixedBy; }
            set { fixedBy = value; }
        }
        private string fixedCost;

        public string FixedCost
        {
            get { return fixedCost; }
            set { fixedCost = value; }
        }
        private DateTime? fixeDate;

        public DateTime? FixeDate
        {
            get { return fixeDate; }
            set { fixeDate = value; }
        }

        private int? idExpense;

        public int? IdExpense
        {
            get { return idExpense; }
            set { idExpense = value; }
        }
        private int? idFrequency;

        public int? IdFrequency
        {
            get { return idFrequency; }
            set { idFrequency = value; }
        }

    }
}
