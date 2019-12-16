using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int K; // переменная, в которой хранится значение дня года
            int N;
            Console.WriteLine("Введите номер дня года (от 1 до 365): "); 
            K = Convert.ToInt32(Console.ReadLine()); // вывод числа K
            Console.WriteLine("Введите каким номером недели было 1 января: ");
            N = Convert.ToInt32(Console.ReadLine()); // вывод числа N
            float d=(K + N - 2) % 7 + 1;
            Console.WriteLine("День недели: " + d);
            Console.ReadLine();
        }
    }
}
