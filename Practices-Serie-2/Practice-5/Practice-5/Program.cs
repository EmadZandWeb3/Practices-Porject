//برنامه ای بنویسید که نام و شماره دانشجویی و معدل دانشجویان کالس را دریافت و لیست افرادی
//که معدل آن های بیشتر از میانگین کالس است را چاپ نماید

Console.Write("Enter the Number of DANESHJOO : ");
int n = int.Parse(Console.ReadLine());

string[] names = new string[n];
string[] ids = new string[n];
double[] grades = new double[n];

double sum = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Information of DANESHJO number {0} :",i+1);

    Console.Write("Name : ");
    names[i] = Console.ReadLine();

    Console.Write("Daneshjooyi Number : ");
    ids[i] = Console.ReadLine();

    Console.Write("Grade : ");
    grades[i] = double.Parse(Console.ReadLine());

    sum += grades[i];
}

double avg = sum / n;

Console.WriteLine("The Average of the class is : {0} ", avg);
Console.WriteLine("The DANESHJOO with the higher grades than average : ");

for (int i = 0; i < n; i++)
{
    if (grades[i] > avg)
    {
        Console.WriteLine("Name : {0} , DANESHJOOYI number : {1} , Grade : {2}", names[i], ids[i], grades[i]);
    }
}