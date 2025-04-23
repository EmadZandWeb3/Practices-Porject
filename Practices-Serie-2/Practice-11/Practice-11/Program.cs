//برنامه ای بنویسید که تعدادی عدد اعشاری دریافت و واریانس آن ها را محاسبه و چاپ نماید.

Console.Write("Enter the number of number : ");
int n = int.Parse(Console.ReadLine());

double[] numbers = new double[n];
double sum = 0;

Console.WriteLine("Enter the ASHRI ADAD :");
for (int i = 0; i < n; i++)
{
    numbers[i] = double.Parse(Console.ReadLine());
    sum += numbers[i];
}

double mean = sum / n;

double varianceSum = 0;
for (int i = 0; i < n; i++)
{
    varianceSum += (numbers[i] - mean) * (numbers[i] - mean);
}

double variance = varianceSum / n;

Console.WriteLine("The VARIANCE of the numbers is : {0}",variance);
