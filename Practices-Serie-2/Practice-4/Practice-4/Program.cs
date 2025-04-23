// برنامه ای بنویسید که مشخص کند دو آرایه با هم برابر هستند یا خیر؟


int[] array1 = { 1, 2, 3, 4, 5 };
foreach (int num in array1)
{
    Console.Write(num + " ");
}
Console.WriteLine();
int[] array2 = { 1, 2, 3, 4, 5 };
foreach (int num in array1)
{
    Console.Write(num + " ");
}
Console.WriteLine();
bool areEqual = true;

if (array1.Length != array2.Length)
{
    areEqual = false;
}
else
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            areEqual = false;
            break;
        }
    }
}

if (areEqual)
    Console.WriteLine("The Arrays is equal");
else
    Console.WriteLine("The Arrays is NOT equal");



Console.WriteLine("----------------------------");

// برنامه ای بنویسید که تمام 0 های آرایه را به انتهای آرایه منتقل نماید.


int[] zeroArray = { 0, 2, 0, 3, 4, 0, 5, 0, 6 };

foreach (int num in zeroArray)
{
    Console.Write(num + " ");
}

Console.WriteLine(  );
int index = 0; 


for (int i = 0; i < zeroArray.Length; i++)
{
    if (zeroArray[i] != 0)
    {
        zeroArray[index] = zeroArray[i];
        index++;
    }
}


while (index < zeroArray.Length)
{
    zeroArray[index] = 0;
    index++;
}

Console.WriteLine("New value of The ARAYE :");
foreach (int n in zeroArray)
{
    Console.Write(n + " ");
}

Console.WriteLine();
Console.WriteLine("----------------------------");

//برنامه ای بنویسید که یک آرایه را در خالف جهت عقربه های ساعت شیفت دهد. 

int[] leftArray = { 1, 2, 3, 4, 5 };

foreach (int num in leftArray)
{
    Console.Write(num + " ");
}

Console.WriteLine();

int first = leftArray[0]; 

for (int i = 0; i < leftArray.Length - 1; i++)
{
    leftArray[i] = leftArray[i + 1];
}

leftArray[leftArray.Length - 1] = first; 

Console.WriteLine("The new values of the ARAYE : ");
foreach (int n in leftArray)
{
    Console.Write(n + " ");
}


Console.WriteLine();
Console.WriteLine("----------------------------");




int[] separationArray = { -3, 7, -1, 0, 4, -5, 8, -2 };

foreach (int num in separationArray)
{
    Console.Write(num + " ");
}
Console.WriteLine();

int left = 0;
int right = separationArray.Length - 1;

while (left < right)
{
    while (separationArray[left] < 0 && left < right)
        left++;

    while (separationArray[right] >= 0 && left < right)
        right--;

    if (left < right)
    {
        int temp = separationArray[left];
        separationArray[left] = separationArray[right];
        separationArray[right] = temp;
    }
}

Console.WriteLine("The new values of the ARAYE : ");
foreach (int n in separationArray)
    Console.Write(n + " ");