using System;

namespace _05._64BitArray
{
    public class Start
    {
        public static void Main()
        {
            var first64Bit = new BitArray64(100302384834);
            var sec64Bit = new BitArray64(100302384834);

            foreach (var item in first64Bit)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in sec64Bit)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine("That are the 64 bit repr. of the ulong numbers");
            Console.WriteLine(".............................................................................");
            Console.WriteLine();

            Console.WriteLine("For the indexer you are getting the position of digits in binary representation rules - form right to left");
            Console.WriteLine(first64Bit[1]);
            Console.WriteLine("That was the digit at pos 1");
            Console.WriteLine(".............................................................................");

            Console.WriteLine("Equals()");
            Console.WriteLine(first64Bit == sec64Bit);
            Console.WriteLine("Must be true");
            Console.WriteLine(".............................................................................");
            
            Console.WriteLine("==");
            Console.WriteLine(first64Bit == sec64Bit);
            Console.WriteLine("Must be true");
            Console.WriteLine(".............................................................................");

            Console.WriteLine("!=");
            Console.WriteLine(first64Bit != sec64Bit);
            Console.WriteLine("Must be fasle");
            Console.WriteLine(".............................................................................");
            Console.WriteLine();

            Console.WriteLine("Hash");
            Console.WriteLine(first64Bit.GetHashCode());
            Console.WriteLine(sec64Bit.GetHashCode());
        }
    }
}
