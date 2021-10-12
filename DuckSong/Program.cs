using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string ducks;
            for (int i = 5; i > 0; i--)//int i = 0 - start, i < 10 - end, i++ step
            {
                if (i > 1)
                {
                    ducks = "ducks";

                }

                else
                {
                    ducks = "duck";
                }



                Console.WriteLine($"{i} Little {ducks} went oout one day");
                Console.WriteLine("Over the hill and far away");
                Console.WriteLine("Mother duck said, \"Quack, quack, quack, quack \"");

                if (i == 2)
                {

                    ducks = "duck";

                }

                if (i > 1)
                    Console.WriteLine($"But only {i - 1 } little {ducks} came back.");

                else
                {
                    Console.WriteLine($"But none of the {i + 4} little {ducks} came back. ");

                }


                Console.WriteLine();
            }
        }

    }



}
