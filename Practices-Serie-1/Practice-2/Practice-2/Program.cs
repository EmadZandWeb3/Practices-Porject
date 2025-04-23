//برنامه ای بنویسید که عددی را دریافت و فاکتوریل آن را محاسبه و چاپ نماید.
using System.Numerics;


Console.Write("Enter ur Mosbat number : ");

int Number = int.Parse(Console.ReadLine());

BigInteger Fact = 1;
for (int i = 1; i <= Number; i++)
{
    Fact *= i;
}
Console.WriteLine("The Factorial of {0} is : {1}",Number,Fact);

//  برنامه ای بنویسید که عددی را از ورودی دریافت و تعداد ارقام آن را چاپ نماید.

/*int digitCount = 0;
if (Number == 0)
{
    digitCount = 1;
}
else
{
    while (Number>0)
    {
        Number /= 10;
        digitCount++;
    }
}
Console.WriteLine("The number of digits is : {0}",digitCount);*/

// برنامه ای بنویسید که عددی را دریافت و وارون آن را در خروجی چاپ نماید

/*int reversed = 0;

while (Number > 0)
{
    reversed = reversed * 10 + Number % 10;
    Number /= 10;
}
Console.WriteLine("The Reveresed of Number : {0} ",reversed);*/

//برنامه ای بنویسید که عددی را دریافت و مشخص کند اول است یا خیر؟


bool isAval = true;

if (Number < 2)
    isAval = false;
else if (Number == 2)
    isAval = true;
else if (Number % 2 == 0)
    isAval = false;
else
{
    for (int i = 3; i < Number; i += 2)
    {
        if (Number % i == 0)
        {
            isAval = false;
            break;
        }
    }
}
if (isAval == true)
{
    Console.WriteLine("The number of {0} is Aval",Number);
}
else
{
    Console.WriteLine("The number of {0} is NOT Aval",Number);
}