/*
Задача 8. Напишите программу , которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Temp = Number - 1;
for (int i = 2; i <= Number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        if (i < Temp)
        {
            Console.Write(", ");
        }
    }
}