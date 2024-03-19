using common;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
   public static class ManegerTasks
    {
        public static List<common.Tasks> GetTaskss()
        {
            var a = dal.Tasks.get();
            List<common.Tasks> Tasks = new List<common.Tasks>();
            foreach (var item in a)
            {
                var i = Mapper.Casting(item);
                Tasks.Add(i);
            }
            return Tasks;
                
        }
        public static void addTasks(common.Tasks t)
        {
            dal.Tasks.Add(t);
        }
        public static void remove(int id)
        {
            dal.Tasks.Remove(id);
        }
        public static void Update(common.Tasks s)
        {
            dal.Tasks.Update(s);
        }

    }
}
