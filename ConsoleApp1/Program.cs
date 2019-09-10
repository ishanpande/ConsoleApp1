using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years experience do you have in professional programming?");
            string input = Console.ReadLine();

            switch(int.Parse(input))
            {
                case 0: {
                        Console.WriteLine("Need lots of practice");
                        break;
                        }
                case 1:
                    {
                        Console.WriteLine("Looks like you have a little experience");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Wow! youve been doing this for a little while");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please provide a valid input");
                        break;
                    }
            }
        }
    }
}
