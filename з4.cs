using System;

namespace задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Введите длину прямоуголника А");
            A = Convert.ToInt32(Console.ReadLine());//вывод длины А 
            Console.WriteLine("Введите длину прямоугольника В");
            B = Convert.ToInt32(Console.ReadLine());//вывод длины В 
            Console.WriteLine("Введите сторону квадарата");
            C = Convert.ToInt32(Console.ReadLine());//вывод стороны кварата 
            int Spr = A * B;
            int c = (A / C);//нахождение кол-ва сторон С на стороне А 
            int k = (B / C);//нахождение кол-ва сторон B на стороне А 
            int d = c * k;//нахождение кол-ва квадратов, расположенных в прямоугольнике 
            int Skv = d * (C * C);
            int Snez = Spr - Skv;//площадь незанятой части прямоугольника
            Console.WriteLine("Кол-во квадартов:" +d);
            Console.WriteLine("Площадь незанятой части прямоугольника:" + Snez);
            Console.Read();
        }
    }
}
