using System;

namespace Name
{
    class ClassName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-вл элементов массива...");
            int sizeArr = int.Parse(Console.ReadLine());
            double[] arr = new double[sizeArr];

            for (int i = 0; i < sizeArr; i++)
            {
                Console.WriteLine($"Введите {i++}-й элемент массива..."); i--;
                arr[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Получившийся массив: ");
            for (int i = 0; i < sizeArr; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Задание 1:");
            int num = -1;
            double min = 2000000000;
            for (int i = 0; i < sizeArr; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    num = i;
                }
            }
            Console.WriteLine($"Минимальный элемент массива = {min}\nНомер этого элемента: {++num}\n");

            Console.WriteLine("Задание 2:");
            int num_1 = -1, num_2 = -1;
            for (int i = 0; i < sizeArr; i++)
            {
                if (arr[i] < 0 && num_1 == -1 && num_2 == -1)
                    num_1 = i;
                else if (arr[i] < 0 && num_1 != -1 && num_2 == -1)
                    num_2 = i;
                else if (arr[i] < 0 && num_1 != -1 && num_2 != -1)
                    break;
            }
            if(num_1 == -1 || num_2 == -1)
                Console.WriteLine("Два отрицательных элемента не найдено.\n");
            double sum = 0;
            for (int i = ++num_1; i < num_2; i++)
                sum += arr[i];
            Console.WriteLine($"Сумма элементов между 1-м и 2-м отрицательными эл-ми = {sum}\n");

            Console.Write("Задание 3:\nПреобразование массива таким образом, что эл-ты по модулю < 1 выводятся в начале, а остальные потом: ");
            for (int i = 0; i < sizeArr; i++)
            {
                if(Math.Abs(arr[i]) < 1)
                    Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i < sizeArr; i++)
            {
                if (Math.Abs(arr[i]) >= 1)
                    Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n");

            Console.Write("Задание 4:\nВывод сначала всех эл-в != 0, потом эл-в = 0: ");
            for (int i = 0; i < sizeArr; i++)
            {
                if (arr[i] != 0)
                    Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i < sizeArr; i++)
            {
                if (arr[i] == 0)
                    Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}