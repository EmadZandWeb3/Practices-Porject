//برنامه ای بنویسید که مثلث خیام پاسکال را در خروجی چاپ نماید.


Console.Write("Enter the Number of row : ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    for (int space = 0; space < n - i - 1; space++)
        Console.Write("  ");

    int value = 1;
    for (int j = 0; j <= i; j++)
    {
        Console.Write(value + "   ");
        value = value * (i - j) / (j + 1);
    }

    Console.WriteLine();
}



//برنامه ای بنویسید که رشته ای را از ورودی دریافت و بصورت عکس در خروجی چاپ نماید.


Console.Write("Enter a strint context : ");
string text = Console.ReadLine();

string reversed = "";

for (int i = text.Length - 1; i >= 0; i--)
{
    reversed += text[i];
}

Console.WriteLine("Reverse string : " + reversed);