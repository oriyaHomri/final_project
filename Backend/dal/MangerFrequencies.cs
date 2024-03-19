using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using common;

namespace dal
{
    public partial class Frequencies
    {
        public  static void Add(common.Frequencies t)
        {
            Frequencies clss = Mapper.Casting(t);
            using (VaadBayitEntities VaadBayitEntitiesEntities = new VaadBayitEntities())
            {
                try
                {
                    VaadBayitEntitiesEntities.Frequencies.Add(clss);
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
        public static void Update(Frequencies frequencies)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s1 = VaadBayitEntities.Frequencies.Where(z => z.IdFrequency == frequencies.IdFrequency).First();
                try
                {
                    s1.Fixed = frequencies.Fixed;
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }
        }
        public static void Remove(int id)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s = VaadBayitEntities.Frequencies.Where(z => z.IdFrequency == id).First();
                try
                {
                    var Frequencies = VaadBayitEntities.Frequencies.Where(z => z.IdFrequency == id).ToList();
                    // Frequencies.ForEach(s1 => s1. = null);
                    VaadBayitEntities.Frequencies.Remove(s);
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }

        }
        public static List<Frequencies> get()
        {

            List<Frequencies> Frequencies = new List<Frequencies>();
            List<Frequencies> a;
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                a = VaadBayitEntities.Frequencies.ToList();

            }
            return a;
        }
    }
}
