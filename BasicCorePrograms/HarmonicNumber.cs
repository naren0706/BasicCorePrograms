namespace BasicProblems
{
    internal class HarmonicNumber
    {
        internal static void GetNumber()
        {
            Console.WriteLine("Enter the number");
            int input = Convert.ToInt32(Console.ReadLine());
            double result = 0.0;
            while(input > 0) 
            {
                result += (1 / (float)input--);   
            }
            Console.WriteLine(result);
        }
    }
}