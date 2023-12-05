// // Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// // Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int size = 10;
// int[] array = new int[size]; // Массив на 10 элементов, заполнен 
// // массив нулями 
// int count = 0; // Количество чисел в диапазоне 
// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(1, 101); 
//     if (array[i] >= 20 && array[i] <= 90) // [20, 90]
//     {
//         count++; // count = count + 1 (инкремент)
//     }
// }
// Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
// Console.WriteLine($"Количество чисел в диапазоне [20;90]: {count}");



// // Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
// // которая определяет количество чётных чисел в массиве.

// int size = 10;
// int[] array = new int[size];
// int count = 0; 
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 11); 
//     if (array[i] % 2 ==0)
//     {
//         count++; 
//     }
// }
// Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
// Console.WriteLine($"Количество чисел в диапазоне [0;10]: {count}");


// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной 
// частью. Найдите разницу между максимальным и минимальным элементов массива.


// int size = 10;
// double[] array = new double[size];
// for (int i = 0; i < size; i++)
// {
//     // Math.Round(число, кол-во знаков)
//     array[i] = Math.Round(new Random().NextDouble() * 100, 2);
// }
// Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
// double max = array[0]; // Пусть максимум и минимум - первый эл. массива
// double min = array[0];
// for (int i = 0; i < size; i++)
// {
//     // 5 > 1, min = array[i]
//     if (min > array[i]) 
//     {
//         min = array[i];
//     }
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.WriteLine($"Max: {max}, min: {min}");
// Console.WriteLine($"Result: {max - min}");
