//برنامه ای بنویسید که نام ؛ ساعت کار و حقوق ساعتی کارمندان را دریافت و حقوق آنها را محاسبه و
//چاپ نماید.

Console.Write("Enter ur name : ");
string name = Console.ReadLine();

Console.Write("Enter ur Working hours : ");
int hours = int.Parse(Console.ReadLine());

Console.Write("Enter ur Hourly salary($) : ");
int rate = int.Parse(Console.ReadLine());

int totalPay = hours * rate;

Console.WriteLine("Employee {0}, total salary: {1} $",name,totalPay);

Console.WriteLine("---------------------------------------------------------------");
//برنامه ای بنویسید که مضارب عدد 2 را تا 1000 تولید و چاپ نماید.


Console.WriteLine("multipliers of 2 to 1000 : ");

for (int i = 2; i <= 1000; i += 2)
{
    Console.Write(i+ " ");
}


Console.WriteLine("---------------------------------------------------------------");

// برنامه ای بنویسید که مضارب عدد 9 را تا 1000 تولید و چاپ نماید.

Console.WriteLine("multipliers of 9 to 1000 : ");

for (int i = 9; i <= 1000; i += 9)
{
    Console.Write(i + " ");
}