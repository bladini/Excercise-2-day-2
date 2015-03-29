using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class MathOperations
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int subtract(int a, int b)
        {
            return a - b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }

        public static int divide(int a, int b)
        {
            return a / b;
        }

        public static int exp(int a)
        {
            return (int)Math.Exp((double)a);
        }

        public static int root(int a)
        {
            return (int)Math.Sqrt((double)a);
        }

        public static int rand()
        {
            return new Random().Next();
        }
    }
}
