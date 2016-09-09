using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        PictureBox pBox = new PictureBox(); //Картинка - вырезаемая область
        private int begin_x;
        private int begin_y;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                begin_x = e.X;
                begin_y = e.Y;
                pBox.Left = e.X;
                pBox.Top = e.Y;
                pBox.Height = 0;
                pBox.Width = 0;
                pBox.Visible = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pBox.Width = 0;
            pBox.Height = 0;
            pBox.Visible = false;
            Rectangle rectangle = new Rectangle(begin_x, begin_y, e.X - begin_x, e.Y - begin_y);
            Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(pictureBox1.Image, 0, 0, rectangle, GraphicsUnit.Pixel);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pBox.Width = e.X - begin_x;
                pBox.Height = e.Y - begin_y;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox.Parent = pictureBox1; //Делаем нашей картинке приёмнику родителем картинку источник
            pBox.BackColor = Color.Transparent; //Делаем прозрачным
            pBox.SizeMode = PictureBoxSizeMode.AutoSize; //Меняем свойства
            pBox.BorderStyle = BorderStyle.FixedSingle; //Меняем бордюр
            pBox.Visible = false; //Прячем
        }
    }
}
