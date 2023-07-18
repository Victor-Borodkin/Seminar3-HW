// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;
    
//     if (len == 5)
//     {
//         if (number[0] == number[4] && number[1] == number[3])
//         {
//             Console.WriteLine($"{number} - палиндром");
//         }
//         else
//         {
//             Console.WriteLine($"{number} - не палиндром");
//         }
//     }
//     else
//     {
//         Console.WriteLine($"ОШИБКА: {number} - не является пятизначным числом");
//     }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Double x1, y1, z1, x2, y2, z2, result; 
// Console.WriteLine("Введите кординаты x1, y1 и z1 точки A: ");
// x1 = Convert.ToDouble(Console.ReadLine());
// y1 = Convert.ToDouble(Console.ReadLine());
// z1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите кординаты x2, y2 и z2 точки B: ");
// x2 = Convert.ToDouble(Console.ReadLine());
// y2 = Convert.ToDouble(Console.ReadLine());
// z2 = Convert.ToDouble(Console.ReadLine());

// result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
// Console.Write($"Расстояние между токами A и B равно: {result}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= number)
// {
//     double result = Math.Pow(count, 3);
//     Console.Write(result + ", ");
//     count++;
//     if (count == number)
//     {
//         Console.Write(Math.Pow(number, 3));
//         break;
//     }
// 