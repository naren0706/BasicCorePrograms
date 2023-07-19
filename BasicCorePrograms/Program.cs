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
                Console.WriteLine("1.Heads and Tails\n2.LeepYear\n3.power of two");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        HeadsAndTails.Percentage();
                        break;
                    case 2:
                        LeapYear.IsLeapyr();
                        break;
                    case 3:
                        PowerOftwo.GetTable();
                        break;
                    
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
