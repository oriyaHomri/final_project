using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using bll;

namespace dal
{
    public partial class Tasks
    {
        public static void Add(common.Tasks t)
        {
            var a=  ManegerExpenses.getId();
            t.IdExpense = a;
            Tasks clss = Mapper.Casting(t);
            using (VaadBayitEntities VaadBayitEntitiesEntities = new VaadBayitEntities())
            {
                VaadBayitEntitiesEntities.Tasks.Add(clss); try
                {
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
                var s1 = VaadBayitEntitiesEntities.Frequencies.Where(z => z.IdFrequency == t.TypeOfTask).First();
                s1.Fixed = true;
                VaadBayitEntitiesEntities.SaveChanges();
            }
        }

        public static void Update(common.Tasks Tasks)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s = VaadBayitEntities.Tasks.Where(z => z.IdTask== Tasks.IdTask).First();
                try
                {
                    if(s.Description!="")
                        s.Description = Tasks.Description;
                    if (s.FixeDate!=null)
                    s.FixeDate = Tasks.FixeDate;
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }
        }

     public static void Remove(int id)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {try
                {
                var s = VaadBayitEntities.Tasks.Where(z => z.IdTask == id).First();
                
                    var Tasks = VaadBayitEntities.Tasks.Where(z => z.IdExpense == id).ToList();
                   // Tasks.ForEach(s1 => s1. = null);
                    VaadBayitEntities.Tasks.Remove(s);
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }

        }
        public static List<Tasks> get()
        {
            
            List<Tasks> Tasks = new List<Tasks>();
            List<Tasks> a;
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                a = VaadBayitEntities.Tasks.ToList();
               
            }
            return a;
        }
    }
}
