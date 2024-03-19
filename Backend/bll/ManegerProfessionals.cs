using common;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
   public static class ManegerProfessionals
    {
        public static List<common.Professionals> GetProfessionalss()
        {
            var a = dal.Professionals.get();
            List<common.Professionals> Professionals = new List<common.Professionals>();
            foreach (var item in a)
            {
                var i = Mapper.Casting(item);
                Professionals.Add(i);
            }
            return Professionals;

        }
        public static void addProfessionals(common.Professionals t)
        {
            dal.Professionals.Add(t);
        }
        public static void remove(int id)
        {
            dal.Professionals.Remove(id);
        }
        public static void Update(common.Professionals p)
        {
            dal.Professionals.Update(p );
        }

    }
}
