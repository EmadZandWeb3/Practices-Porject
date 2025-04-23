//برنامه ای بنویسید که عدد N را دریافت و مشخص کند آن بر مجموع ارقامش قابل تقسیم است یا 
//خیر


using System.Numerics;

Console.Write("Enter the Number : ");
int N = int.Parse(Console.ReadLine());

int original = N;
int sum = 0;

while (N > 0)
{
    sum += N % 10;
    N /= 10;
}

if (original % sum == 0)
    Console.WriteLine("The Number is Bakhsh Pazir :) ");
else
    Console.WriteLine("The Number is Not Bakhsh Pazir :(");


//برنامه ای بنویسید که nعدد اول سری فیبوناچی را چاپ نماید.


Console.Write("Enter a Number For Fibonacci Serie :");
int n = int.Parse(Console.ReadLine());

BigInteger a = 0, b = 1;

Console.WriteLine("The Fibonacci Serie :");

for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);
    BigInteger temp = a + b;
    a = b;
    b = temp;
}


//برنامه ای بنوسید که مشخص کند عدد n عددی قوی است یا خیر


Console.Write("Is this Number strong? :");
int strongN = int.Parse(Console.ReadLine());

int originalN = strongN;
int sumN = 0;

while (strongN > 0)
{
    int digit = strongN % 10;
    int fuct = 1;
    for (int i = 1; i <= digit; i++)
        fuct *= i;

    sumN += fuct;
    strongN /= 10;
}

if (sumN == originalN)
    Console.WriteLine("yes it is");
else
    Console.WriteLine("Nah he is weak as f ");