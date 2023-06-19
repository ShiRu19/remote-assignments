using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class CalculatorController
    {
        private ICalculator _calculator;
        private string _calculatorType;

        public CalculatorController()
        {
            _calculator = new AdvancedCalculator();
            //_calculator = new SimpleCalculator();
            _calculatorType = "Add";
            //_calculatorType = "Subtract";
        }

        public int Calculate(int a, int b)
        {
            int result = 0;
            if(_calculatorType == "Add")
            {
                result = _calculator.Add(a, b);
            }
            else if(_calculatorType == "Subtract")
            {
                result = _calculator.Subtract(a, b);
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
