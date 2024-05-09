using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice4
{
    public delegate void OperationHandler(double value1, double value2);
    internal class calculator
    {
        public event OperationHandler Operation;

        public double Add(double value1, double value2)
        {
            double result = value1 + value2;
            Operation?.Invoke(value1, value2);
            return result;
        }

        public double Subtract(double value1, double value2)
        {
            double result = value1 - value2;
            Operation?.Invoke(value1, value2);
            return result;
        }

        public double Multiply(double value1, double value2)
        {
            double result = value1 * value2;
            Operation?.Invoke(value1, value2);
            return result;
        }

        public double Divide(double value1, double value2)
        {
            double result = value1 / value2;
            Operation?.Invoke(value1, value2);
            return result;
        }
    }
}

