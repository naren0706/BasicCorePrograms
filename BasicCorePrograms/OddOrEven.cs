namespace BasicProblems
{
    internal class OddOrEven
    {
        internal static void Find()
        {
            Console.WriteLine("Enter the number");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            
    }
}