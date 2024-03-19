using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace dal
{
    public partial class FrequencyObject
    {
        public static void Add(common.FrequencyObject t)
        {
            FrequencyObject clss = Mapper.Casting(t);
            using (VaadBayitEntities VaadBayitEntitiesEntities = new VaadBayitEntities())
            {
                try
                {
                    VaadBayitEntitiesEntities.FrequencyObject.Add(clss);
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
                var s = VaadBayitEntities.FrequencyObject.Where(z => z.IdFrequencyObject== id).First();
                try
                {
                    var FrequencyObject = VaadBayitEntities.FrequencyObject.Where(z => z.IdFrequencyObject == id).ToList();
                    // FrequencyObject.ForEach(s1 => s1. = null);
                    VaadBayitEntities.FrequencyObject.Remove(s);
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }

        }
        public static List<FrequencyObject> get()
        {

            List<FrequencyObject> FrequencyObject = new List<FrequencyObject>();
            List<FrequencyObject> a;
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                a = VaadBayitEntities.FrequencyObject.ToList();

            }
            return a;
        }
    }
}
