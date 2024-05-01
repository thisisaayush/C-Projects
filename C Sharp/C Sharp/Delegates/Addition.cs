using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Delegates
{
    public delegate void Sum(int x, int y);

    public delegate void Display(string a, string y);
    public class Addition
    {
       public static void Main(string[] args)
        {
            Addition a = new Addition(); ;
            Sum sum = new Sum(a.addition);
            Display display = new Display(a.displayOutcome);


            sum(88, 98);

            display("Hello", "Delegates is awesome!");
        }

        public void addition(int a, int b)
        {
            Console.WriteLine( $"Sum: {a + b}");
        }

        public void displayOutcome(string x, string y)
        {
            Console.WriteLine($"Value of x: {x} and Value of y: {y}");
        }
    }
}
