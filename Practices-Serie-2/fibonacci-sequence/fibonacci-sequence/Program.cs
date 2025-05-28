int FibonacciFast(int n)
{
    return FibHelper(n, 0, 1);
}

int FibHelper(int n, int a, int b)
{
    if (n == 0)
        return a;
    if (n == 1)
        return b;
    return FibHelper(n - 1, b, a + b);
}

Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Fibonacci(" + n + ") = " + FibonacciFast(n));
