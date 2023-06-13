// Для проверки работы нужной программы нужно выделить код и нажать сочетание кнопок "Ctrl+/",
// далее ввести команду "dotnet run" в терминале

//=================================================================

// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Решение: 


// int m = 3; // количество строк
// int n = 4; // количество столбцов

// double[,] array = new double[m, n];

// Random random = new Random();

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = random.NextDouble() * 100;
//     }
// }

// // Выводим массив в консоль для проверки
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// ================================================

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Решение: 

// Console.Write("Введите строку: ");
// int row = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int columns = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 5;
// int m = 7;
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(10, 99);
//         Console.Write("{0} ", arr[i, j]);
//     }
//     Console.WriteLine();
// }
// if (row < 0 | row > arr.GetLength(0) - 1 | columns < 0 | columns > arr.GetLength(1) - 1)
// {
//     Console.WriteLine("Элемент не существует  ");
// }
// else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[row, columns]);
// }

//=====================================

