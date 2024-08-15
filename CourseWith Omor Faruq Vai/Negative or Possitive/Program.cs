namespace Negative_or_Possitive
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a; 
            a  = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (a > 0)
                Console.WriteLine("Possitive Number");
            else Console.WriteLine("Negative Number");

        }
    }
}
