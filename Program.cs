float code1;
float code2;
string? sign;
bool continueCalculating  = true;

Console.WriteLine("Hi! What do you want?");
StartCycle:
Console.Write("1. Calculator: ");
int userChoice = Convert.ToInt32(Console.ReadLine());
{
    if ( userChoice == 1)
    {
        Calculator();
    }
    else
    {
        Console.WriteLine("We are don't have something like that");
        goto StartCycle;
    }
}


void Calculator()
{
    while(continueCalculating == true)
    {
        Console.WriteLine("## ДОБРО ПОЖАЛОВАТЬ В КАЛЬКУЛЯТОР");
        Console.WriteLine("---------------------------------\n");
        CalcAgain:
        Console.Write("Enter your first number: ");
        code1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter a sign ['**' '+' '-' '/' '*']");
        sign = Console.ReadLine();
        Console.Write("Enter your second number: ");
        code2 = Convert.ToSingle(Console.ReadLine());

        if(sign == "/" && code2 == 0)
        {
            Console.WriteLine("Really ?");
            goto CalcAgain;
        }

        float result = sign switch
        {
            "+" => (float)code1 + (float)code2,
            "-" => (float)code1 - (float)code2,
            "*" => (float)code1 * (float)code2,
            "/" => (float)code1 / (float)code2,
            "**" => (float)Math.Pow((float)code1, (float)code2),
            _ => throw new ArgumentException("Unknown Sign!")
        };

        Console.WriteLine(result);

        Thread.Sleep(1000);
        Console.WriteLine("Write 'n' to close this app or write 'y' to continue");
        if(Console.ReadLine() == "n")
        {
            continueCalculating = false;
        }

        Console.WriteLine();
    }
}   