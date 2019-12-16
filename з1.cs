using System;

namespace лаб.раб__6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите количество секунд, прошедших с начало суток");
            N = Convert.ToInt32(Console.ReadLine());//вывод количества секунд, прошедших с начала суток
            float b = N % 60;
            
            Console.WriteLine("Вывод количества секунд, прошедших с начала последней минуты:" + b);
            Console.ReadLine();
        }
    }
}
