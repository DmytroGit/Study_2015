using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //задаем интервал таймера 1 секунда
            timer1.Interval = 1000;
        }

        //для кнопки "запустить таймер"
        private void buttonScaning_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //для кнопки "останов таймера"
        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        //это выполняет таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetElementsFromTable();
        }
        
        //берет элементы со стола и помещает их в интерфейс моей проги
        private void GetElementsFromTable()
        {
            Graphics graph1 = null;
            Graphics graph2 = null;
            Graphics graph3 = null;
            Graphics graph4 = null;
            Graphics graph5 = null;
            Graphics graph6 = null;//фолд
            Graphics graph7 = null;//кол / чек
            Graphics graph8 = null;//увеличить   

            var bmp1 = new Bitmap(60, 85);
            var bmp2 = new Bitmap(60, 85);
            var bmp3 = new Bitmap(60, 85);
            var bmp4 = new Bitmap(60, 85);
            var bmp5 = new Bitmap(60, 85);
            var bmp6 = new Bitmap(195, 45);//фолд
            var bmp7 = new Bitmap(195, 45);//кол / чек
            var bmp8 = new Bitmap(195, 45);//увеличить     


            graph1 = Graphics.FromImage(bmp1);
            graph2 = Graphics.FromImage(bmp2);
            graph3 = Graphics.FromImage(bmp3);
            graph4 = Graphics.FromImage(bmp4);
            graph5 = Graphics.FromImage(bmp5);
            graph6 = Graphics.FromImage(bmp6);//фолд
            graph7 = Graphics.FromImage(bmp7);//кол / чек
            graph8 = Graphics.FromImage(bmp8);//увеличить

            //здесь берем изображение из заданных координат(x start, y start, x dist, y dist)
            graph1.CopyFromScreen(347, 220, 0, 0, bmp1.Size);
            graph2.CopyFromScreen(420, 220, 0, 0, bmp2.Size);
            graph3.CopyFromScreen(490, 220, 0, 0, bmp3.Size);
            graph4.CopyFromScreen(563, 220, 0, 0, bmp4.Size);
            graph5.CopyFromScreen(630, 220, 0, 0, bmp5.Size);
            graph6.CopyFromScreen(428, 582, 0, 0, bmp6.Size);//фолд
            graph7.CopyFromScreen(632, 582, 0, 0, bmp7.Size);//кол / чек
            graph8.CopyFromScreen(840, 582, 0, 0, bmp8.Size);//увеличить  

            bmp1.Save("filename1.jpg");
            bmp2.Save("filename2.jpg");
            bmp3.Save("filename3.jpg");
            bmp4.Save("filename4.jpg");
            bmp5.Save("filename5.jpg");
            bmp6.Save("filename6.jpg");//фолд
            bmp7.Save("filename7.jpg");//кол / чек
            bmp8.Save("filename8.jpg");//увеличить    

            pictureBoxCart1OnTable.Image = bmp1;
            pictureBoxCart2OnTable.Image = bmp2;
            pictureBoxCart3OnTable.Image = bmp3;
            pictureBoxCart4OnTable.Image = bmp4;
            pictureBoxCart5OnTable.Image = bmp5;
            pictureBoxFold.Image = bmp6;//фолд
            pictureBoxCallCheck.Image = bmp7; //кол / чек
            pictureBoxUpper.Image = bmp8; //увеличить  
        }
    }
}
