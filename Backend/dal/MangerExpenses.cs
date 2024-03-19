using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace dal
{
    public partial class Expenses
    {
        public static void Add(common.Expenses t)
        {
            Expenses clss = Mapper.Casting(t);
            using (VaadBayitEntities VaadBayitEntitiesEntities = new VaadBayitEntities())
            {
                try
                {
                    VaadBayitEntitiesEntities.Expenses.Add(clss);
                    VaadBayitEntitiesEntities.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }
        public static void Update(common.Expenses e)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s1 = VaadBayitEntities.Expenses.Where(z => z.IdExpense == e.IdExpense).First();
                try
                {
                    if(e.Details!="תקלה")
                    s1.Details = e.Details;
                    if(e.Amount!="")
                    s1.Amount = e.Amount;
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }
        }
        public static void Remove(int id)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                
                try
                {
                    var s = VaadBayitEntities.Expenses.Where(z => z.IdExpense == id).First();
                    var Expenses = VaadBayitEntities.Expenses.Where(z => z.IdExpense == id).ToList();
                    // Expenses.ForEach(s1 => s1. = null);
                    VaadBayitEntities.Expenses.Remove(s);
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }

        }
        public static IEnumerable<Expenses> get()
        {
            IEnumerable<Expenses> n;
            List<Expenses> Expenses = new List<Expenses>();
            List<Expenses> a;
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                a = VaadBayitEntities.Expenses.ToList();
                //List<Expenses> n = new List<Expenses>();
               n=  a.OrderBy(e => e.Details);

            }
            return n;
        }
        public static int getId()
        {
            int s;
            Expenses n;
            List<Expenses> Expenses = new List<Expenses>();
            List<Expenses> a;
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                a = VaadBayitEntities.Expenses.ToList();
                n=  a.OrderBy(e => e.IdExpense>e.IdExpense).Last();
                s = n.IdExpense;
            }
            return s;
        }
    }
}
