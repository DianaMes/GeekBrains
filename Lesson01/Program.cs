// // Получить число и возвести его в квадрат

// // тип_данных имя_переменной = значение;

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 

// int result = number * number;
// // "1" + "2" = "12" (конкатенация - процесс сложения строк)
// // "Число " + "5" + " в квадрате = " + "25" 
// Console.WriteLine("Число " + number + " в квадрате = " + result);

// if (number*number == result)
// {
//    Console.WriteLine("+");
// }
// else
// {
//     Console.WriteLine("-");
// }


// Console.WriteLine("Введите номер дня недели: ");
// int numberOfDays = Convert.ToInt32(Console.ReadLine());
// if (numberOfDays >= 1 && numberOfDays <= 7)
// {
//     if (numberOfDays == 1)
//     {
//         Console.WriteLine("Monday");
//     }
//     if (numberOfDays == 2)
//     {
//         Console.WriteLine("Tuesday");
//     }
// }
// else 
// {
//     Console.WriteLine("Некорретный ввод");
// }



// // Задание 1.
// Console.Clear();
// // char[] chars = {'a', 'b', 'c', 'd'};
// Console.Write("Введите символы через пробел: ");
// char[] chars = Console.ReadLine()!.Split().Select(x => char.Parse(x)).ToArray();
// /*
// 1. "a b 1 2 3 4 6 c d e"
// 2. ["a", "b", "1", "2", "3", "4", "6", "c", "d", "e"]
// 3. 'a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e'
// 4. ['a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e']
// */
// string result = string.Empty; // создание пустой строки
// // string result = "";
// foreach (char element in chars){
//     result = result + element;
// }
// Console.WriteLine(result);



//  Задание 1:Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }


// Задание 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координаты точки X ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки Y ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0)
// {
//     Console.WriteLine("1");
// }
// if (x<0 && y>0)
// {
//     Console.WriteLine("2");
// }
// if (x<0 && y<0)
// {
//     Console.WriteLine("3");
// }
// if (x>0 && y<0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Точка находится на оси координат");
// }


// Задание 3:Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 9 && number < 100) // [10;99]
// {
//     int firstDigit = number / 10; // 12 / 10 => 1
//     int secondDigit = number % 10; // 12 % 10 => 2
//     int maxDigit = firstDigit; // Пусть максимум - 1
//     if (secondDigit > maxDigit) //  2 > 1, max = 2
//     {
//         maxDigit = secondDigit;
//     }
//     Console.WriteLine($"Максимальная цифра в числе {number} => {maxDigit}");
// }
// // $"Текст {переменная} текст"
// else
// {
//     Console.WriteLine("Вы ввели некорректное число :( ");
// }


// Задание 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string digits = String.Empty; // " "
// while (number > 0)
// {
//     digits = number % 10 + " , " + digits;
//     number = number / 10;
// }
// Console.WriteLine(digits);


// // Задание 1.(Семинар 6)
// Console.Clear();
// // char[] chars = {'a', 'b', 'c', 'd'};
// Console.Write("Введите символы через пробел: ");
// char[] chars = Console.ReadLine()!.Split().Select(x => char.Parse(x)).ToArray();
// /*
// 1. "a b 1 2 3 4 6 c d e"
// 2. ["a", "b", "1", "2", "3", "4", "6", "c", "d", "e"]
// 3. 'a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e'
// 4. ['a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e']
// */
// string result = string.Empty; // создание пустой строки
// // string result = "";
// foreach (char element in chars){
//     result = result + element;
// }
// Console.WriteLine(result);

// //Задание 2

// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// char[] chars = new char[initial.Length];
// // Hello
// // 01234
// for (int i = 0; i < initial.Length; i++){
//     chars[i] = initial[i];
// }
// Console.WriteLine($"Результат: [{string.Join(" ", chars)}]");


// // Задание 3
// // Считать строку с консоли, состоящую из латинских
// // букв в нижнем регистре. Выяснить, сколько среди
// // введённых букв гласных.
// // Пример
// // “hello” => 2
// // “world” => 1

// bool is_vowels(char el, char[] chars){
//     foreach (char x in chars){
//         if (x == el)
//             return true;
//     }
//     return false;
// }

    
// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// char[] chars = {'a', 'e', 'u', 'i', 'o', 'y'};
// int count = 0;
// for (int i = 0; i < initial.Length; i++){
//     if (is_vowels(initial[i], chars))
//         count++;
// }
// Console.WriteLine(count);

// //variant 2

// bool is_vowels(char el, string vowels){
//     for (int i = 0; i < vowels.Length; i++){
//         if (vowels[i] == el)
//             return true;
//     }
//     return false;
// }
// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// string vowels = "aeuioy";
// int count = 0;
// for (int i = 0; i < initial.Length; i++){
//     if (is_vowels(initial[i], vowels))
//         count++;
// }
// Console.WriteLine(count);