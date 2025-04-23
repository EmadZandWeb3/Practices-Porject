//برنامه ای بنویسید که دو لیست فاقد اعداد تکراری را دریافت و اشتراک آن ها را در لیست دیگری
//بریزد.

Console.Write("Enter The Number Of Andis First ARAYE : ");
int n1 = int.Parse(Console.ReadLine());
int[] arr1 = new int[n1];

Console.WriteLine("First ARAYE Andises : ");
for (int i = 0; i < n1; i++)
{
    arr1[i] = int.Parse(Console.ReadLine());
}

Console.Write("Enter The Number Of Andis Second ARAYE");
int n2 = int.Parse(Console.ReadLine());
int[] arr2 = new int[n2];

Console.WriteLine("Second ARAYE Andises : ");
for (int i = 0; i < n2; i++)
{
    arr2[i] = int.Parse(Console.ReadLine());
}

int[] common = new int[Math.Min(n1, n2)];
int count = 0;

for (int i = 0; i < n1; i++)
{
    for (int j = 0; j < n2; j++)
    {
        if (arr1[i] == arr2[j])
        {
            bool isDuplicate = false;
            for (int k = 0; k < count; k++)
            {
                if (common[k] == arr1[i])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                common[count++] = arr1[i];
            }
        }
    }
}

Console.WriteLine("Sepration between two Array : ");
for (int i = 0; i < count; i++)
{
    Console.Write(common[i] + " ");
}