using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFizzBuzz();
            ReverseString();
        }

        private static void DisplayFizzBuzz()
        {
            bool isIDivisibleBy3 = false, isIDivisibleBy5 = false;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                    isIDivisibleBy3 = true;
                }
                    
                if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    isIDivisibleBy5 = true;
                }

                if(isIDivisibleBy3 && isIDivisibleBy5)
                {
                    Console.WriteLine("fizzbuzz");
                }

                isIDivisibleBy3 = false;
                isIDivisibleBy5 = false;
            }
        }


        private static void ReverseString()
        {
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();

            for (int i = charArray.Length -1 ; i >= 0; i--)
            {
                Console.Write(charArray[i]);
            }
        }
    }
}
