using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Задача 1: Перехватываем исключение запроса к несуществующему веб-ресурсу
                try
                {
                    RequestToNonExistentResource(); //это метод, который делает симуляцию запроса к несуществующему вебресурсу
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }

                // Задача 2: Обращение к элементам массива
                try
                {
                    AccessArrayOutOfBounds();//это метод, который позволяет продемонстрировать обработку исключения  обратиться к элементу массива по индексу
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }

                // Задача 3: Вызов метода с генерацией исключения
                try
                {
                    CallMethodWithException(); //вызывает метод GenerateException
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }

                // Задача 4: Вызов метода с генерацией исключения и его обработкой
                try
                {
                    CallMethodWithExceptionHandled();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
            finally
            {
                Console.WriteLine("Завершение программы.");
            }
        }

        static void RequestToNonExistentResource()
        {
            // Задача 1: Попытка выполнить запрос к несуществующему веб-ресурсу
            throw new Exception("Ошибка запроса к веб-ресурсу");
        }

        static void AccessArrayOutOfBounds()
        {
            // Задача 2: Обращение к элементам массива по индексу, выход за пределы массива
            int[] array = { 1, 2, 3 };
            int value = -1;
            try
            {
                value = array[5]; // Попытка обратиться к несуществующему элементу
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
            Console.WriteLine("Завершение обработки массива. Значение: " + value);
        }

        static void CallMethodWithException() //
        {
            // Задача 3: Вызов метода, который генерирует исключение
            GenerateException();
        }

        static void GenerateException()
        {
            throw new Exception("Исключение внутри метода.");
        }

        static void CallMethodWithExceptionHandled()
        {
            // Задача 4: Вызов метода, который генерирует исключение и его обработка
            try
            {
                HandleException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }

        static void HandleException()
        {
            try
            {
                GenerateException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}

