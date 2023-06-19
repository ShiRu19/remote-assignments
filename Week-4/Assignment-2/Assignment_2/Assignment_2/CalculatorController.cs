using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class CalculatorController
    {
        private readonly ICalculator ICalculator;
        private readonly string CalculatorType;

        public CalculatorController(ICalculator calculator, string calculatorType)
        {
            ICalculator = calculator;
            CalculatorType = calculatorType;
        }

        public int Calculate(int a, int b)
        {
            int result = 0;
            if(CalculatorType == "Add")
            {
                result = ICalculator.Add(a, b);
            }
            else if(CalculatorType == "Subtract")
            {
                result = ICalculator.Subtract(a, b);
            }
            return result;
        }
    }
}
