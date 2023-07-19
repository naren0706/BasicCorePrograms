namespace BasicProblems
{
    internal class Swap
    {
        internal static void swap()
        {
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());    
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a=a - b;
            Console.WriteLine("the numbers are Swapped "+a+" "+b);
        }
    }
}