using common;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
   public static class ManegerTypeOfTasks
    {
        public static List<common.TypeOfTasks> GetTypeOfTaskss()
        {
            var a = dal.TypeOfTasks.get();
            List<common.TypeOfTasks> TypeOfTasks = new List<common.TypeOfTasks>();
            foreach (var item in a)
            {
                var i = Mapper.Casting(item);
                TypeOfTasks.Add(i);
            }
            return TypeOfTasks;
                
        }
        public static void addTypeOfTasks(common.TypeOfTasks t)
        {
            dal.TypeOfTasks.Add(t);
        }
        public static void remove(int id)
        {
            dal.TypeOfTasks.Remove(id);
        }
        public static void Update(int id,string s)
        {
            //dal.TypeOfTasks.Update(id,s);
        }

    }
}
