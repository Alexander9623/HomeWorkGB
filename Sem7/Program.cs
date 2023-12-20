// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// string rec(int n, int m)
// {
//     if (n < m)
//         return "";
//     return rec(n - 1, m) + $"{n} ";
// }


// Console.Clear();
// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(rec(n, m));

// ...............................................



// Задача 2
// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// // Пример
// m = 2, n = 3 -> A(m,n) = 29


// int rec(int m, int n)
// {
//     if (m == 0)
//         return (n + 1);
//     if (m > 0 && n == 0)
//         return (rec(m - 1, 1));
//     if (m > 0 && n > 0)
//         return (rec(m - 1, rec(m, n - 1)));
//     return rec(m, n);
// }


// Console.Clear();
// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(rec(m, n));

//..........................................................................

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11);
// }


// void rec(int[] array, int arrLength)
// {
//     if (arrLength == 0) return;
//     Console.Write($"{array[arrLength - 1]} \t");
//     rec(array, (arrLength - 1));
// }


// Console.Clear();
// Console.Write("Введите колличество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// FillArray(array);
// Console.WriteLine(string.Join("\t", array));
// rec(array, array.Length);
