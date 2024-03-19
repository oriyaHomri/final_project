using common;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
   public static class ManegerInsertions
    {
        public static List<common.Insertions> GetInsertionss()
        {
            var a=dal.Insertions.get();
            List<common.Insertions> insert = new List<common.Insertions>();
            foreach (var item in a)
            {
                var i = Mapper.Casting(item);
                insert.Add(i);
            }
            return insert;
        }
     
        public static List<common.Insertions> getInsertionsByYearOrderTenants(int year)
        {
            var a=dal.Insertions.getInsertionsByYearOrderTenants(year);
           
            return a;
        }
        public static List<common.Insertions> getInsertionsByTenants(int id)
        {
           // var a
           //dal.Insertions.getInsertionsByTenants(id);
            //List<common.Insertions> insert = new List<common.Insertions>();
            //foreach (var item in a)
            //{
            //    var i = Mapper.Casting(item);
            //    insert.Add(i);
            //}
            return null;
        }
        public static void addInsertions(common.Insertions t)
        {
            dal.Insertions.Add(t);
        }
        public static void remove(int id)
        {
            dal.Insertions.Remove(id);
        }
        public static void Update(common.Insertions i)
        {
            dal.Insertions.Update(i);
        }

    }
}
