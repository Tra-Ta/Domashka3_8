// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Enter natural number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter natural number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int numN, int numM)
{
    if (numN == 0) return numM + 1;
    else if (numM == 0) return Akkerman(numN - 1, 1);
    return Akkerman(numN - 1, Akkerman(numN, numM - 1));
}

if (m >= 0 && n >= 0)
{
    int result = Akkerman(m, n);
    Console.Write($"A({m},{n}) = {result}");
}
else Console.Write("Numbers not natural");