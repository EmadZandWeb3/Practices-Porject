//برنامه ای بنویسید که دو عدد صحیح M و N را دریافت و اعداد مضرب 3 بین آن دو را چاپ نماید


Console.Write("Enter the first Number :");
int M = int.Parse(Console.ReadLine());

Console.Write("Enter the second Number : ");
int N = int.Parse(Console.ReadLine());

int start, end;

if (M < N)
{
    start = M;
    end = N;
}
else
{
    start = N;
    end = M;
}

Console.WriteLine("The Multiples of three between First and Second number is : ");

for (int i = start; i <= end ; i++)
{
    if (i % 3 == 0)
        Console.WriteLine(i);
}


//برنام ای بنویسید که دو عدد M و N را دریافت و حاصلضرب آن دو را با استفاده از جمع های متوالی
//محاسبه و چاپ نماید


int result = 0;

for (int i = 0; i < N; i++)
{
    result += M;
}

Console.WriteLine("The Product of {0} × {1} = {2}",M,N,result);