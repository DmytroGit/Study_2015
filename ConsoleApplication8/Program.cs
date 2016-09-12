using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажми любую кнопку чтобы сделать скрин экрана");
            Console.ReadKey();

            Graphics graph = null;

            var bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            graph = Graphics.FromImage(bmp);

            //здесь берем изображение из заданных координат(x start, y start, x dist, y dist)
            graph.CopyFromScreen(0, 0, 0, 0, bmp.Size);

            bmp.Save("filename.jpg");
        }
    }
}
