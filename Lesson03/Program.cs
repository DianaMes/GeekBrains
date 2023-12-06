// // Задача 4*(не обязательно): Дано натуральное число
// // в диапазоне от 1 до 100 000. Создайте массив,
// // состоящий из цифр этого числа. Старший разряд
// // числа должен располагаться на 0-м индексе
// // массива, младший – на последнем. Размер массива
// // должен быть равен количеству цифр.

// // 425 => [4 2 5]

// Console.Write("Введите число от 1 до 100 000: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number >= 1 && number <= 100000)
// {
//     // Посчитаем количество цифр в числе
//     int count = 0;
//     while (number > 0)
//     {
//         number /= 10; // number = number / 10
//         count++;
//     }
//     Console.WriteLine($"Количество цифр в числе {copyNumber} = {count}");

//     // Создаем массив
//     int[] digits = new int[count]; // Массив, состоящий из count эл, зап. нулями
//                                    // i = 0
//     for (int i = count - 1; i >= 0; i--) // digits.Length
//     {
//         digits[i] = copyNumber % 10; //  425 => [4 2 5]
//         copyNumber /= 10; // copyNumber = copyNumber / 10
//     }
//     Console.WriteLine($"Массив: [ {string.Join("; ", digits)} ]");
// }
// else
// {
//     Console.WriteLine("Error!");
// }



// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

// тип_возр_зн ИмяМетода(параметр1, параметр2)
// {
//    
// }

int[] FillArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]}\t");
    // }
    Console.WriteLine($"Массив: [ {string.Join("; ", arr)} ]");
}

int GetCountEvenElements(int[] arr)
{
    int countEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}

int[] array = FillArray(10, -10, 15);
PrintArray(array);
Console.WriteLine($"Количество четных чисел = {GetCountEvenElements(array)}");



// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

// тип_возр_зн ИмяМетода(параметр1, параметр2)
// {
//    
// }

int[] FillArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]}\t");
    // }
    Console.WriteLine($"Массив: [ {string.Join("; ", arr)} ]");
}

// int GetCountEvenElements(int[] arr)
// {
//     int countEven = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             countEven++;
//         }
//     }
//     return countEven;
// }

int[] array = FillArray(6, 0, 50);
PrintArray(array); // Массив ДО
ReverseArray(array); // Мутация массива
PrintArray(array); // Массив ПОСЛЕ
// Console.WriteLine($"Количество четных чисел = {GetCountEvenElements(array)}");

// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// Семинар 4. Функции
// Пример
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

void ReverseArray(int[] arr)
{
    // i - индекс первого элемента
    // j - индекс последнего элемента
    for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
    {
        int temp = arr[i]; // [10,20,30,40,50], temp = 10
        arr[i] = arr[j]; // arr[0] = arr[4], [50,20,30,40,50]
        arr[j] = temp; // [50,20,30,40,temp], [50,20,30,40,10]
    }
}