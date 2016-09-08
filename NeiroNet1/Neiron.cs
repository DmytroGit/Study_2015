using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeiroNet1
{

    // это класс нейрона, каждый нейрон хранит в себе массив определённого образа
    // он может обучаться и сравнивать значение с имеющимся в памяти

    public class Neiron
    {
        public string name; // имя - текстовое значение образа который хранит нейрон
        public double[,] veight; // массив весов - именно это и есть память нейрона
        public int countTrainig; // количество вариантов образа в памяти
                                 // нужно для правильного пересчёта весов при обучении

        // конструктор
        public Neiron()
        {

        }

        // получить имя
        public string GetName()
        {
            return this.name;
        }

        // очистить память нейрона и присвоить ему новое имя
        public void Clear(string name, int x, int y)
        {
            this.name = name;
            this.veight = new double[x, y];

            for (int n = 0; n < this.veight.GetLength(0); n++)
            {
                for (int m = 0; m < this.veight.GetLength(1); m++)
                {
                    this.veight[n, m] = 0;
                }
            }

            this.countTrainig = 0;
        }

        // функция возвращает сумму величин отклонения входного массива от эталонного
        // другими словами чем результат ближе к 1це тем больше похож входной массив 
        // на образ из памяти нейрона
        public double GetRes(int[,] data)
        {
            if (this.veight.GetLength(0) != data.GetLength(0) || this.veight.GetLength(1) != data.GetLength(1))
            {
                return -1;
            }

            double res = 0;

            for (int n = 0; n < this.veight.GetLength(0); n++)
            {
                for (int m = 0; m < this.veight.GetLength(1); m++)
                {
                    // в этой строке мы считаем отклонения 
                    // каждого элемента входного массива от 
                    // усреднённого значения из памяти
                    res += 1 - Math.Abs(this.veight[n, m] - data[n, m]);
                }
            }

            // возвращем среднее арифметическое отклонение по массиву
            // на самом деле эта операция не обязательная
            // но в теории должна дать лучшую стабильность
            // при большом количестве образов
            return res / (this.veight.GetLength(0) * this.veight.GetLength(1));
        }

        // добавить входной образ в память массива
        public int Training(int[,] data)
        {
            // проверим что массив существует и тех же размеров что и массив памяти
            if (data == null || veight.GetLength(0) != data.GetLength(0) || veight.GetLength(1) != data.GetLength(1))
            {
                return countTrainig;
            }

            this.countTrainig++;

            for (int n = 0; n < this.veight.GetLength(0); n++)
            {
                for (int m = 0; m < this.veight.GetLength(1); m++)
                {
                    // на всякий случай приведём значение элемента входного массива к дискретному
                    double v = data[n, m] == 0 ? 0 : 1;

                    // вот сейчас будет самая главная строчка
                    // каждый элемент в памяти пересчитывается с учетом значения из data
                    this.veight[n, m] += 2 * (v - 0.5f) / this.countTrainig;

                    if (this.veight[n, m] > 1)
                    {
                        this.veight[n, m] = 1;// значение памяти не может быть больше 1
                    }
                    if (this.veight[n, m] < 0)
                    {
                        this.veight[n, m] = 0;// значение памяти не может быть меньше 0
                    }
                }
            }

            return this.countTrainig; // вернуть количество обучений
        }
    }
}