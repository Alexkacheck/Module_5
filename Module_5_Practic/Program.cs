using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Practic
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Вызываем метод DoSomething, который может сгенерировать исключение
                DoSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }

        static void DoSomething()
        {
            Console.WriteLine("Начало выполнения метода DoSomething.");

            // Генерируем исключение
            throw new Exception("Произошла ошибка в методе DoSomething.");

            Console.WriteLine("Этот код не будет выполнен.");
        }
    }
}