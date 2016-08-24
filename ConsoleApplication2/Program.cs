using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            int[] array = { 1, 2, 5, 0 };

            var querySum =
                (from sector in array
                select sector).Sum();

            var queryCount =
                (from sector in array
                 select sector).Count();

            Console.WriteLine("Сумма-{0} Количество-{1}", querySum, queryCount);
            Console.ReadKey();
        }
    }
}
