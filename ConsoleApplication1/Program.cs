using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console1Entities contextEntities = new Console1Entities();
            List<Table> list = contextEntities.Tables.ToList();

            foreach (Table item in list)
            {
                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastNmae + " " + item.Age);
            }
        }
    }
}
