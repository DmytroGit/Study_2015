using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        PictureBox pic = new PictureBox(); //Картинка - вырезаемая область.
        private int begin_x;
        private int begin_y; //Координаты картинки на исходном pictureBox.
        bool resize = false; //Эта специальная переменная уберегающая от случайных нажатий мышкой по изображению.
        private int scroller_vert = -1;
        private int scroller_hor = -1; //Включение выключение скроллинга - таймер проверяет эти значения и посылает сообщения на смещение ScrollBar-ов.


        public Form1()
        {
            InitializeComponent();
        }

        //[DllImport("user32.dll")]
        //public static extern int SendMessage(
        //       int hWnd,      // handle to destination window
        //       uint Msg,       // message
        //       long wParam,  // first message parameter
        //       long lParam   // second message parameter
        //       );

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pic.Width = e.X - begin_x;
                pic.Height = e.Y - begin_y;

                //Скроллинг...
                scroller_hor = -1;
                scroller_vert = -1;

                if (e.X > panel2.Width - 5)
                { scroller_hor = 0; }

                if (e.Y > panel2.Height - 5)
                { scroller_vert = 0; }


            }
        }

        static public Image Copy(Image srcBitmap, Rectangle section)
        {
            // Вырезаем выбранный кусок картинки
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                //g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            }
            //Возвращаем кусок картинки.
            return bmp;
        }

        //И вот сам таймер для скроллинга.

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (scroller_vert > -1)
            //{
            //    SendMessage(panel2.Handle.ToInt32(), 277, 1, scroller_vert);
            //}
            //if (scroller_hor > -1)
            //{
            //    SendMessage(panel2.Handle.ToInt32(), 276, 1, scroller_hor);
            //}
        }

        //При загрузке формы (но это не обязательно - это у меня так) 
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;


            //Делаем нашей картинке приёмнику родителем картинку источник.
            pic.Parent = pictureBox1;
            //Теперь делаем её прозрачной но задаём ей рамку BorderStyle.
            pic.BackColor = Color.Transparent;
            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                begin_x = e.X;
                begin_y = e.Y;
                pic.Left = e.X;
                pic.Top = e.Y;
                pic.Width = 0;
                pic.Height = 0;
                pic.Visible = true;
                timer1.Start();
                resize = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            pic.Width = 0;
            pic.Height = 0;
            pic.Visible = false;
            timer1.Stop();
            if (resize == true)
            {
                if ((e.X > begin_x + 10) && (e.Y > begin_y + 10)) //Чтобы совсем уж мелочь не вырезал - и по случайным нажатиям не срабатывал! (можно убрать +10)
                {
                    Rectangle rec = new Rectangle(begin_x, begin_y, e.X - begin_x, e.Y - begin_y);
                    pictureBox2.Image = Copy(pictureBox1.Image, rec);
                }
            }
            resize = false;
        }
    }
}
