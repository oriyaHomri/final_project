using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace dal
{
    public partial class Insertions
    {
        public static void Add(common.Insertions t)
        {
            Insertions clss = Mapper.Casting(t);
            using (VaadBayitEntities VaadBayitEntitiesEntities = new VaadBayitEntities())
            {
                VaadBayitEntitiesEntities.Insertions.Add(clss);
                VaadBayitEntitiesEntities.SaveChanges();
            }
        }
        public static void Update(common.Insertions i)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s1 = VaadBayitEntities.Insertions.Where(z => z.IdInsertion == i.IdInsertion).First();
                try
                {
                    if (i.Description != "")
                        s1.Description = i.Description;
                    if (i.Amount != "")
                        s1.Amount = i.Amount;

                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }
        }
        public static void Remove(int id)
        {
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                var s = VaadBayitEntities.Insertions.Where(z => z.IdInsertion == id).First();
                try
                {
                    var Insertions = VaadBayitEntities.Insertions.Where(z => z.IdInsertion == id).ToList();
                    // Insertions.ForEach(s1 => s1. = null);
                    VaadBayitEntities.Insertions.Remove(s);
                    VaadBayitEntities.SaveChanges();
                }
                catch { }
            }

        }
        public static List<Insertions> get()
        {

            List<Insertions> Insertions = new List<Insertions>();
            List<Insertions> a;
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {
                a = VaadBayitEntities.Insertions.ToList();

            }
            return a;
        }
     
        public static List<common.Insertions> getInsertionsByYearOrderTenants(int year)
        {

            List<dal.Insertions> insertions = new List<dal.Insertions>();
            List<common.Insertions> a = new List<common.Insertions>();
            using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
            {

                var listMain = VaadBayitEntities.Insertions.Where(x => x.Date.Value.Year == year).ToList();
                var listOrderTenant = listMain.OrderBy(x => x.Tenants).ToList();

                foreach (var item in insertions)
                {
                    var i = Mapper.Casting(item);
                    a.Add(i);
                }
            }
            return a; }
    }
    //public static List<common.Insertions> GetInsertions(int id)
    //{

    //    List<dal.Insertions> insertions = new List<dal.Insertions>();
    //    List<common.Insertions> a = new List<common.Insertions>();
    //    using (VaadBayitEntities VaadBayitEntities = new VaadBayitEntities())
    //    {

    //        var listMain = VaadBayitEntities.Insertions.Where(x => x.Date.Value.Year == id).ToList();
    //        var listOrderTenant = listMain.OrderBy(x => x.Tenants).ToList();

    //        foreach (var item in insertions)
    //        {
    //            var i = Mapper.Casting(item);
    //            a.Add(i);
    //        }
    //    }
    //    return a;


    //}
}
