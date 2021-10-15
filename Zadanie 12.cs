using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        /*
        Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
        метод, определяющий длину окружности по заданному радиусу;
        метод, определяющий площадь круга по заданному радиусу;
        метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
        */
        {
            Console.WriteLine("Введите радиус окружности");
            double rad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату х центра окружности");
            double x0point = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату y центра окружности");
            double y0point = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату точки х");
            double xpoint = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату точки y");
            double ypoint = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Длина окружности равна:{0}", Circle.CircleLength(rad));
            Console.WriteLine("Площадь окружности равна:{0}0", Circle.CircleSquare(rad));

            if (Circle.CircleInclude(rad, x0point, y0point, xpoint, ypoint) == true)
            {
                Console.WriteLine("Точка принадлежит площади окружности");
            }
            else
            {
                Console.WriteLine("Точка х выходит за пределы площади окружности");
            }
            Console.ReadKey();
        }
       

        
    }

    public static class Circle
        {
        public static double CircleLength(double radius)
        {
            double length = 2*Math.PI*radius;
            return length;
        }

        public static double CircleSquare(double radius)
        {
            double square = Math.PI * radius * radius;
            return square;
        }

        public static bool CircleInclude(double radius=0, double x0=0, double y0=0,  double x=0, double y=0)
        {
            bool xtr = false;
            bool incl = false;
            bool ytr = false;

            if (x-x0 <=radius)
            {
                xtr = true;
            }
            if (y-y0 < radius)
            {
                ytr = true;
            }
            if (xtr == true && ytr == true)
            {
                incl = true;
                return incl;
            }
            else {
                incl = false;
                return incl;
            }
        }


    }
    }

