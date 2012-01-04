using System;
using System.Linq;

// tylko komentarz
//kolejny komcio

namespace Zywiec
{
    public class Program
    {
        public static void Main()
        {
            int a;

            for(int i=0; i<3; i++)
                Console.WriteLine("Linia jakas");

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

        public string GetRandomWord()
        {
            return "Jedrek";
        }
    }
}