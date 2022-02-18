using System;

namespace _2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Переменные
            int SizeMass=0; // Размер массива
            int Min = 0, Max = 0; // Минимальне максимальное значение
            int MaxI = 0 , MinI = 0;
            Random rnd = new Random(); // Рандом
            // Ввод данных
            bool On = false;
            while (On == false) // Цикл для того чтобы пока не ввели правильно число программа не закончилась
            {
                Console.Write("Введите размер массива SizeMass=");
                string num = Console.ReadLine();
                On = int.TryParse(num, out SizeMass); // Пробуем конвертировать string в int
                if (On == false) // Проверка для вывода ошибки в консоль
                {
                    Console.WriteLine("Не правильно. Попробуй ещё раз.");
                }
                else
                {
                    if (SizeMass <= 0)
                    {
                        On = false;
                        Console.WriteLine("Не правильно. Попробуй ещё раз.");
                    }
                }

            }

            int[] mass = new int[SizeMass];
            // Генерация массива
            for (int i = 0; i < SizeMass; i++)
            {
                mass[i] = rnd.Next(0, 100);
            }
            // Вывод массива
            Console.WriteLine("Ваш массив размером {0}:",SizeMass);
            Console.WriteLine();
            for (int i = 0; i < SizeMass; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine();
            // Поиск максимального значения
            for (int i = 0; i < SizeMass; i++)
            {
                if (mass[i] > Max)
                {
                    Max = mass[i];
                    MaxI = i;
                }
            }
            Console.WriteLine("Максимальное значение {0}. Стоит под индектом {1}", Max,MaxI+1);
            // Поиск минимального значения
            Min = Max;
            for (int i = 0;i < SizeMass; i++)
            {
                if (mass[i] < Min)
                {
                    Min = mass[i];
                    MinI = i;
                }
            }
            Console.WriteLine("Минимальное значение {0}. Стоит под индектом {1}",Min,MinI+1);
            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine();
            mass[MaxI] = Min;
            mass[MinI] = Max;
            for (int i = 0;i<SizeMass ; i++)
            {
                Console.Write(mass[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine("Разность между {0} и {1} равна {2}",Max,Min,Max-Min);
        }
    }
}
