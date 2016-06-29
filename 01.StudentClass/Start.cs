namespace _01.StudentClass
{
    using System;
    using Enumerations;

    public class Start
    {
        public static void Main(string[] args)
        {
            Student peshoPeshev = new Student("Pesho", "Peshov", "Peshev", 3, "Varna", "087946958*", "peshev@pesho.bg");
            Student peshoGoshev = new Student("Pesho", "Goshov", "Goshev", 4, "Sofia", "087946558*", "goshev@pesho.bg");
            Student anotherPeshoGoshev = new Student("Pesho", "Goshov", "Goshev", 3, "Burgas", "087946558*", "goshev@pesho.bg");

            Console.WriteLine("Equals() test");
            Console.WriteLine(peshoGoshev.Equals(peshoPeshev));
            Console.WriteLine("It must be True");
            Console.WriteLine(".........................................................");
            Console.WriteLine();

            Console.WriteLine("== op test");
            Console.WriteLine(peshoGoshev == peshoGoshev);
            Console.WriteLine("It must be True");
            Console.WriteLine(".........................................................");
            Console.WriteLine();

            Console.WriteLine("!= op test");
            Console.WriteLine(peshoGoshev != peshoGoshev);
            Console.WriteLine("It must be False");
            Console.WriteLine(".........................................................");
            Console.WriteLine();

            Console.WriteLine("ToString() test");
            Console.WriteLine(peshoGoshev);
            Console.WriteLine(".........................................................");
            Console.WriteLine();

            Console.WriteLine("GetHashCode() test");
            Console.WriteLine(peshoGoshev.GetHashCode());
            Console.WriteLine(".........................................................");
            Console.WriteLine();

            var fmi = Faculty.FMI;
            Student ivan = new Student("Ivan", "Nikolov", "Petrov", 2, "any", "08", "mail", fmi);

            Student gosho = ivan.Clone() as Student;

            Console.WriteLine(gosho.FirstName);
            Console.WriteLine("That was the ShallowClone check for properties");
            Console.WriteLine(gosho.Faculty);
            Console.WriteLine("That was the ShallowClone check for enums in the class they are acting like value types, right?");
            gosho.Faculty = Faculty.SF;
            Console.WriteLine("They should be different after gosho.Faculty = Faculty.SF;");
            Console.WriteLine(ivan.Faculty);
            Console.WriteLine(gosho.Faculty);

            Console.WriteLine(peshoGoshev.CompareTo(anotherPeshoGoshev));
            Console.WriteLine("The result must be 1, because peshoGoshev have ssn 4 bigger than anotherPeshoGoshev's ssn");
        }
    }
}
