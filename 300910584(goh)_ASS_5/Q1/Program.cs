using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            OverloadExample();
            Terms();
        }

        #region OverloadExample
        private static void OverloadExample()
        {
            // Example of overloading generic method
            // First overload accepts generic types as argument. Second overload accepts Bird class

            Console.WriteLine("=============Overload Example=============\n");

            Person person = new Person();
            Dog dog = new Dog();
            Cat cat = new Cat();
            Bird bird = new Bird();

            // The first 3 objects will call the generic method "MoveObject<T>"
            Console.WriteLine("Here, the first 3 objects \"walk\" to move:");
            MoveObject(person);
            MoveObject(dog);
            MoveObject(cat);

            // The next object is an instance of a specific class, Bird, and will call the overload of method "MoveObject(Bird)"
            Console.WriteLine("\nHere, the Bird object \"flies\" to move:");
            MoveObject(bird);
        }
        
        public static void MoveObject<T>(T obj) where T : class
        {
            // cast into Animal interface, to call Walk()
            ((Animal)obj).Walk();
        }

        public static void MoveObject(Bird obj)
        {
            obj.Fly();
        }
        #endregion

        #region Terms
        private static void Terms()
        {
            Console.WriteLine("\n\n=============Terms=============\n");
            PrintTitle("ICollection");
            PrintDefinition("an interface that has definition of methods that can iterate through data, AND manipulate those data.");
            PrintTitle("Array");
            PrintDefinition("stores a fixed-size sequential collection of elements of the same type. Stored physically in memory.");
            PrintTitle("IList");
            PrintDefinition("an interface that implements IEnumerable, and can be used when you need to access elements in a collection individually by index");
            
        }

        private static void PrintTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(title);
        }

        private static void PrintDefinition(string def)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" = " + def + "\n");
        }
        #endregion
    }
}
