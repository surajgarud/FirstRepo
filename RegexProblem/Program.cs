// See https://aka.ms/new-console-template for more information
using RegexProblem;

Console.WriteLine("Hello, World!");
SampleEmailTest patterns = new SampleEmailTest();

if (patterns.RegexPro("abc@hgf.com.com"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();