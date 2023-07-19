using System.Transactions;

namespace BasicProblems
{
    internal class PowerOftwo
    {
        internal static void GetTable()
        {
            Console.WriteLine("enter the value");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input >= 30)
            {
                Console.WriteLine("Enter value less than 31");
            }
            else
            {
                int result = 1;
                for(int i = 0; i < input; i++)
                {
                    result *= 2;
                    Console.WriteLine(result);
                }
            }
        }
    }
}