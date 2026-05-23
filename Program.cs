class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        string? tempString;
        string? sign;

        float firstDigit = 0;
        float secondDigit = 0;
        float result = 0;

        bool isContinue = true;

        string[] mainTextMenu = {
                "============== WELCOME TO THE CALCULATOR ==============", //0 
                "Enter a first number: ", // 1 
                "Enter your sign: ",  // 2
                "Enter a second number: " // 3 
            };

        string[] errorArray = {
            "Erorr: wrong input", // 0
            "Error: second number is 0" // 1
            };

        Console.WriteLine(mainTextMenu[0]);

        while (isContinue == true)
        {

            Console.Write(mainTextMenu[1]);
            tempString = Console.ReadLine();
            CheckNumber(tempString, out firstDigit);


            Console.Write(mainTextMenu[2]);
            sign = Console.ReadLine();


            Console.Write(mainTextMenu[3]);
            tempString = Console.ReadLine();
            CheckNumber(tempString, out secondDigit);

            if (secondDigit == 0 && sign == "/") 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorArray[1]);
                Thread.Sleep(1000);
                Console.Clear();
                Console.ResetColor();
                continue; 
            }

            switch (sign)
            {
                case "+": result = firstDigit + secondDigit; break;
                case "-": result = firstDigit - secondDigit; break;
                case "*": result = firstDigit * secondDigit; break;
                case "/": result = firstDigit / secondDigit; break;
                case "^": MathRoot(firstDigit, secondDigit); break;
                default: Console.WriteLine("We dont have the same option"); ; break;
            }

            Console.WriteLine();
            Console.WriteLine($"Result: {result}");

            AskToContinue();
        }

        float MathRoot(float num, float rate)
        {
            result = 1;

            for (int i = 0; i < rate; i++) 
                result = result * num;

            return result;
        }

        void CheckNumber(string str, out float number)
        {
            if(!float.TryParse(str, out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorArray[0]);
                Thread.Sleep(1000);
                Console.ResetColor();
                Console.Clear();
            }    
        }

        void AskToContinue()
        {
            Console.WriteLine();
            Console.Write("Do you want continue ( y /n )?: ");
            tempString = Console.ReadLine();

            if (tempString == "y")
            {
                Thread.Sleep(500);
                Console.Clear();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}