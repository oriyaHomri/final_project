using common;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public static class ManegerExpenses
    {
        public static IEnumerable<common.Expenses> GetExpensess()
        {
            var a = dal.Expenses.get();

            List<common.Expenses> expenses = new List<common.Expenses>();
            foreach (var item in a)
            {
                var i = Mapper.Casting(item);
                expenses.Add(i);
            }
            return expenses;

        }
        public static void addExpenses(common.Expenses t)
        {
            dal.Expenses.Add(t);
        }
        public static void remove(int id)
        {
            dal.Expenses.Remove(id);
        }
        public static void Update(common.Expenses e)
        {
            dal.Expenses.Update(e);
        }
        public static int getId()
        {
            return dal.Expenses.getId();
        }
    }
}

