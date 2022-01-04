using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle();
            angle.ShowAngle();
            angle.ToDoubleAngle();
            angle.ToRadian();
            Console.ReadKey();
        }
    }
    class Angle
    {
        public int Gradus { set; get; }

        double min;
        public double Min
        {
            set
            {
                if (value <= 60 && 0 <= value)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть от 1 до 60! Будет 0!");
                }
            }
            get
            {
                return min;
            }

        }
        double sec;
        public double Sec
        {
            set
            {
                if (value <= 60 && 0 <= value)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть от 1 до 60! Будет 0!");
                }
            }
            get
            {
                return sec;
            }

        }
        public double DoubleAngle { set; get; }
        public Angle()
        {
            try
            {
                Console.Write("Введите градусы:");
                int gradus = Convert.ToInt32(Console.ReadLine());
                Gradus = gradus;
                Console.Write("Введите минуты:");
                int min = Convert.ToInt32(Console.ReadLine());
                Min = min;
                Console.Write("Введите секунды:");
                int sec = Convert.ToInt32(Console.ReadLine());
                Sec = sec;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}. Значение будет равно 0", ex.Message);
            }

        }
        public void ShowAngle()
        {
            Console.WriteLine("Значение угла в градусах, секундах и минутах {0}°{1}'{2}''", Gradus, Min, Sec);
        }
        public void ToDoubleAngle()
        {
            DoubleAngle = Gradus + (Min + Sec / 60) / 60;
            Console.WriteLine("Значение угла в градусах в десятичной форме: {0:f3}", DoubleAngle);
        }
        public void ToRadian()
        {
            double Radian = DoubleAngle * Math.PI / 180;
            Console.WriteLine("Значение угла в радианах: {0:f3}", Radian);
        }
    }
}
