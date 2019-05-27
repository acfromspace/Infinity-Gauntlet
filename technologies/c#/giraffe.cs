using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1:00:15

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "nice one";
            Console.WriteLine(phrase[0]); // "n".
            Console.WriteLine(phrase.IndexOf("one")); // Finds the first occurrence, which is at 5.

            int num = 5;
            Console.WriteLine(num / 2); // Returns an integer.
            Console.WriteLine(num / 2.0); // Returns a decimal.
            Console.WriteLine(Math.Abs(-num)); // Calling methods.
            Console.WriteLine(Math.Max(num, num + 5)); // Finds the max number between 2 parameters.

            Console.ReadLine();
        }
        public static string Reverse(string phrase)
        {
            char[] charArray = phrase.ToCharArray(); // Load string to character array.
            Array.Reverse(charArray); // Reverse the array.
            return new string(charArray); // Return the string.
        }
    }
}
