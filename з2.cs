using System;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int K; // переменная, в которой хранится значение дня года

            Console.WriteLine("Введите номер дня года (от 1 до 365): "); 
            K = Convert.ToInt32(Console.ReadLine()); // вывод числа

            while (K > 6)
            {
                K -= 7;
            } 
            Console.WriteLine("День недели: " + K);
            Console.ReadLine();
        }
    }
}
