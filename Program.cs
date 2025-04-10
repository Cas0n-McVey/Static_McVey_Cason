using System;

namespace Static_McVey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {

            // Integers
            // Prints integers Add, Sub, Mult, and Div
            Console.WriteLine("Integers Methods");
            Console.WriteLine("21 + 65 is " + Calculate.Add(21, 65));
            Console.WriteLine("50 - 32 is " + Calculate.Sub(50, 32));
            Console.WriteLine("20 * 8 is " + Calculate.Mult(20, 8));
            Console.WriteLine("95 / 12 is " + Calculate.Div(92, 12));

            // Floats
            // Prints Float Add, Sub, Mult, and Div
            Console.WriteLine("\nFloat Methods");
            Console.WriteLine("28.22 + 75.75 is " + Calculate.Add(28.22f, 75.75f));
            Console.WriteLine("25.25 - 32.32 is " + Calculate.Sub(25.25f, 32.32f));
            Console.WriteLine("25.20 * 5.0 is " + Calculate.Mult(25.20f, 5.0f));
            Console.WriteLine("100.925 / 12.21 is " + Calculate.Div(100.925f, 12.21f));
        }
    }
}
