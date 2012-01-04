using System;
using System.Linq;

namespace Zywiec
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("dupa");
            Console.ReadLine();
        }

        public int GetRandomNumber()
        {
            return 10;
        }

        public static bool foo()
        {
            Console.WriteLine("dupa");
            
            foreach(var i in Enumerable.Range(0, 100))
            {
                Console.WriteLine((i*i).ToString());
            }

            return false;
        }
    }
}