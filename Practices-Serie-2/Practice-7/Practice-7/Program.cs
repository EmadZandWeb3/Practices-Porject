//برنامه ای بنویسید که شماره دانشجویی و کد رشته تحصیلی تعدای دانشجو را دریافت و شماره
//دانشجویی را به تفکیک کد رشته تحصیلی بنویسد.


Console.Write("Enter the Number of DANESHJO :  ");
int n = int.Parse(Console.ReadLine());

string[] studentIds = new string[n];
string[] majors = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("DANESHJOOYE : {0}",i+1);    
    Console.Write("DANESHJOOYI Number : ");
    studentIds[i] = Console.ReadLine();

    Console.Write("RESHTE code :  ");
    majors[i] = Console.ReadLine();
}


string[] uniqueMajors = new string[n];
int uniqueCount = 0;

for (int i = 0; i < n; i++)
{
    bool exists = false;
    for (int j = 0; j < uniqueCount; j++)
    {
        if (majors[i] == uniqueMajors[j])
        {
            exists = true;
            break;
        }
    }
    if (!exists)
    {
        uniqueMajors[uniqueCount++] = majors[i];
    }
}

Console.WriteLine("Separation of DNESHJOOYI numbers based on field code :");

for (int i = 0; i < uniqueCount; i++)
{
    Console.WriteLine("RESHTE {0} : ", uniqueMajors[i]);
    for (int j = 0; j < n; j++)
    {
        if (majors[j] == uniqueMajors[i])
        {
            Console.WriteLine("DANESHJOOYI number : {0} ", studentIds[j]);
        }
    }
}