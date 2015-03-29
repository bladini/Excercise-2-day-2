using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class MathOperations
    {
        public static string log { get; private set; }

        private static void logWrite(string message)
        {
            if (log == null)
            {
                log = "";
            }
            log += message + "\n";
        }

        public static double add(double a, double b)
        {
            logWrite(string.Format("{0} + {1} equals {2}", a, b, a + b));
            return a + b;
        }

        public static double subtract(double a, double b)
        {
            logWrite(string.Format("{0} - {1} equals {2}", a, b, a - b));
            return a - b;
        }

        public static double multiply(double a, double b)
        {
            logWrite(string.Format("{0} * {1} equals {2}", a, b, a * b));
            return a * b;
        }

        public static double divide(double a, double b)
        {
            logWrite(string.Format("{0} / {1} equals {2}", a, b, a / b));
            return a / b;
        }
    }
}
