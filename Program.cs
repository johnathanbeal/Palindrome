using System;
using System.Diagnostics.Tracing;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] palindromes)
        {
            Console.WriteLine("Enter a palindrome");
            
            var input  = Console.ReadLine();
            var entries = input.Split(' ');

            var counter = 0;

            foreach (var entry in entries)
            {
                var loops = entry.Length;
                var doppleganger = "";

                while (loops > 0)
                {
                    doppleganger = doppleganger + entry[loops - 1];
                    loops = loops - 1;
                }

                counter++;

                if (entry == doppleganger)
                {
                    Console.WriteLine(counter + " is a Palindrome");
                }
                else
                {
                    Console.WriteLine(counter + " is NOT a Palindrome");
                }
            }
        }
    }
}
