using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication74.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<TestModel> GetList
        {
            get
            {
                List<TestModel> list = new List<TestModel>();

                list.Add(new TestModel { Id = 1, Name = "Test1" });
                list.Add(new TestModel { Id = 2, Name = "Test2" });
                list.Add(new TestModel { Id = 3, Name = "Test3" });
                list.Add(new TestModel { Id = 4, Name = "Test4" });

                return list;
            }
        }
    }
}