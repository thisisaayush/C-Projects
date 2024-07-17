using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Delegates
{
    public delegate int MathOperation(int x, int y);
    internal class DelegateChallenge
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }


        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate with the Add method
            MathOperation operation = Add;
            Console.WriteLine("Addition: 10 + 5 = " + operation(10, 5));

            // Change the delegate to point to the Subtract method
            operation = Subtract;
            Console.WriteLine("Subtraction: 10 - 5 = " + operation(10, 5));

            // Change the delegate to point to the Multiply method
            operation = Multiply;
            Console.WriteLine("Multiplication: 10 * 5 = " + operation(10, 5));

            // Use delegate as a parameter in a method
            ExecuteOperation(10, 5, Add);
            ExecuteOperation(10, 5, Subtract);
            ExecuteOperation(10, 5, Multiply);
        }

        // Method that takes a delegate as a parameter
        public static void ExecuteOperation(int x, int y, MathOperation operation)
        {
            Console.WriteLine("Result: " + operation(x, y));
        }
    }
}
