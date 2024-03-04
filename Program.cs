//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите значение M:");
//         int m = int.Parse(Console.ReadLine());
        
//         Console.WriteLine("Введите значение N:");
//         int n = int.Parse(Console.ReadLine());
        
//         PrintNaturalNumbersInRange(m, n);
//     }

//     static void PrintNaturalNumbersInRange(int start, int end)
//     {
//         if (start > end)
//             return;

//         Console.WriteLine(start);
//         PrintNaturalNumbersInRange(start + 1, end);
//     }
// }


//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число m:");
//         int m = int.Parse(Console.ReadLine());
        
//         Console.WriteLine("Введите число n:");
//         int n = int.Parse(Console.ReadLine());
        
//         int result = AckermannFunction(m, n);
        
//         Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен: {result}");
//     }

//     static int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
        
//         if (n == 0)
//             return AckermannFunction(m - 1, 1);
        
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
// }

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Произвольный массив

//         PrintArrayReversed(array, array.Length - 1);
//     }

//     static void PrintArrayReversed(int[] array, int index)
//     {
//         if (index < 0)
//             return;

//         Console.WriteLine(array[index]);
//         PrintArrayReversed(array, index - 1);
//     }
// }