/*
Задача 2. Напишите программу, которая не вход принимает 2 числа и выдает какое число большее ,а какое меньшее.
*/
Console.WriteLine("Введите 2 числа,чтобы узнать какое большее, а какое меньшее : ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber)
{
    Console.WriteLine($"Max = {FirstNumber}");
    Console.WriteLine($"Min = {SecondNumber}");
}
if (SecondNumber > FirstNumber)
{
    Console.WriteLine($"Max = {SecondNumber}");
    Console.WriteLine($"Min = {FirstNumber}");
}
if (SecondNumber == FirstNumber)
{
    Console.WriteLine("Числа равны");
}