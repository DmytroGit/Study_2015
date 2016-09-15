using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication89.Views.Home
{
    public class ClassA
    {
        public int a { get; set; }

        public void MyFunct(int a, int d, int b = 0, int e = 0, int c = 0, int g = 0, int h = 0)
        {
            this.a = a;
        }
    }

    public class ClassB
    {
        public int a { get; set; }

        public void MyFunct(int a, int d, int b = 0, int e = 0, int c = 0, int g = 0, int h = 0)
        {
            this.a = a;
        }
    }

    public class ClassC
    {
        public int a { get; set; }

        public void MyFunct1(int a, int d, int b = 0, int e = 0, int c = 0, int g = 0, int h = 0)
        {
            this.a = a;
        }
        public void MyFunct2(int a, int d, int b = 0, int e = 0, int c = 0, int g = 0, int h = 0)
        {
            this.a = a;
        }
        public void MyFunct3(int a, int d, int b = 0, int e = 0, int c = 0, int g = 0, int h = 0)
        {
            this.a = a;
        }
    }
}