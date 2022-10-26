// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//================================================================================================================

//Решение:

// Console.WriteLine("Ведите количество строк массива");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ведите количество столбцов массива");
// int columns = int.Parse(Console.ReadLine()!);
// double[,] array = GetArray(rows, columns);
// PrintArray(array);

// void PrintArray(double[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] GetArray(int m, int n){
//     double[,] result = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             int sign = new Random().Next(-1, 1);
//             result[i,j] = Math.Round(new Random().NextDouble() * 10, 1);
//             if(sign == -1){
//                 result[i,j] = result[i,j] * sign;
//             }
//         }
//     }
//     return result;
// }

//================================================================================================================