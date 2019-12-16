using System;

namespace задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, S;
            Console.WriteLine("Введите номер года");
            N = Convert.ToInt32(Console.ReadLine());//вывод года 
            if (N%100>0)
            {
                S = N / 100 + 1;
            }
            else
            {
                S = N / 100;
            }
            Console.WriteLine("Введённый год относится к столетию:" +S);
            Console.Read();
        }
    }
}
