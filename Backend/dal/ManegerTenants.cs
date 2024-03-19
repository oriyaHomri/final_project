using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using common;

namespace dal
{
    public partial class Tenants
    {
        public static void Add(common.Tenants f)
        {
            Tenants tenants = Mapper.Casting(f);

            using (VaadBayitEntities entities = new VaadBayitEntities())
            {
                entities.Tenants.Add(tenants);
                try
                {
                    entities.SaveChanges();
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


            };
        }
        public static void Update(common.Tenants t)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s = VaadBayitEntities.Tenants.Where(z => z.TenantCode == t.TenantCode).First();

                s.E_Mail = t.EMail;
                s.FirstName = t.LastName;
                s.NumOfApartment = t.NumOfApartment;
                s.Floor = t.Floor;
                s.LastName = t.LastName;
                VaadBayitEntities.SaveChanges();

            }
        }
        public static List<common.Tenants> GetTenants()
        {
            List<common.Tenants> tenants = new List<common.Tenants>();
            IEnumerable<Tenants> a;
            try
            {
                using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
                {

                    a = VaadBayitEntities.Tenants.ToList();
                    foreach (var item in a)
                    {
                        common.Tenants i = Mapper.Casting(item);
                        tenants.Add(i);
                    }
                }
            }
            catch (EntityDataSourceValidationException e) { e.InnerException.ToString(); }

            return tenants;
        }
        public static void Delete(int id)
        {
            //FrequencyObject frequencyObject= Mapper.Casting(f);
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                try
                {

                    var s = VaadBayitEntities.Tenants.Where(z => z.TenantCode == id).First();

                    if (s != null)
                    {

                        VaadBayitEntities.Tenants.Remove(s);
                        VaadBayitEntities.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                }



            }
        }
    }
}
