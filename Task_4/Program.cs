/*
Задача 4 . Напишите программу , которая принимает на вход  3 числа и выдает максимальное из этих чисел.
*/

Console.WriteLine("Введите 3 числа,чтобы узнать какое из них большее: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = Convert.ToInt32(Console.ReadLine());
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (FirstNumber > SecondNumber)
{
    max = FirstNumber;
}
if (SecondNumber > FirstNumber)
{
    max = SecondNumber;
}
if (max < ThirdNumber)
{
    max = ThirdNumber;
}
Console.WriteLine($"Максимальным из трех числел является: {max}");