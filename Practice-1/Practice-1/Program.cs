//برنامه ای بنویسید که 20 عدد را گرفته و کوچکترین عدد آن ها را چاپ نماید.
//برنامه ای بنویسید که 20 عدد را گرفته و بزرگترین عدد آن ها را چاپ نماید.
//برنامه ای بنویسید که 20 عدد را گرفته و میانگین عدد آن ها را چاپ نماید.
//برنامه ای بنویسید که 20 عدد را از ورودی خوانده و اعدادی که رقم سمت راست آن ها 5 است را چاپ نماید.


int[] Number = new int[20];
string pangShomar = "";
Console.WriteLine("Enter The numbers : ");
for (int i = 0; i < Number.Length; i++)
{
    Number[i] = int.Parse(Console.ReadLine());
    if (Number[i] % 5 == 0 && Number[i] % 10 != 0)
    {
        pangShomar = pangShomar + " , " + Number[i];
    }
}
int minNumber = Number.Min();
int maxNumber = Number.Max();
double avgNumber = Number.Average();
Console.WriteLine("The Lowest Number is : {0}", minNumber);
Console.WriteLine("The Biggest Number is : {0}", maxNumber);
Console.WriteLine("The Average of Numbers is : {0}", avgNumber);
Console.WriteLine("The Numbers whit a most right digit of PANG : {0}", pangShomar);


//or use this without ARAYE :)


//int Number;
//Console.WriteLine("Enter The Numbers : ");
//int min = int.Parse(Console.ReadLine());
//int max = min;
//double avg;
//int sum = 0;
//string pangShomar = "";
//for (int i = 1; i < 20; i++)
//{
//    Number = int.Parse(Console.ReadLine());
//    if (Number < min)
//    {
//        min = Number;
//    }
//    if (Number > max) 
//    {
//        max = Number;
//    }
//    sum += Number;
//    if (Number % 5 == 0 && Number % 10 != 0)
//    {
//        pangShomar = pangShomar + " , " + Number;
//    }
//}
//avg = sum / 20;
//Console.WriteLine("The lowest number is : {0}", min);
//Console.WriteLine("The Biggest Number is : {0}", max);
//Console.WriteLine("The Average of Numbers is : {0}", avg);
//Console.WriteLine("The Numbers whit a most right digit of PANG : {0}", pangShomar);