using System;

namespace _04.Person_class
{
    public class Start
    {
        public static void Main()
        {
            Person gosho = new Person("Georgi Hadjipopov");
            Person pesho = new Person("Pesho Hadjiyanev", 12);
            Console.WriteLine(gosho.ToString());
            Console.WriteLine(pesho.ToString());
        }
    }
}
