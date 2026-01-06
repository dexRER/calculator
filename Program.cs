using System.Globalization;
using System.Runtime.CompilerServices;

float code1;
float code2;
string? sign;

Console.WriteLine("Hi! What do you want?");
Console.Write("1. Calculator: ");
int userChoice = Convert.ToInt32(Console.ReadLine());
{
    if ( userChoice == 1)
    {
        Calculator();
    }
    else
    {
        Console.WriteLine("Sorry but not now");
    }
}


void Calculator()
{
    for (Console.WriteLine("## ДОБРО ПОЖАЛОВАТЬ В КАЛЬКУЛЯТОР"); ;)
    {

        Console.Write("Enter your first number: ");
        code1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter a sign ['**' '+' '-' '/' '*']");
        sign = Console.ReadLine();
        Console.Write("Enter your second number: ");
        code2 = Convert.ToSingle(Console.ReadLine());

        float result = sign switch
        {
            "+" => (float)code1 + (float)code2,
            "-" => (float)code1 - (float)code2,
            "*" => (float)code1 * (float)code2,
            "/" => code2 != 0 ? (float)code1 / (float)code2 : throw new ArgumentException("Unknown Sign!"),
            "**" => (float)Math.Pow((float)code1, (float)code2),
            _ => throw new ArgumentException("Unknown Sign!")
        };

        Console.WriteLine(result);

        Thread.Sleep(1000);
    }
}