//برنامه ای بنوسید که یک آرایه را در آرایه دیگر کپی کند


int[] mainARAYE = { 1, 2, 3, 4, 5 };

int[] copyOfARAYE = new int[mainARAYE.Length];

for (int i = 0; i < mainARAYE.Length; i++)
{
    copyOfARAYE[i] = mainARAYE[i];
}

Console.WriteLine("Value of the Copy things :");
foreach (int n in copyOfARAYE)
{
    Console.Write(n + " ");
}


Console.WriteLine(  );

// برنامه ای بنویسید که یک عدد را در مکان مورد نظر یک آرایه درج نماید


int[] result = new int[mainARAYE.Length + 1];

Console.Write("The number u like to Add : ");
int number = int.Parse(Console.ReadLine());

Console.Write("what position u like ? (start at 0) : ");
int position = int.Parse(Console.ReadLine());

for (int i = 0; i < position; i++)
{
    result[i] = mainARAYE[i];
}

result[position] = number;

for (int i = position; i < mainARAYE.Length; i++)
{
    result[i + 1] = mainARAYE[i];
}

Console.WriteLine("New Values of the ARAYE is :");
foreach (int n in result)
{
    Console.Write(n + " ");
}


