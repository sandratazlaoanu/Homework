using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProblem
{
    interface ICalculator
    {
        T Add<T>(T first, T second);

        T Substract<T>(T first, T second);

        T Multiply<T>(T first, T second);

        T Divide<T>(T first, T second);
    }
   
}
