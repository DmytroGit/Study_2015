using ConsoleApplication4.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersOrdersProducts_DBEntities context = new CustomersOrdersProducts_DBEntities();
            var newContext = context.Orders.ToList();
            
            //Количество продаж по пользователю
            var qyerySumOrdersCustomer = newContext
                .Where(emp => emp.Customers.FirstName.Trim() == "Катя")
                
                .Select(emp => emp.CountProduct).Sum();

            Console.WriteLine("Количество продаж: {0}", qyerySumOrdersCustomer);
            
            Console.ReadKey();
        }
    }
}
