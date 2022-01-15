// See https://aka.ms/new-console-template for more information
using LogicalProgram;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
// int n, i, S = 0, num = 0;
//Console.WriteLine("Enter a Number");
//n = int.Parse(Console.ReadLine());
//S = n / 2;
//for (i = 2; i <= S; i++)
//{
//    if (n % i == 0)
//    {
//        Console.WriteLine("No is Not Prime");
//        num = 1;
//        break;
//    }
//}
//if (num == 0)
//    Console.WriteLine("No. is Prime");


//int n, reverse = 0, rem;
//Console.WriteLine("Enter A Number");
//n = int.Parse(Console.ReadLine());
//while (n != 0)
//{
//    rem = n % 10;
//    reverse = reverse * 10 + rem;
//    n /= 10;
//}
//Console.WriteLine("Reverse Number:" + reverse);


int number, sum = 0, s;
Console.WriteLine("Enter A Value");
number = int.Parse(Console.ReadLine());
s = number;
for (int i = 1; i < number; i++)
{
    if (number % i == 0)
    {
        sum = sum + i;
    }
}
if (sum == s)
{
    Console.WriteLine("Entered Number Is A PerfectNo");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Entered Number Is Not PerfectNo");
    Console.ReadKey();
}