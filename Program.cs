// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//  Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// Console.Write($"\nОтсортированный массив: ");
// OrderArrayLines(array);
// CreateArray(array);
// WriteArray(array);

// void OrderArrayLines(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; j++)
//             {
//                 if (array[i, k] < array [i, k + 1])
//                 {
//                     int temp = array [i, k + 1];
//                     array[i, k + 1] = array [i, k];
//                     array [i, k] = temp;
//                 }
//             }
//         }
//     }
// }


// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//  Console.WriteLine($"Введите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minsumLine = 0;
// int sumLine = SumLinesElements(array, 0);
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int tempsumLine = SumLinesElements(array, i);
//     if (sumLine > tempsumLine)
//     {
//         sumLine = tempsumLine;
//         minsumLine = i;
//     }
// }
// System.Console.WriteLine($"{minsumLine+1} - строка с наименьшей суммой ({sumLine}) элементов ");

// int SumLinesElements(int[,] array, int i);
// {
//     int sumLine = array [i, 0];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sumLine += array [i, j];
//     }
//     return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//  Console.WriteLine($"Введите размер матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк первой матрицы: ");
// int n = InputNumbers("Введите число столбцов первой и строк второй матрицы : ");
// int p = InputNumbers("Введите число столбцов второй матрицы: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] firstMatrix = new int[m, n];
// CreateArray(firstMatrix);
// System.Console.WriteLine($"Первая матрица:");
// WriteArray(firstMatrix);

// int[,] secondMatrix = new int[n, p];
// CreateArray(secondMatrix);
// System.Console.WriteLine($"Вторая матрица:");
// WriteArray(secondMatrix);

// int[,] resultMatrix = new int[n, p];

// MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
// System.Console.WriteLine($"Произведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
// {
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < firstMatrix.GetLength(1); k++)
//             {
//                 sum += firstMatrix[i,k] * secondMatrix[k,j];
//             }
//             resultMatrix[i,j] = sum;
//         }
//     }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// 
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int n = 4;
// int[,] sqareMatrix = new int [n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//     sqareMatrix[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//     else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//     else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//     else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] / 10 <=0)
//             System.Console.WriteLine($"{array[i,j]} ");
//             else 
//             System.Console.WriteLine($"{array[i,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }