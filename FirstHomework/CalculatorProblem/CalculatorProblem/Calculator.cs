using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProblem
{
    class Calculator : ICalculator
    {
        public T Add<T>(T first, T second)
        {

            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber + secondNumber;
        }

        public T Substract<T>(T first, T second)
        {

            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber - secondNumber;
        }

        public T Multiply<T>(T first, T second)
        {

            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber * secondNumber;
        }

        public T Divide<T>(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber / secondNumber;
        }
    }
}
