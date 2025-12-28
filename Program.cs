float code1;
float code2;
string? sign;

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
        "/" => code2 != 0 ? (float)code1 / (float)code2 : throw new ArgumentException("Unknown Sigh!"),
        "**" => (float)Math.Pow((float)code1, (float)code2),
        _ => throw new ArgumentException("Unknown Sigh!")
    };

    Console.WriteLine(result);

    Thread.Sleep(1000);
}