//برنامه ای بنویسید که مشخصات تعدادی دانشجو شامل شماره دانشجویی و کد مقطع تحصیلی را
//دریافت سپس دانشجویان هر مقطع را به تفکیک چاپ نماید. کاردانی 1: کارشناسی 2 ارشد 3
//دکتری 4

Console.Write("Enter the Number of DANESHJOOYAN : ");
int n = int.Parse(Console.ReadLine());

string[] studentIds = new string[n];
int[] degreeCodes = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("DANESHJOOYE {0}",i+1);
    Console.Write("Number DANESHJOOYI : ");
    studentIds[i] = Console.ReadLine();

    Console.WriteLine("Code of lvl (1.KARDANI , 2.KARSHENASI , 3.ARSHAD , 4.DOCTORA)");
    degreeCodes[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Students by grade level");

string[] degreeNames = { "KARDANI", "KARSHENASI", "ARSHAD", "DOCTORA" };

for (int degree = 1; degree <= 4; degree++)
{
    Console.WriteLine("lvl {0} : ", degreeNames[degree - 1] );
    for (int i = 0; i < n; i++)
    {
        if (degreeCodes[i] == degree)
        {
            Console.WriteLine("DANESHJOOYI number : {0}", studentIds[i]);
        }
    }
}