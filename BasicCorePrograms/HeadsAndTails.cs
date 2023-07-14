using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class HeadsAndTails
    {
        public static void Percentage()
        {
            Random random = new Random();
            Console.WriteLine("Enter the number of loop");
            int headCount = 0, tailCount = 0;
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = input;
            while (temp > 0)
            {
                double value = random.NextDouble();


                if (value > 0.5)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
                temp--;
            }
            int headPercentage = (headCount*100) /input;
            Console.WriteLine("Head Percentage is "+headPercentage);
            Console.WriteLine("Tail Percentage is "+(100-headPercentage));
        }
    }
}
