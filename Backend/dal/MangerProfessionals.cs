using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace dal
{
    public partial class Professionals
    {
        public static void Add(common.Professionals t)
        {
            Professionals clss = Mapper.Casting(t);
            using (VaadBayitEntities VaadBayitEntitiesEntities = new VaadBayitEntities())
            {
                try
                {
                    VaadBayitEntitiesEntities.Professionals.Add(clss);
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
        public static void Update(common.Professionals p)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s1 = VaadBayitEntities.Professionals.Where(z => z.IdProfessional == p.ProfessionalsCode).First();
                try
                {
                    p.EMail = p.EMail;
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }
        }
        public static void Remove(int id)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s = VaadBayitEntities.Professionals.Where(z => z.IdProfessional == id).First();
                try
                {
                    //var Professionals = VaadBayitEntities.Professionals.Where(z => z.IdProfessional == id).ToList();
                    // Professionals.ForEach(s1 => s1. = null);
                    if(s.Mobile == "false")
                    s.Mobile = "true";
                    else s.Mobile = "false";
                    //VaadBayitEntities.Professionals.Remove(s);
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }

        }
        public static List<Professionals> get()
        {

            List<Professionals> Professionals = new List<Professionals>();
            List<Professionals> a;
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                VaadBayitEntities.SaveChanges();
                a = VaadBayitEntities.Professionals.ToList();
                VaadBayitEntities.SaveChanges();

            }
            return a;
        }
    }
}
