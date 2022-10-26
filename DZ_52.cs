// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//================================================================================================================

//Решение:

// Console.WriteLine("Ведите количество строк массива");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ведите количество столбцов массива");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 1, 9);

// PrintArray(array);

// double[] array2 = ArithmeticMeanArrayColums(array);

// Console.Write($"Среднее арифметическое каждого столбца: ");

// PrintArray2(array2);

// void PrintArray(int[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray2(double[] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]}; ");
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

// double[] ArithmeticMeanArrayColums(int[,] array){
//     double[] result = new double[array.GetLength(1)];
//     for(int i = 0; i < array.GetLength(1); i++){
//         double sum = 0;
//         for(int j = 0; j < array.GetLength(0); j++){
//             sum += array[j,i];
//         }
//         double arithmeticMean = sum / array.GetLength(0);
//         result[i] = Math.Round(arithmeticMean, 1);
//     }
//     return result;
// }

//================================================================================================================