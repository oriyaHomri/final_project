using common;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
   public static class ManegerFrequencyObject
    {
        public static List<common.FrequencyObject> GetFrequencyObjects()
        {
            var a = dal.FrequencyObject.get();
            List<common.FrequencyObject> FrequencyObject = new List<common.FrequencyObject>();
            foreach (var item in a)
            {
                var i = Mapper.Casting(item);
                FrequencyObject.Add(i);
            }
            return FrequencyObject;
                
        }
        public static void addFrequencyObject(common.FrequencyObject t)
        {
            dal.FrequencyObject.Add(t);
        }
        public static void remove(int id)
        {
            dal.FrequencyObject.Remove(id);
        }
        public static void Update(int id,string s)
        {
          //  dal.FrequencyObject.Update(id,s);
        }

    }
}
