using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Hodina
{
    internal class CalculatorContext
    {
        private IOperation operation;

        public CalculatorContext(IOperation operation) 
        {
            this.operation = operation;
        }
        
        public int executeOperation(int a, int b) {
            return this.operation.execute(a, b);
        }
    
    }
}
