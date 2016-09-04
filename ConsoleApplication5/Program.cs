using ConsoleApplication5.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //запрос многие ко многим LINQ
            TestMToMEntities context = new TestMToMEntities();
            
            var list = from students in context.Students
                       from courses in students.Courses
                       select new
                       {
                           StudentName = students.Student,
                           CourseName = courses.Course
                       };




            foreach (var item in list)
            {
                Console.WriteLine("Студент = {0} Курс = {1}", item.StudentName, item.CourseName);
            }

            Console.ReadKey();
        }
    }
}
