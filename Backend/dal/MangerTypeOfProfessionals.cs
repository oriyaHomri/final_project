using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace dal
{
    public partial class TypeOfProfessionals
    {
        public static void Add(common.TypeOfProfessionals t)
        {
            TypeOfProfessionals clss = Mapper.Casting(t);
            using (VaadBayitEntities VaadBayitEntitiesEntities = new VaadBayitEntities())
            {
                try
                {
                    VaadBayitEntitiesEntities.TypeOfProfessionals.Add(clss);
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
                var s = VaadBayitEntities.TypeOfProfessionals.Where(z => z.IdProfessional== id).First();
                try
                {
                    var TypeOfProfessionals = VaadBayitEntities.TypeOfProfessionals.Where(z => z.IdProfessional == id).ToList();
                    // TypeOfProfessionals.ForEach(s1 => s1. = null);
                    VaadBayitEntities.TypeOfProfessionals.Remove(s);
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }

        }
        public static List<TypeOfProfessionals> get()
        {

            List<TypeOfProfessionals> TypeOfProfessionals = new List<TypeOfProfessionals>();
            List<TypeOfProfessionals> a;
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                a = VaadBayitEntities.TypeOfProfessionals.ToList();

            }
            return a;
        }
    }
}
