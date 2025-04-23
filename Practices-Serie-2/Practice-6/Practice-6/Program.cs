Console.Write("Enter the Number of The ANDIS of the first ARAYE : ");
int n1 = int.Parse(Console.ReadLine());
int[] arr1 = new int[n1];

Console.WriteLine("The ANDISES of the First ARAYE : ");
for (int i = 0; i < n1; i++)
{
    arr1[i] = int.Parse(Console.ReadLine());
}

Console.Write("Enter the Number of The ANDIS of the Second ARAYE : ");
int n2 = int.Parse(Console.ReadLine());
int[] arr2 = new int[n2];

Console.WriteLine("The ANDISES of the Second ARAYE : ");
for (int i = 0; i < n2; i++)
{
    arr2[i] = int.Parse(Console.ReadLine());
}


int[] intersection = new int[Math.Min(n1, n2)];
int count = 0;

for (int i = 0; i < n1; i++)
{
    for (int j = 0; j < n2; j++)
    {
        if (arr1[i] == arr2[j])
        {
            bool alreadyExists = false;
            for (int k = 0; k < count; k++)
            {
                if (intersection[k] == arr1[i])
                {
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
            {
                intersection[count++] = arr1[i];
            }
        }
    }
}


Console.WriteLine("The ESHTERAK between two Arrays is :");
for (int i = 0; i < count; i++)
{
    Console.Write(intersection[i] + " ");
}