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

            string ReverseStringMethod(string s)
            {

                Console.WriteLine("Reverse by converting to Array and using builtin Array.Reverse()");

                char[] array = s.ToCharArray();

                Array.Reverse(array);

                string result = new string(array);


                Console.WriteLine(result);
                return result;

            }

        }
    }
}
