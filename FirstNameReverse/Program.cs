using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string userfirstName = Console.ReadLine();

            if (userfirstName.Length >= 5)
            {
                for (int i = userfirstName.Length - 1; i >= 0; i--)
                {
                    Console.Write(userfirstName[i]);
                }
            }
            else
            {
                Console.WriteLine(userfirstName);



            }

            
        }
    }
}
