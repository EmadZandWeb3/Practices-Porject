//برنامه ای بنویسید که مقادیر تکراری یک ارایه را چاپ نماید 


int[] array = { 4, 2, 7, 4, 9, 2, 5, 7, 7 };
Console.WriteLine("The Values of ARAYE : ");

foreach (int num in array)
{
    Console.Write(num + " ");
}

Console.WriteLine(  );

Console.WriteLine("The TEKRARI values of the ARAYE is : ");

for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] == array[j])
        {
            
            bool alreadyPrinted = false;
            for (int k = 0; k < i; k++)
            {
                if (array[k] == array[i])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (!alreadyPrinted)
            {
                Console.Write(array[i]+"  ");
            }

            break; 
        }
    }
}

Console.WriteLine(  );

Console.WriteLine( "-------------------------");

// برنامه ای بنویسید که مقادیر تکراری دو آرایه متفاوت را چاپ نماید

int[] array1 = { 1, 2, 3, 4, 5, 6 };
int[] array2 = { 4, 5, 6, 7, 8, 9 };

Console.WriteLine("First Array : ");
foreach (int num in array1)
{
    Console.Write(num + " ");
}

Console.WriteLine(  );

Console.WriteLine("Second Array : ");
foreach (int num in array2)
{
    Console.Write(num + " ");
}

Console.WriteLine(  );

Console.WriteLine("The MOSHTARAK of values in arrays : ");

for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {
        if (array1[i] == array2[j])
        {
           
            bool alreadyPrinted = false;
            for (int k = 0; k < i; k++)
            {
                if (array1[k] == array1[i])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (!alreadyPrinted)
                Console.WriteLine(array1[i]);

            break;
        }
    }
}


Console.WriteLine("---------------------------------");

// برنامه ای بنویسید که مقادیر تکراری یک آرایه را حذف نماید.




int[] mainArray = { 1, 2, 3, 2, 4, 5, 3, 6 };
Console.WriteLine("The Values of ARAYE : ");

foreach (int num in mainArray)
{
    Console.Write(num + " ");
}
Console.WriteLine(  );


int[] temp = new int[mainArray.Length];
int count = 0;

for (int i = 0; i < mainArray.Length; i++)
{
    bool exists = false;
    for (int j = 0; j < count; j++)
    {
        if (mainArray[i] == temp[j])
        {
            exists = true;
            break;
        }
    }

    if (!exists)
    {
        temp[count] = mainArray[i];
        count++;
    }
}

Console.WriteLine("The Array without TEKRARI values : ");
for (int i = 0; i < count; i++)
{
    Console.Write(temp[i] + " ");
}