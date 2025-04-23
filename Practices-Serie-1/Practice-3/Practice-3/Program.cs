//برنامه ای بنویسید که اعداد اول بین 1 تا 1000 را چاپ کند.

Console.WriteLine("Aval number in range of 1 to 1000 : ");

for (int num = 2; num <= 1000; num++)
{
    bool isPrime = true;

   
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.Write(num + " ");
    }
}
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------");

// برنامه ای بنویسید که کلیه اعداد چهار رقمی قرینه را چاپ نماید.


Console.WriteLine("All four Digits GHARINE numbers : ");

for (int num = 1000; num <= 9999; num++)
{
    int firstDigit = num / 1000;
    int secondDigit = (num / 100) % 10;
    int thirdDigit = (num / 10) % 10;
    int fourthDigit = num % 10;

    if (firstDigit == fourthDigit && secondDigit == thirdDigit)
    {
        Console.Write(num + " ");
    }
}