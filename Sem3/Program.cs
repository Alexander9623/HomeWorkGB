//Задача 1: Задайте одномерный массив из 10 целых
//чисел от 1 до 100. Найдите количество элементов
//массива, значения которых лежат в отрезке [20,90].
//Пример
//массив [10 21 14 93 23] => 2

// Console.Clear();
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);

// Console.WriteLine(string.Join(", ", array));

// int x = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 20 && array[i] <= 90)
//     {
//         x++;
//     }
// }
// Console.Write(x);

//..........................................................

//Задача 2: Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет
//количество чётных чисел в массиве.

// Console.Clear();
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);

// Console.WriteLine(string.Join(", ", array));

// int x = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         x++;
//     }
// }
// Console.Write(x);

//...................................................................

// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.

// Console.Clear();
// double[] array = new double[5];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 100) + Math.Round(new Random().NextDouble(),2);
// Console.WriteLine(string.Join("   ", array));

// double max = array[0];
// double min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     max = array[i];

//      if (array[i] < min)
//     min = array[i];
// }
// Console.WriteLine(max - min);
