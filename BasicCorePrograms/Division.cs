namespace BasicProblems
{
    internal class Division
    {
        internal static void GetQuoationAndRemainder()
        {
            Console.WriteLine("Enter divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quatient "+divident/divisor);
            Console.WriteLine("Remainder "+divident%divisor);
        }
    }
}