using ConsoleApplication3.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime NameStart = DateTime.Parse("2000-10-10");
            DateTime NameFinish = DateTime.Parse("2016-03-03");

            CustomersOrdersProducts_DBEntities context = new CustomersOrdersProducts_DBEntities();
            var newContext = context.Orders.ToList();
            
            //Количество продаж
            var qyeryCountOrdersProducts = newContext
                .Where(emp => emp.DateOrder >= NameStart)
                .Where(emp => emp.DateOrder <= NameFinish)
                .Select(emp => emp.CountProduct)
                .Sum();

            //Количество записей
            var qyeryCountOrders = newContext
                .Where(emp => emp.DateOrder >= NameStart)
                .Where(emp => emp.DateOrder <= NameFinish)
                .Select(emp => emp.Id)
                .Count();

            //Количество продаж
            var qyerySumPriceProducts = newContext
                .Where(emp => emp.DateOrder >= NameStart)
                .Where(emp => emp.DateOrder <= NameFinish)
                .Select(emp => emp.CountProduct * emp.Products.Price)
                .Sum();


            Console.WriteLine("Количество продаж: {0}\nСумма с продаж: {1}\nКоличество ордеров: {2}", qyeryCountOrdersProducts, qyerySumPriceProducts, qyeryCountOrders);
            
            Console.ReadKey();
        }
    }
}
