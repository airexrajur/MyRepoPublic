using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class CalculatorService
    {
        private readonly ILogger _logger;
        private object @object;

        public CalculatorService(ILogger logger)
        {
            _logger = logger;
        }

        public CalculatorService(object @object)
        {
            this.@object = @object;
            //this._logger = (ILogger?)@object;
        }

        public int Multiply(int a, int b)
        {
            int result = a * b;
            _logger.Log($"Multiplying {a} and {b}: {result}");
            return result;
        }
    }


}
