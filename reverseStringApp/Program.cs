using System;

namespace reverseStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be reversed");

            string inputString = Console.ReadLine();


            ReverseStringMethod(inputString);
            ReverseStringCountBackwards(inputString);

            string ReverseStringMethod(string s)
            {

                Console.WriteLine("Reverse by converting to Array and using builtin Array.Reverse()");

                char[] array = s.ToCharArray();

                Array.Reverse(array);

                string result = new string(array);


                Console.WriteLine(result);
                return result;

            }

            string ReverseStringCountBackwards(string s)
            {
                Console.WriteLine("Reverse by using while loop to count backwards from the last char in the string");

                string result = "";

                int pointer = s.Length - 1;

                while (pointer >= 0)
                {
                    result += s[pointer];
                    pointer--;
                }
                Console.WriteLine(result);
                return result;

            }
        }
    }
}
