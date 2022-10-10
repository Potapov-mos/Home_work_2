//                       Задача 10:

//  Напишите программу, которая принимает на вход трёхзначное число,
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
    Console.WriteLine("Вы ввели не трёхзначное число");
else
{
    int firstDigit = number / 100;
    int twoDigit = number * 10 / 100;

    int twoNumber = twoDigit - firstDigit * 10;

    Console.Write($"Вторая цифра введённого числа: {twoNumber}");
}


