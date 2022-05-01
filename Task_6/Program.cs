/*
Задача 6. Напишите программу , которая на вход принимает число и выдает,
является ли число чётным(делиться ли число на 2 без остатка)
*/

Console.WriteLine("Введите чило,чтобы узнать является ли оно чётным: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.WriteLine($"{Number} - четное число");
}
else
{
    Console.WriteLine($"{Number} - нечетное число");
}