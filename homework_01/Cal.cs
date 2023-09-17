// IOperation.cs
public interface IOperation
{
    double Calculate(double a, double b);
}
// OpAdd.cs
public class OpAdd : IOperation
{
    public double Calculate(double a, double b)
    {
        return a + b;
    }
}
// OpSub.cs
public class OpSub : IOperation
{
    public double Calculate(double a, double b)
    {
        return a - b;
    }
}
// OpMagic.cs
public class OpMagic : IOperation
{
    public double Calculate(double a, double b)
    {
        return a * b;
    }
}
// CalculatorContext.cs
public class CalculatorContext
{
    private IOperation _operation;
    public CalculatorContext(IOperation operation)
    {
        _operation = operation;
    }
    public double ExecuteOperation(double a, double b)
    {
        return _operation.Calculate(a, b);
    }
}
// CalculatorApp.cs
public class CalculatorApp
{
    public static void Main(string[] args)
    {
        // Create an instance of each operation
        IOperation addOperation = new OpAdd();
        IOperation subOperation = new OpSub();
        IOperation magicOperation = new OpMagic();
        // Create an instance of the calculator context
        CalculatorContext calculatorContext = new CalculatorContext(addOperation);
        // Execute the operation and print the result
        double result = calculatorContext.ExecuteOperation(10, 5);
        System.Console.WriteLine($"Výsledek souètu je: {result}");
        // Change the operation and execute it again
        calculatorContext = new CalculatorContext(subOperation);
        result = calculatorContext.ExecuteOperation(10, 5);
        System.Console.WriteLine($"Výsledek rozdílu je: {result}");
        // Change the operation and execute it again
        calculatorContext = new CalculatorContext(magicOperation);
        result = calculatorContext.ExecuteOperation(10, 5);
        System.Console.WriteLine($"Výsledek souèinu je: {result}");
    }
}