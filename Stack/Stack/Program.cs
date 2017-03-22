using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.55, 6.6 };
        private static int[] intELements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        private static Stack<double> doubleStack; // stack stores doubles
        private static Stack<int> intStack; // stack stores ints

        static void Main(string[] args)
        {
            doubleStack = new Stack<double>(5);
            intStack = new Stack<int>(10);

            TestPushDouble();
            TestPopDouble();
        }

        static void TestPushDouble()
        {
            try
            {
                Console.WriteLine("Pushing elements onto doubleStack");

                foreach(var element in doubleElements)
                {
                    Console.Write($"Pushing{element:F1}... ");
                    doubleStack.Push(element);
                    Console.WriteLine($"{element:F1} pushed.");
                }
            }
            catch (FullStackException exception)
            {
                Console.WriteLine("Stack is full");
            }
        }

        static void TestPopDouble()
        {
            try
            {
                Console.WriteLine("\nPopping elements from doubleStack");

                double popValue;

                while(true)
                {
                    popValue = doubleStack.Pop();
                    Console.Write($"{popValue:F1} ");
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine($"{exception}");
            }
        }
        static void TestPushInt()
        {

        }
    }
}
