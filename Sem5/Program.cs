// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Пример
// 4 3 1 (1,2) => 9
// 2 6 9 


// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();

//     }
// }

// void ReleaseArray(int[,] array)
// {
//     Console.WriteLine("Введите номер строки: ");
//     int n1 = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Введите номер столбца: ");
//     int n2 = int.Parse(Console.ReadLine()!);
//     if (n1  >= array.GetLength(0) || n2 >= array.GetLength(1)) 
//      Console.WriteLine("Такого элемента нет");
//     else Console.WriteLine(array[n1 , n2 ]);
// }

// Console.Clear();
// int[,] array = new int[6, 4];
// CreateArray(array);
// PrintArray(array);
// ReleaseArray(array);



//........................................................................................................




// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// Пример
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1


// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();

//     }
// }

// void ReleaseArray(int[,] array)
// {

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[0, j] = array[0, j] + array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = array[0, j] - array[array.GetLength(0) - 1, j];
//         array[0, j] = array[0, j] - array[array.GetLength(0) - 1, j];
//     }

// }

// Console.Clear();
// int[,] array = new int[3, 3];
// CreateArray(array);
// PrintArray(array);

// ReleaseArray(array);
// Console.WriteLine();
// PrintArray(array);

//........................................................................................................


// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

// Пример

// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 11);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();

//     }
// }

// int ReleaseMatrix(int[,] array)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++) sum +=array[0,j];
//     int min = sum;
//     int k = 0;
//     Console.WriteLine(sum);


//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum +=array[i,j];
//         }
//         Console.WriteLine(sum);
//         if (min > sum)
//         {
//             min = sum;
//             k = i;
//         }
//     }
//     return (k);
// }

// Console.Clear();
// Console.WriteLine("Введите размер матрицы: ");
// int[] size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine();

// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// int min = ReleaseMatrix(matrix);
// Console.WriteLine("Наименьшая сумма в строке № " + (min+1) ); 
