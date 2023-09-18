using _2._Hodina.operations;

namespace _2._Hodina
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CalculatorContext context = new CalculatorContext(new OperationAdd());

            Console.WriteLine($"4 + 5 = " + context.executeOperation(4,5);
        }
    }
}