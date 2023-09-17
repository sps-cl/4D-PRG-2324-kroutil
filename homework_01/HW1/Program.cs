using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        
        public interface IOperation
        {
            double Calculate(double a, double b);
        }
        public class OpAdd : IOperation
        {
            public double Calculate(double a, double b)
            {
                return a + b;
            }
        }
        public class OpSub : IOperation
        {
            public double Calculate(double a, double b)
            {
                return a - b;
            }
        }
        public class OpMagic : IOperation
        {
            public double Calculate(double a, double b)
            {
                return a * b;
            }
        }
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
        public class CalculatorApp
        {
            public static void Main(string[] args)
            {
                IOperation addOperation = new OpAdd();
                IOperation subOperation = new OpSub();
                IOperation magicOperation = new OpMagic();
                CalculatorContext calculatorContext = new CalculatorContext(addOperation);
                double result = calculatorContext.ExecuteOperation(10, 5);
                System.Console.WriteLine($"Sum result: {result}");
                calculatorContext = new CalculatorContext(subOperation);
                result = calculatorContext.ExecuteOperation(10, 5);
                System.Console.WriteLine($"Sub result: {result}");
                calculatorContext = new CalculatorContext(magicOperation);
                result = calculatorContext.ExecuteOperation(10, 5);
                System.Console.WriteLine($"Magic result: {result}");
                Console.ReadKey();
            }
        }
    }
    
}
