using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class Program
    {
        public delegate void Del(string message);
        public delegate int Add(int num1, int num2);

        public delegate Student Stud(string firstname, string lastname, char gender);

        static void Main(string[] args)
        {
            Del handler2 = DelegateMethod;
            Del handler = DelegateMethod2;
            Add handler3 = AddNumbers;
            Stud handler4 = AddTitle;

            // handler.invoke(parameters)
            handler2.Invoke("test");
            int sum = handler3.Invoke(50, 25);

            // handler(parameters)
            int sum2 = handler3(20, 5);
            handler("Al");
            Student s = handler4("Al", "Goh", 'M');

            Console.WriteLine(s.Fullname);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Sum2 = " + sum2);
        }

        public static void DelegateMethod(string message)
        {
            System.Console.WriteLine(message);
        }

        public static void DelegateMethod2(string name)
        {
            System.Console.WriteLine("Hello " + name);
        }

        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static Student AddTitle(string firstname, string lastname, char gender)
        {
            string title = gender == 'M' ? "Mr. " : "Ms. ";
            return new Student() { Fullname = title + firstname + " " + lastname};            
        }
    }

    public class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char Gender { get; set; }
        public string Fullname { get; set; }
    }
}
