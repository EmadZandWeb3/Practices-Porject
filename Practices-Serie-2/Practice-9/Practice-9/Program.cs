//برنامه ای بنویسید که با دریافت لیست عدد؛ عددی که بیشترین تکرار را دارد در خروجی چاپ
//نماید.

Console.Write("Enter the Number of numbers : ");
int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];

Console.WriteLine("Enter the Number : ");
for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

int[] unique = new int[n];
int[] counts = new int[n];
int uniqueCount = 0;

for (int i = 0; i < n; i++)
{
    int value = numbers[i];
    bool found = false;

    for (int j = 0; j < uniqueCount; j++)
    {
        if (unique[j] == value)
        {
            counts[j]++;
            found = true;
            break;
        }
    }

    if (!found)
    {
        unique[uniqueCount] = value;
        counts[uniqueCount] = 1;
        uniqueCount++;
    }
}

int maxIndex = 0;
for (int i = 1; i < uniqueCount; i++)
{
    if (counts[i] > counts[maxIndex])
        maxIndex = i;
}

Console.WriteLine("The number with the most repetitions is {0} with {1} of Tekrar ", counts[maxIndex], unique[maxIndex]);
    