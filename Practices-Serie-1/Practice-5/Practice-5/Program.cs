//فرض کنید در روز R ام از ماه M هستیم. الگوریتمی بنویسید که R و M را دریافت و مشخص کند
//چندمین روز سال هستیم.

Console.Write("Enter The Day(R) :  ");
int R = int.Parse(Console.ReadLine());

Console.Write("Enter the month(M) :  ");
int M = int.Parse(Console.ReadLine());

int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int totalDays = 0;

for (int i = 0; i < M - 1; i++)
{
    totalDays += daysInMonths[i];
}

totalDays += R;

Console.WriteLine("Today is the {0} day of the year",totalDays);


//برنامه ای بنویسید که دو عدد را از ورودی دریافت و ب م م آن دو را در خروجی چاپ نماید.


Console.Write("Enter The First Number : ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter The Second Number : ");
int b = int.Parse(Console.ReadLine());

while (b != 0)
{
    int temp = b;
    b = a % b;
    a = temp;
}

Console.WriteLine("The BE MIM MIM of the Numbers is : {0}",a);


//برنامه ای بنویسید که عدد N را دریافت و مجموع ارقام آن را مشخص نماید

Console.Write("Enter The MOSBAT Number : ");
int N = int.Parse(Console.ReadLine());

int sum = 0;

while (N > 0)
{
    sum += N % 10;
    N /= 10;
}

Console.WriteLine("The Sum of the disgits is : {0}",sum);
