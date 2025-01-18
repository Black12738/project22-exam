//الگوریتمی بنویسد که این دنباله را حساب کند  1/n... 1+1/2+1/3
Console.Write("Enter a number:");
decimal N = decimal.Parse(Console.ReadLine());
decimal S = 0;
for (decimal I = 1; I <= N; I++)
{
    S = S + 1 / I;
    Console.WriteLine(S);
}


//الگوریتمی بنویسید که الگوریتم  1/n ... 1+1/2+1/4  
Console.Write("Enter a number:");
decimal N = decimal.Parse(Console.ReadLine());
decimal S = 0;
for (decimal i = 2; i <= N; i++)
{
    if (i % 2 == 0)
    {


        S = S + 1 / i;
        Console.WriteLine(S);
    }
}

// الگوریتمی بنویسید که چند عدد را از کاربر بگیرد و تعیین کد که با توجه به شرط های زیر این مثلث است یا خیر
Console.Write("Enter a number:");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter a number:");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter a number:");
int c = int.Parse(Console.ReadLine());
if (a <= b + c)
{
    if (b <= a + c)
    {
        if (c <= a + b)
        {
            Console.WriteLine("ast");

        }
        else
        {
            Console.WriteLine("nist");
        }
    }
    else
    {
        Console.WriteLine("nist");
    }
}
else
{
    Console.WriteLine("nist");
}
