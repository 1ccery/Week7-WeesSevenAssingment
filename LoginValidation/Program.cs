using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int counter = 0;

            while (i < 3)
            {
                string Login;
                string Password;
                Console.WriteLine("PIN: ");
                string PINcode = Console.ReadLine();
                Console.WriteLine("Kasutajanimi: ");
                Login = Console.ReadLine();

                Console.WriteLine("Parool: ");
                Password = Console.ReadLine();




                if (PINcode == "1532")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }

                else if ((Login == "user1") && (Password == "password1") && (PINcode == "1532"))
                {
                    Console.WriteLine("Tere tulemast!");
                }
                else if ((Login != "admin") && (Password == "pass1234"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else if ((Login == "admin") && (Password != "pass1234"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else
                {
                    i++; 
                    Console.WriteLine($"Proovi uuesti! {3 - i} katset on jäänud.");

                }




            }
        }
    }
}
