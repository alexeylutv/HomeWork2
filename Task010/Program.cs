// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number <100 || number >= 1000)
{
    Console.WriteLine("Число не трёхзначное, повторите ввод");
    return;
}

else

{
    int secondN = number / 10 % 10;
    Console.WriteLine("Вторая цифра числа: " + secondN);
}