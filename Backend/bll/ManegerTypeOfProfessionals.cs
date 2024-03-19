using common;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
   public static class ManegerTypeOfProfessionals
    {
        public static List<common.TypeOfProfessionals> GetTypeOfProfessionalss()
        {
            var a = dal.TypeOfProfessionals.get();
            List<common.TypeOfProfessionals> TypeOfProfessionals = new List<common.TypeOfProfessionals>();
            foreach (var item in a)
            {
                var i = Mapper.Casting(item);
                TypeOfProfessionals.Add(i);
            }
            return TypeOfProfessionals;
                
        }
        public static void addTypeOfProfessionals(common.TypeOfProfessionals t)
        {
            dal.TypeOfProfessionals.Add(t);
        }
        public static void remove(int id)
        {
            dal.TypeOfProfessionals.Remove(id);
        }
        public static void Update(int id,string s)
        {
          //  dal.TypeOfProfessionals.Update(id,s);
        }

    }
}
