using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace dal
{
    public partial class TypeOfTasks
    {
        public static void Add(common.TypeOfTasks t)
        {
            TypeOfTasks clss = Mapper.Casting(t);
            using (VaadBayitEntities VaadBayitEntitiesEntities = new VaadBayitEntities())
            {
                try
                {
                    VaadBayitEntitiesEntities.TypeOfTasks.Add(clss);
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
        public static void Remove(int id)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s = VaadBayitEntities.TypeOfTasks.Where(z => z.IdTypeOfTasks == id).First();
                try
                {
                    var TypeOfTasks = VaadBayitEntities.TypeOfTasks.Where(z => z.IdTypeOfTasks == id).ToList();
                    // TypeOfTasks.ForEach(s1 => s1. = null);
                    VaadBayitEntities.TypeOfTasks.Remove(s);
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }

        }
        public static List<TypeOfTasks> get()
        {

            List<TypeOfTasks> TypeOfTasks = new List<TypeOfTasks>();
            List<TypeOfTasks> a;
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                a = VaadBayitEntities.TypeOfTasks.ToList();

            }
            return a;
        }
    }
}
