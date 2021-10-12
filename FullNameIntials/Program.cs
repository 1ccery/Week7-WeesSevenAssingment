using System;

namespace FullNameIntials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string userfirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string userlastName = Console.ReadLine();

            Console.WriteLine($"Hello {userfirstName[0]}. {userlastName[0]}.");
        }
    }
}
