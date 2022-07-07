/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int InputInt(string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumMtoN(int m, int n)
{
    if (m != n)
    {
        return m + SumMtoN(m + 1, n);
    }
    else
    {
        return n;
    }
}

int m = InputInt("M");
int n = InputInt("N");

if (m < n)
    Console.WriteLine(SumMtoN(m, n));
else
    Console.WriteLine(SumMtoN(n, m));


