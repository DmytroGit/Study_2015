using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(@"E:\Login1.txt");
            FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            stream.Close();
        }
    }
}
