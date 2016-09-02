using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;

namespace WebApplication53.Filters
{
    public class MyFilterAttribute : FilterAttribute, IActionFilter
    {
        int i = 0;
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            i++;
            var file = new FileStream(@"E:\Login" + i + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
            var writer = new StreamWriter(file, Encoding.GetEncoding(1251));
            writer.WriteLine(DateTime.Now.ToString() + " -- " +
                filterContext.ActionDescriptor.ActionName + " -- " +
                filterContext.Controller);
            //writer.Seek(SeekOrigin.End);
            writer.Close();
        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }
    }
}