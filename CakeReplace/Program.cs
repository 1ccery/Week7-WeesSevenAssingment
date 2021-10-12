using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string cakeReplace = "The c4ke i3 4 l1e.".ToLower();

            cakeReplace = cakeReplace.Replace('4', 'a');
            cakeReplace = cakeReplace.Replace('1', 'i');
            cakeReplace = cakeReplace.Replace('3', 's');

            Console.WriteLine(cakeReplace);
        }
    }
}
