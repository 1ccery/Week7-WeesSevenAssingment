using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string userfirstName = Console.ReadLine();

            Random rnd = new Random();
            int index = rnd.Next(0, userfirstName.Length);

            Console.WriteLine(userfirstName[index]);

        }
    }
}
