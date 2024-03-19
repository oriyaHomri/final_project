using common;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
   public static class ManegerFrequencies
    {
        public static List<common.Frequencies> GetFrequenciess()
        {
            var a = dal.Frequencies.get();
            List<common.Frequencies> Frequencies = new List<common.Frequencies>();
            foreach (var item in a)
            {
                var i = Mapper.Casting(item);
                Frequencies.Add(i);
            }
            return Frequencies;

        }
        public static void addFrequencies(common.Frequencies t)
        {
            dal.Frequencies.Add(t);
        }
        public static void remove(int id)
        {
            dal.Frequencies.Remove(id);
        }
        public static void Update(common.Frequencies frequencies)
        {
            var f = Mapper.Casting(frequencies);
            dal.Frequencies.Update(f);
        }


    }
}
