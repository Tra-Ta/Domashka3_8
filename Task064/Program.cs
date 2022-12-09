// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Enter natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("Number not natural");

NaturalNumbers(n);

void NaturalNumbers(int numN)
{
    if (numN >= 2)
    {
        Console.Write($"{numN}, ");
        NaturalNumbers(numN - 1);
    }
    else if (numN == 1)
    {
    Console.Write(numN);
    }
}

