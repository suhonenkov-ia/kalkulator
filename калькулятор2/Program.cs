using System;

Console.WriteLine("какую операцию выполнить?");
Console.WriteLine("1.сложить два числа");
Console.WriteLine("2.вычесть из первого второе");
Console.WriteLine("3.перемножить два числа");
Console.WriteLine("4.разделить первое число на второе");
Console.WriteLine("5.возвести в степень N первое число");
Console.WriteLine("6.найти квадратный корень из числа");
Console.WriteLine("7.найти 1 процент от числа");
Console.WriteLine("8.найти факториал числа");
Console.WriteLine("9.завершение программы");
int operation = Convert.ToInt32(Console.ReadLine());
do
{
    if (operation == 1)
    {
        Console.WriteLine("введите 1-ое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2-ое число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("результат " + (a + b));
    }
    if (operation == 2)
    {
        Console.WriteLine("введите 1-ое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2-ое число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("результат " + (a - b));
    }
    if (operation == 3)
    {
        Console.WriteLine("введите 1-ое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2-ое число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("результат " + (a * b));
    }
    if (operation == 4)
    {
        Console.WriteLine("введите 1-ое число");
        float a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2-ое число");
        float b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("результат " + (a / b));
    }
    if (operation == 5)
    {
        Console.WriteLine("введите 1-ое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ввведите степень N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" результат " + (Math.Pow(a, N)));
    }
    if (operation == 6)
    {
        Console.WriteLine("введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("результат " + Math.Sqrt(a));
    }

    if (operation == 7)
    {
        Console.WriteLine("введите число");
        float a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("результат " + (a / 100));
    }
    if (operation == 8)
    {
        Console.WriteLine("введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        int c = 1;
        for (int i = 1; i <= a; i++)
        {
            c = c * i;
        }
        Console.WriteLine("результат " + c);
    }
    Console.WriteLine("какую операцию выполнить?");
    int operation2 = Convert.ToInt32(Console.ReadLine());
    operation = operation2;
}
while (operation != 9);
 
   


