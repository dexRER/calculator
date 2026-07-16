using System.ComponentModel;
using System.Numerics;

static class Operation
{
    public delegate T DoOperation<T>(T value1, T value2) where T : INumber<T>;

    public static T Sum<T>(T value1, T value2) where T : INumber<T>
    {
        T result = value1 + value2;
        return result;
    }

    public static T Substract<T>(T value1, T value2) where T : INumber<T>
    {
        T result = value1 - value2;
        return result;
    }

    public static T Multiply<T>(T value1, T value2) where T : INumber<T>
    {
        T result = value1 * value2;
        return result;
    }

    public static T Divide<T>(T value1, T value2) where T : INumber<T>
    {
        T result = value1 / value2;
        return result;
    }
}

class Program
{
    static Operation.DoOperation<T> OperationChoice<T>(string operation) where T : INumber<T>
    {
        switch (operation)
        {
            case "+": return Operation.Sum;
            case "-": return Operation.Substract;
            case "*": return Operation.Multiply;
            case "/": return Operation.Divide;
            default: return Operation.Sum;
        }
        
    }

    static void Main()
    {
        Operation.DoOperation<double> doOperation = OperationChoice<double>("+");
        Console.WriteLine(doOperation(5, 3));
    }
}