//برنامه ای بنویسید که مشخص کند یک عدد خاص در آرایه وجود دارد یا خیر؟ در صورت وجود
//اندیس آن را چاپ کند

//برنامه ای بنویسید که یک عدد خاص را از یک آرایه حذف کند



int[] numbers = { 5, 8, 12, 4, 9, 20, 15 , 236 ,56 , 167 , 154 , 14 , 112 , 789};

foreach (int n in numbers)
    Console.Write(n + " ");

Console.WriteLine(  );

Console.Write("Enter the number fo searching : ");
int nFounder = int.Parse(Console.ReadLine());



bool found = false;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == nFounder)
    {
        Console.WriteLine("The number {0} found in ANDIS {1} ", nFounder, i);
        found = true;
        break;
    }
}

if (!found)
{
    Console.WriteLine("Nahhhh I cant found this number becuase is ont exsist :)");
}


Console.Write("Enter the number u like to delete : ");
int nDeleter = int.Parse(Console.ReadLine());

int count = 0;
foreach (int n in numbers)
{
    if (n != nDeleter) count++;
}

int[] result = new int[count];
int index = 0;

foreach (int n in numbers)
{
    if (n != nDeleter)
        result[index++] = n;
}

Console.WriteLine("New value of ARAYE is : ");
foreach (int n in result)
    Console.Write(n + " ");