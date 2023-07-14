using BasicPrograms;
using System;

namespace BasicProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Enter the input :");
                Console.WriteLine("1.Heads and Tails\n2.LeepYear");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        HeadsAndTails.Percentage();
                        break;
                    
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
