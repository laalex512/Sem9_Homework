/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


int InputInt(string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNtoOne(int n)
{
    if (n == 1)
    {
        Console.WriteLine(n);
    }
    else
    {
        Console.Write(n + ", ");
        PrintNtoOne(n - 1);
    }
}


int n = InputInt("N");
PrintNtoOne(n);
