//برنام ای بنویسید که اعداد 4 رقمی را تولید کند که رقم یکان و صدگان زوج؛ اما رقم دهگان و 
//هزارگان آنها فرد باشد


Console.WriteLine("The 4 digits Number with special rule : ");

for (int num = 1000; num <= 9999; num++)
{
    int yekan = num % 10;
    int dahgan = (num / 10) % 10;
    int sadgan = (num / 100) % 10;
    int hezargan = (num / 1000);

    if (yekan % 2 == 0 && sadgan % 2 == 0 && dahgan % 2 == 1 && hezargan % 2 == 1)
    {
        Console.Write(num + " ");
    }
}



//برنامه ای بنویسید که تعیین کند یک سکه 1000 تومانی به چند طریق می توان به سکه های 200؛ 
//100 و پنجاه تومانی تبدیل کرد.


int count = 0;

for (int a = 0; a <= 5; a++)           
{
    for (int b = 0; b <= 10; b++)      
    {
        for (int c = 0; c <= 20; c++)  
        {
            if (a * 200 + b * 100 + c * 50 == 1000)
            {
                count++;
            }
        }
    }
}

Console.WriteLine("Number of ways to convert 1000 Tomans: " + count);

