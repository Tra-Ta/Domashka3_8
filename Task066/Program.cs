// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter two number:");
Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0) Console.WriteLine("Number M not natural");
else if (n < 0) Console.WriteLine("Number N not natural");
else
{
    SumNaturalNumbers(m, n);

    int SumNaturalNumbers(int numM, int numN)
    {
        if (numN == numM) return numN;
        return numN + SumNaturalNumbers(numM, numN - 1);

    }

    int res = SumNaturalNumbers(m, n);
    Console.WriteLine(res);
}