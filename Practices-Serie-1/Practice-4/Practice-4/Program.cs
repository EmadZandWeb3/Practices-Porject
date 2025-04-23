//برنامه ای بنویسید که مجموع N جمله از سری روبرو را چاپ نماید
// 1+2-3+4-5+6…..N

Console.Write("Enter the N number : ");
int N = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= N; i++)
{
    if (i == 1 || i % 2 == 0)
        sum += i;
    else
        sum -= i;
}

Console.WriteLine("The sum of series is : {0} ", sum);


//برنامه ای بنویسید که عدد N را دریافت و مجموع زیر را محاسبه و چاپ نماید
// s = 1 + 1/2 + 1/3 + ... + 1/N


double sum2 = 0;

for (int i = 1; i <= N; i++)
{
    sum2 += 1.0 / i;
}

Console.WriteLine("The sum of series is : {0} ", sum2);


//برنامه ای بنویسید که عدد N را از ورودی دریافت و کلیه مقسوم علیه های آن به همراه جمع آن ها و
//تعدادش را در خروجی چاپ نماید.

int count = 0;
int sum3 = 0;

Console.Write("The divisors of the number is : ");

for (int i = 1; i <= N; i++)
{
    if (N % i == 0)
    {
        Console.Write(i+" ");
        sum3 += i;
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("The count of Divisor number is : {0} ",count);
Console.WriteLine("The Sum of the divisors number is : {0}",sum3);
