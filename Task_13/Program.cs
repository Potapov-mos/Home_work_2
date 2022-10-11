//                       Задача 13:

//  Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Write("Введите число не меньше трёх цифр: ");
int number = Convert.ToInt32(Console.ReadLine());
    
if (number >= 999)
{
    do
    {
        number = number / 10;
        Console.Write(number);
    }
    while (number / 1000 > 0);
}

int threeDigit = number % 10;

Console.WriteLine($"{number} -> {threeDigit}");