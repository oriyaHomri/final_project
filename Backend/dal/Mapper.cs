using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public static class Mapper
    {
       
        public static Tenants Casting(common.Tenants t)
        {
            Tenants tenants = new Tenants
            {
                TenantCode = t.TenantCode,
                FirstName = t.FirstName,
                LastName = t.LastName,
                NumOfApartment=t.NumOfApartment,
                Floor=t.Floor,
                E_Mail = t.EMail
            };
            return tenants;
        }
        public static Tasks Casting(common.Tasks t)
        {
            Tasks tasks = new Tasks
            {
                IdExpense = t.IdExpense,
                Date = t.Date1,
                Description = t.Description,
                FixeDate=t.FixeDate,
                FixedBy=t.FixedBy,
                IdFrequency=t.IdFrequency,
                FixedCost=t.FixedCost,
                IdTask=t.IdTask,
               // TypeOfTask=t.TypeOfTask,
                

            };
            return tasks;
        }
        public static Frequencies Casting(common.Frequencies t)
        {
            Frequencies tenants = new Frequencies
            {
                IdFrequency = t.FrequenciesCode,
                Details   = t.Details,
                Fixed = t.Fixed1,
                StartDate = t.StartDate,
                TypeOfTasks=t.FrequencyType1
            };
            return tenants;
        }
        public static common.Frequencies Casting(Frequencies t)
        {
            common.Frequencies tasks = new common.Frequencies
            {
                FrequenciesCode = t.IdFrequency,
                StartDate = t.StartDate,
                FrequencyType1 = t.TypeOfTasks,
                Fixed1=t.Fixed,
                Details=t.Details

            };
            return tasks;
        } public static Expenses Casting(common.Expenses expenses)
        {
            Expenses e = new Expenses
            {
                Amount = expenses.Amount,
                IdExpense = expenses.IdExpense,
                Date = expenses.Date1,
                // Receipt=expenses.Receipt,
                Details = expenses.Details,

            };
            return e;
        }
        public static common.Expenses Casting(Expenses expenses)
        {
            common.Expenses e = new common.Expenses
            {
                Amount = expenses.Amount,
                IdExpense = expenses.IdExpense,
                Date1 = expenses.Date,
                // Receipt=expenses.Receipt,
                Details = expenses.Details,

            };
            return e;
        }
        public static Professionals Casting(common.Professionals professionals)
        {
            Professionals p = new Professionals
            {
                IdProfessional = professionals.ProfessionalsCode,
                FirstName = professionals.FirstName,
                E_Mail = professionals.EMail,
                LastName = professionals.LastName,
                Address=professionals.Address,
                Phone=professionals.Phone,
                TypeOfProfessional=professionals.TypeOfProfessional
            };
            return p;
        }
        public static common.Professionals Casting(Professionals professionals)
        {
            common.Professionals p = new common.Professionals
            {
                ProfessionalsCode = professionals.IdProfessional,
                FirstName = professionals.FirstName,
                EMail = professionals.E_Mail,
                LastName = professionals.LastName,
                TypeOfProfessional=professionals.TypeOfProfessional,
                Phone=professionals.Phone,
                Address=professionals.Address,
                Mobile=professionals.Mobile
            };
            return p;
        }
        public static Insertions Casting(common.Insertions Insertions)
        {
            Insertions e = new Insertions
            {
                Amount = Insertions.Amount,
                IdInsertion = Insertions.IdInsertion,
                Date = Insertions.Date1,
                 //Receipt=expenses.Receipt,
                Description = Insertions.Description,
                TenantId= Insertions.TenantId

            };
            return e;
        }
        public static common.Insertions Casting(Insertions insertions)
        {
            common.Insertions e = new common.Insertions
            {
                Amount = insertions.Amount,
                IdInsertion = insertions.IdInsertion,
                Date1 = insertions.Date,
                // Receipt=expenses.Receipt,
                Description = insertions.Description,
                TenantId=insertions.TenantId
            };
            return e;
        }
         public static TypeOfProfessionals Casting(common.TypeOfProfessionals type)
        {
            TypeOfProfessionals e = new TypeOfProfessionals
            {
                IdProfessional = type.IdTypeOfProfessionals,
                TypeOfProfessional = type.TypeOfProfessional,
                      };
            return e;
        }
        public static common.TypeOfProfessionals Casting(TypeOfProfessionals type)
        {
            common.TypeOfProfessionals e = new common.TypeOfProfessionals
            {
                IdTypeOfProfessionals = type.IdProfessional,
                TypeOfProfessional = type.TypeOfProfessional,
            };
            return e;
        }
        public static FrequencyObject Casting(common.FrequencyObject type)
        {
            FrequencyObject e = new FrequencyObject
            {
                IdFrequencyObject = type.IdFrequencyObject,
                FrequencyObject1 = type.FrequencyObjects,
                      };
            return e;
        }
        public static common.FrequencyObject Casting(FrequencyObject type)
        {
            common.FrequencyObject e = new common.FrequencyObject
            {
                IdFrequencyObject = type.IdFrequencyObject,
                FrequencyObjects= type.FrequencyObject1,
            };
            return e;
        }
        public static TypeOfTasks Casting(common.TypeOfTasks type)
        {
            TypeOfTasks e = new TypeOfTasks
            {
                IdTypeOfTasks = type.IdTypeOfTasks,
                TypeOfTask = type.TypeOfTask,
                      };
            return e;
        }
        public static common.TypeOfTasks Casting(TypeOfTasks type)
        {
            common.TypeOfTasks e = new common.TypeOfTasks
            {
                IdTypeOfTasks = type.IdTypeOfTasks,
                TypeOfTask = type.TypeOfTask,
            };
            return e;
        }
        public static common.Tenants Casting(Tenants t)
        {
            common.Tenants tenants = new common.Tenants
            {
                TenantCode = t.TenantCode,
                FirstName = t.FirstName,
                LastName = t.LastName,
                EMail = t.E_Mail,
                Floor = t.Floor,
                NumOfApartment = t.NumOfApartment
            };
            return tenants;
        }
        
        public static common.Tasks Casting(Tasks t)
        {
            common.Tasks tasks = new common.Tasks
            {
                IdExpense = t.IdExpense,
                Date1 = t.Date,
                Description = t.Description,
                FixeDate=t.FixeDate,
                FixedBy=t.FixedBy,
                TypeOfTask=t.TypeOfTask,
                IdTask=t.IdTask,
                FixedCost=t.FixedCost,
                IdFrequency=t.TypeOfTask

            };
            return tasks;
        }
        
    }
}
