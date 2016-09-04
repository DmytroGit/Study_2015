using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication64.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public static List<TestModel> GetArray()
        {
            List<TestModel> testModel = new List<TestModel>();

            testModel.Add(new TestModel() { Id = 1, ProductName = "prod1" });
            testModel.Add(new TestModel() { Id = 2, ProductName = "prod2" });
            testModel.Add(new TestModel() { Id = 3, ProductName = "prod3" });
            testModel.Add(new TestModel() { Id = 4, ProductName = "prod4" });
            testModel.Add(new TestModel() { Id = 5, ProductName = "prod5" });
            testModel.Add(new TestModel() { Id = 6, ProductName = "prod6" });
            testModel.Add(new TestModel() { Id = 7, ProductName = "prod7" });
            testModel.Add(new TestModel() { Id = 8, ProductName = "prod8" });
            testModel.Add(new TestModel() { Id = 9, ProductName = "prod9" });
            testModel.Add(new TestModel() { Id = 10, ProductName = "prod10" });
            testModel.Add(new TestModel() { Id = 11, ProductName = "prod11" });
            testModel.Add(new TestModel() { Id = 12, ProductName = "prod12" });
            testModel.Add(new TestModel() { Id = 13, ProductName = "prod13" });
            testModel.Add(new TestModel() { Id = 14, ProductName = "prod14" });
            testModel.Add(new TestModel() { Id = 15, ProductName = "prod15" });
            
            return testModel;
        }
    }
}