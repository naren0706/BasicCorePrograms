namespace BasicProblems
{
    internal class Factors
    {
        internal static void GetFactors()
        {
            Console.WriteLine("Enter the Number");
            int input = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}