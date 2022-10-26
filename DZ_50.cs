// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

//================================================================================================================

//Решение:

// Console.WriteLine("Ведите количество строк массива");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ведите количество столбцов массива");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 1, 9);
// PrintArray(array);

// Console.WriteLine($"Для доступа к нужному элементу массива укажите строку от 0 до {rows - 1}.");
// int rowsElement = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Для доступа к нужному элементу массива укажите столбец от 0 до {columns - 1}.");
// int columnsElement = int.Parse(Console.ReadLine()!);
// CheckAnswerArrayElement(rowsElement, columnsElement, array);

// void PrintArray(int[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int [,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void CheckAnswerArrayElement(int i, int j, int[,] array){
//     if ((i > array.GetLength(0)) || (j > array.GetLength(1))){
//         Console.WriteLine($"i = {i}, j = {j} -> такого числа в массиве нет");
//     } else {
//         Console.WriteLine($"i = {i}, j = {j} -> {array[i,j]}");
//     }
// }

//================================================================================================================