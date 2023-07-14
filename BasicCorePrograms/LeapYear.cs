namespace BasicProblems
{
    internal class LeapYear
    {
        internal static void IsLeapyr()
        {
            Console.WriteLine("Eter the year");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input % 4 == 0)
                Console.WriteLine("It is a leap year");
            else
                Console.WriteLine("It is not a leap year");
        }
    }
}