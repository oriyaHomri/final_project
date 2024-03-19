using common;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
   public static class ManegerTenants
    {
        public static List<common.Tenants> GetTenantss()
        {
            var a = dal.Tenants.GetTenants();
            //List<common.Tenants> Tenants = new List<common.Tenants>();
            //foreach (var item in a)
            //{
            //    var i = Mapper.Casting(item);
            //    Tenants.Add(i);
            //}
            return a;

        }
        public static void addTenants(common.Tenants t)
        {
            dal.Tenants.Add(t);
        }
        public static void remove(int id)
        {
            dal.Tenants.Delete(id);
        }
        public static void Update(common.Tenants  s)
        {
            dal.Tenants.Update(s);
        }

    }
}
